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
  public class FuelTypePresenter {

    private FuelTypeForm view;
    private BindingSource bindingSource;

    public FuelTypePresenter(FuelTypeForm view) {
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
      byte[] bytes = null;
      if (view.logoFilename != null) {
        MemoryStream stream = new MemoryStream();
        view.logo.Save(stream, HelperUtils.GetImageFormat(view.logoFilename));
        bytes = stream.ToArray();
      }
      FuelType fuelType = new FuelType {
        name          = view.name,
        description   = view.description,
        logo          = bytes
      };
      try {
        //ModelValidation.Validate(fuelType);
        if (view.isUpdate) {
          fuelType.id = view.id;
          FuelTypeService.Update(fuelType);
          view.message = "Updated successfully";
        }
        else {
          FuelTypeService.Create(fuelType);
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
      List<FuelType> fuelTypeList = FuelTypeService.GetPaginatedData(
        pageIndex: view.currentPage - 1,
        keyword: view.keyword.Equals(Constant.PLACEHOLDER_SEARCH_TXT) ? null : view.keyword,
        orderBy: view.orderBy,
        orderDirection: view.orderDirection
       );
      UpdatePageLabel();
      CheckAvailabilityNavigatingPage();
      bindingSource.DataSource = fuelTypeList;
    }

    private void UpdatePageLabel() {
      view.totalPages = FuelTypeService.GetTotalPages();
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
      FuelType fuelType = bindingSource.Current as FuelType;
      view.id = fuelType.id;
      view.name = fuelType.name.Trim();
      view.description = fuelType.description.Trim();
      if (fuelType.logo != null) {
        MemoryStream stream = new MemoryStream(fuelType.logo);
        view.logo = Image.FromStream(stream);
      }
    }

    private void DeleteSelectedData(object sender, EventArgs e) {
      FuelType fuelType = bindingSource.Current as FuelType;
      FuelTypeService.DeleteById(fuelType.id);
      LoadListingData();
    }
  }
}
