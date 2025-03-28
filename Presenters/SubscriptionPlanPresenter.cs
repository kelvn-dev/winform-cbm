using CBM.Models;
using CBM.Services;
using CBM.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CBM.Presenters {
  public class SubscriptionPlanPresenter {

    private SubscriptionPlanForm view;
    private BindingSource bindingSource;

    public SubscriptionPlanPresenter(SubscriptionPlanForm view) {
      this.view = view;
      this.bindingSource = new BindingSource();

      LoadListingData();
      this.view.MapDataSource(bindingSource);

      this.view.CreateEvent += delegate (object sender, EventArgs e) { this.view.isUpdate = false; };
      this.view.SaveEvent += Save;
      this.view.UpdateEvent += LoadSelectedData;
      this.view.DeleteEvent += DeleteSelectedData;
      this.view.GetPrePageEvent += LoadPrePageData;
      this.view.GetNextPageEvent += LoadNextPageData;
      this.view.SortEvent += LoadSortedData;
      this.view.SearchEvent += LoadSearchedData;
    }

    private void Save(object sender, EventArgs e) {
      SubscriptionPlan subscriptionPlan = new SubscriptionPlan {
        name = view.name,
        monthlyPrice = float.Parse(view.monthlyPrice),
        yearlyPrice = float.Parse(view.yearlyPrice),
        vehicleLimit = Convert.ToInt32(view.vehicleLimit),
        description = view.description
      };
      try {
        //ModelValidation.Validate(subscriptionPlan);
        if (view.isUpdate) {
          subscriptionPlan.id = view.id;
          SubscriptionPlanService.Update(subscriptionPlan);
          view.message = "Updated successfully";
        }
        else {
          SubscriptionPlanService.Create(subscriptionPlan);
          view.message = "Created successfully";
        }
        view.isSuccessful = true;
        LoadListingData();
      }
      catch (Exception ex) {
        view.isSuccessful = false;
        view.message = ex.Message;
      }
    }

    private void LoadPrePageData(object sender, EventArgs e) {
      --view.currentPage;
      LoadListingData();
    }

    private void LoadNextPageData(object sender, EventArgs e) {
      ++view.currentPage;
      LoadListingData();
    }

    private void LoadSortedData(object sender, EventArgs e) {
      LoadListingData();
    }

    private void LoadSearchedData(object sender, EventArgs e) {
      LoadListingData();
    }

    private void LoadListingData() {
      List<SubscriptionPlan> subscriptionPlanList = SubscriptionPlanService.GetPaginatedData(
        pageIndex: view.currentPage - 1,
        keyword: view.keyword.Equals(Constant.PLACEHOLDER_SEARCH_TXT) ? null : view.keyword,
        orderBy: view.orderBy,
        orderDirection: view.orderDirection
       );
      UpdatePageLabel();
      CheckAvailabilityNavigatingPage();
      bindingSource.DataSource = subscriptionPlanList;
    }

    private void UpdatePageLabel() {
      view.totalPages = SubscriptionPlanService.GetTotalPages();
      if (view.totalPages == 0) {
        view.totalPages = 1;
      }
      Label pageLabel = view.GetPageLabel();
      pageLabel.Text = $"{view.currentPage} / {view.totalPages}";
    }

    private void CheckAvailabilityNavigatingPage() {
      Button prePageBtn = view.GetPrePageBtn();
      Button nextPageBtn = view.GetNextPageBtn();
      if (view.currentPage == 1) {
        prePageBtn.Enabled = false;
      }
      else {
        prePageBtn.Enabled = true;
      }

      if (view.currentPage == view.totalPages) {
        nextPageBtn.Enabled = false;
      }
      else {
        nextPageBtn.Enabled = true;
      }
    }

    private void LoadSelectedData(object sender, EventArgs e) {
      view.isUpdate = true;
      SubscriptionPlan subscriptionPlan = bindingSource.Current as SubscriptionPlan;
      view.id = subscriptionPlan.id;
      view.name = subscriptionPlan.name.Trim();
      view.monthlyPrice = subscriptionPlan.monthlyPrice.ToString();
      view.yearlyPrice = subscriptionPlan.yearlyPrice.ToString();
      view.vehicleLimit = subscriptionPlan.vehicleLimit.ToString();
      view.description = subscriptionPlan.description.Trim();
    }

    private void DeleteSelectedData(object sender, EventArgs e) {
      SubscriptionPlan subscriptionPlan = bindingSource.Current as SubscriptionPlan;
      SubscriptionPlanService.DeleteById(subscriptionPlan.id);
      LoadListingData();
    }
  }
}
