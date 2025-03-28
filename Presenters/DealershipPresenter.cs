using CBM.Customs;
using CBM.Models;
using CBM.Services;
using CBM.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CBM.Presenters {
  public class DealershipPresenter {

    private DealershipForm view;
    private BindingSource bindingSource;
    private List<KeyValuePair<Guid, string>> memberComboBoxData;
    private List<KeyValuePair<Guid, string>> subscriptionPlanComboBoxData;

    public DealershipPresenter(DealershipForm view) {
      this.view = view;
      this.bindingSource = new BindingSource();

      LoadComboBoxData();
      LoadListingData();
      this.view.MapDataSource(bindingSource);

      this.view.CreateEvent += delegate (object sender, EventArgs e) { this.view.isUpdate = false; LoadComboBoxData(); };
      this.view.SaveEvent += Save;
      this.view.UpdateEvent += LoadSelectedData;
      this.view.DeleteEvent += DeleteSelectedData;
      this.view.GetPrePageEvent += LoadPrePageData;
      this.view.GetNextPageEvent += LoadNextPageData;
      this.view.SortEvent += LoadSortedData;
      this.view.SearchEvent += LoadSearchedData;
    }

    private void LoadComboBoxData() {
      memberComboBoxData = MemberService.GetComboBoxData("username");
      subscriptionPlanComboBoxData = SubscriptionPlanService.GetComboBoxData("name");

      CBMComboBox memberComboBox = view.GetMemberComboBox();
      memberComboBox.DataSource = memberComboBoxData;
      memberComboBox.DisplayMember = "Value";
      memberComboBox.ValueMember = "Key";

      CBMComboBox subscriptionPlanComboBox = view.GetSubscriptionPlanComboBox();
      subscriptionPlanComboBox.DataSource = subscriptionPlanComboBoxData;
      subscriptionPlanComboBox.DisplayMember = "Value";
      subscriptionPlanComboBox.ValueMember = "Key";
    }

    private void Save(object sender, EventArgs e) {
      Dealership dealership = new Dealership {
        memberId = Guid.Parse(view.memberId.ToString()),
        subscriptionPlanId = Guid.Parse(view.subscriptionPlanId.ToString()),
        isRenewal = view.isRenewal,
        startDate = view.startDate,
        endDate = view.endDate,
        status = view.status.ToString()
      };
      try {
        //ModelValidation.Validate(dealership);
        if (view.isUpdate) {
          dealership.id = view.id;
          DealershipService.Update(dealership);
          view.message = "Updated successfully";
        }
        else {
          DealershipService.Create(dealership);
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
      List<Dealership> dealershipList = DealershipService.GetPaginatedData(
        pageIndex: view.currentPage - 1,
        keyword: view.keyword.Equals(Constant.PLACEHOLDER_SEARCH_TXT) ? null : view.keyword,
        orderBy: view.orderBy,
        orderDirection: view.orderDirection
       );
      foreach (Dealership dealership in dealershipList) {
        SubscriptionPlan subscriptionPlan = SubscriptionPlanService.GetById(dealership.subscriptionPlanId);
        Member member = MemberService.GetById(dealership.memberId);

        dealership.memberName = member.username;
        dealership.subscriptionPlanName = subscriptionPlan.name;
      }
      UpdatePageLabel();
      CheckAvailabilityNavigatingPage();
      bindingSource.DataSource = dealershipList;
    }

    private void UpdatePageLabel() {
      view.totalPages = DealershipService.GetTotalPages();
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
      Dealership dealership = bindingSource.Current as Dealership;
      view.id = dealership.id;
      view.isRenewal = dealership.isRenewal;
      view.startDate = dealership.startDate;
      view.endDate = dealership.endDate;
      view.status = dealership.status.Trim();
      
      SubscriptionPlan subscriptionPlan = SubscriptionPlanService.GetById(dealership.subscriptionPlanId);
      Member member = MemberService.GetById(dealership.memberId);

      KeyValuePair<Guid, string> selectedMember = new KeyValuePair<Guid, string>(member.id, member.username);
      view.memberId = selectedMember;
      KeyValuePair<Guid, string> selectedSubscriptionPlan = new KeyValuePair<Guid, string>(subscriptionPlan.id, subscriptionPlan.name);
      view.subscriptionPlanId = selectedSubscriptionPlan;
    }

    private void DeleteSelectedData(object sender, EventArgs e) {
      Dealership dealership = bindingSource.Current as Dealership;
      DealershipService.DeleteById(dealership.id);
      LoadListingData();
    }
  }
}
