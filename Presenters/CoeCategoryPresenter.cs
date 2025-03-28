using CBM.Models;
using CBM.Services;
using CBM.Utilities;
using CBM.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CBM.Presenters {
  public class CoeCategoryPresenter {

    private CoeCategoryForm view;
    private BindingSource bindingSource;

    public CoeCategoryPresenter(CoeCategoryForm view) {
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
      CoeCategory coeCategory = new CoeCategory {
        name           = view.name,
        description    = view.description,
        engineCapacity = Convert.ToInt32(view.engineCapacity),
        maxPowerOutput = Convert.ToInt32(view.maxPowerOutput),
        price          = float.Parse(view.price),
        periodYear     = Convert.ToInt32(view.periodYear)
      };
      try {
        ModelValidation.Validate(coeCategory);
        if (view.isUpdate) {
          coeCategory.id = view.id;
          CoeCategoryService.Update(coeCategory);
          view.message = "Updated successfully";
        }
        else {
          CoeCategoryService.Create(coeCategory);
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
      List<CoeCategory> coeCategoryList = CoeCategoryService.GetPaginatedData(
        pageIndex: view.currentPage - 1,
        keyword: view.keyword.Equals(Constant.PLACEHOLDER_SEARCH_TXT) ? null : view.keyword,
        orderBy: view.orderBy,
        orderDirection: view.orderDirection
       );
      UpdatePageLabel();
      CheckAvailabilityNavigatingPage();
      bindingSource.DataSource = coeCategoryList;
    }

    private void UpdatePageLabel() {
      view.totalPages = CoeCategoryService.GetTotalPages();
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
      CoeCategory coeCategory = bindingSource.Current as CoeCategory;
      view.id = coeCategory.id;
      view.name = coeCategory.name.Trim();
      view.description = coeCategory.description.Trim();
      view.engineCapacity = coeCategory.engineCapacity.ToString();
      view.maxPowerOutput = coeCategory.maxPowerOutput.ToString();
      view.price = coeCategory.price.ToString();
      view.periodYear = coeCategory.periodYear.ToString();
    }

    private void DeleteSelectedData(object sender, EventArgs e) {
      CoeCategory coeCategory = bindingSource.Current as CoeCategory;
      CoeCategoryService.DeleteById(coeCategory.id);
      LoadListingData();
    }
  }
}
