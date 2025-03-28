using CBM.Customs;
using CBM.Models;
using CBM.Services;
using CBM.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CBM.Presenters {
  public class VehicleModelPresenter {

    private VehicleModelForm view;
    private BindingSource bindingSource;
    private List<KeyValuePair<Guid, string>> brandComboBoxData;
    private List<KeyValuePair<Guid, string>> vehicleTypeComboBoxData;

    public VehicleModelPresenter(VehicleModelForm view) {
      this.view = view;
      this.bindingSource = new BindingSource();

      LoadComboBoxData();
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

    private void LoadComboBoxData() {
      brandComboBoxData = BrandService.GetComboBoxData("name");
      vehicleTypeComboBoxData = VehicleTypeService.GetComboBoxData("name");

      CBMComboBox brandComboBox = view.GetBrandComboBox();
      brandComboBox.DataSource = brandComboBoxData;
      brandComboBox.DisplayMember = "Value";
      brandComboBox.ValueMember = "Key";

      CBMComboBox vehicleTypeComboBox = view.GetVehicleTypeComboBox();
      vehicleTypeComboBox.DataSource = vehicleTypeComboBoxData;
      vehicleTypeComboBox.DisplayMember = "Value";
      vehicleTypeComboBox.ValueMember = "Key";
    }

    private void Save(object sender, EventArgs e) {
      VehicleModel vehicleModel = new VehicleModel {
        name = view.name,
        modelYear = view.modelYear,
        brandId = Guid.Parse(view.brandId.ToString()),
        vehicleTypeId = Guid.Parse(view.vehicleTypeId.ToString())
      };
      try {
        //ModelValidation.Validate(vehicleModel);
        if (view.isUpdate) {
          vehicleModel.id = view.id;
          VehicleModelService.Update(vehicleModel);
          view.message = "Updated successfully";
        }
        else {
          VehicleModelService.Create(vehicleModel);
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
      List<VehicleModel> vehicleModelList = VehicleModelService.GetPaginatedData(
        pageIndex: view.currentPage - 1,
        keyword: view.keyword.Equals(Constant.PLACEHOLDER_SEARCH_TXT) ? null : view.keyword,
        orderBy: view.orderBy,
        orderDirection: view.orderDirection
       );
      foreach(VehicleModel vehicleModel in vehicleModelList) {
        KeyValuePair<Guid, string> selectedBrand = brandComboBoxData.Find(item => item.Key == vehicleModel.brandId);
        vehicleModel.brandName = selectedBrand.Value;
        KeyValuePair<Guid, string> selectedVehicleType = vehicleTypeComboBoxData.Find(item => item.Key == vehicleModel.vehicleTypeId);
        vehicleModel.vehicleTypeName = selectedVehicleType.Value;
      }
      UpdatePageLabel();
      CheckAvailabilityNavigatingPage();
      bindingSource.DataSource = vehicleModelList;
    }

    private void UpdatePageLabel() {
      view.totalPages = VehicleModelService.GetTotalPages();
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
      VehicleModel vehicleModel = bindingSource.Current as VehicleModel;
      view.id = vehicleModel.id;
      view.name = vehicleModel.name.Trim();
      view.modelYear = vehicleModel.modelYear.Trim();
      KeyValuePair<Guid, string> selectedBrand = brandComboBoxData.Find(item => item.Key == vehicleModel.brandId);
      view.brandId = selectedBrand;
      KeyValuePair<Guid, string> selectedVehicleType = vehicleTypeComboBoxData.Find(item => item.Key == vehicleModel.vehicleTypeId);
      view.vehicleTypeId = selectedVehicleType;
    }

    private void DeleteSelectedData(object sender, EventArgs e) {
      VehicleModel vehicleModel = bindingSource.Current as VehicleModel;
      VehicleModelService.DeleteById(vehicleModel.id);
      LoadListingData();
    }
  }
}
