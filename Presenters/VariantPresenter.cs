using CBM.Customs;
using CBM.Models;
using CBM.Services;
using CBM.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CBM.Presenters {
  public class VariantPresenter {

    private VariantForm view;
    private BindingSource bindingSource;
    private List<KeyValuePair<Guid, string>> brandComboBoxData;
    private List<KeyValuePair<Guid, string>> vehicleModelComboBoxData;
    private List<KeyValuePair<Guid, string>> fuelTypeComboBoxData;

    public VariantPresenter(VariantForm view) {
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
      this.view.LoadCorrespondingVehicleModel += GetVehicleModelsByBrandId;
    }

    private void GetVehicleModelsByBrandId(object sender, EventArgs e) {
      if (view.brandId != null) {
        vehicleModelComboBoxData = VehicleModelService.GetComboBoxDataByBrandId("name", Guid.Parse(view.brandId.ToString()));
        CBMComboBox vehicleModelComboBox = view.GetVehicleModelComboBox();
        vehicleModelComboBox.DataSource = vehicleModelComboBoxData;
        vehicleModelComboBox.DisplayMember = "Value";
        vehicleModelComboBox.ValueMember = "Key";
        if (vehicleModelComboBoxData.Count == 0) {
          vehicleModelComboBox.Texts = string.Empty;
        }
      }
    }

    private void LoadComboBoxData() {
      brandComboBoxData = BrandService.GetComboBoxData("name");
      vehicleModelComboBoxData = VehicleModelService.GetComboBoxData("name");
      fuelTypeComboBoxData = FuelTypeService.GetComboBoxData("name");

      CBMComboBox brandComboBox = view.GetBrandComboBox();
      brandComboBox.DataSource = brandComboBoxData;
      brandComboBox.DisplayMember = "Value";
      brandComboBox.ValueMember = "Key";

      CBMComboBox vehicleModelComboBox = view.GetVehicleModelComboBox();
      vehicleModelComboBox.DataSource = vehicleModelComboBoxData;
      vehicleModelComboBox.DisplayMember = "Value";
      vehicleModelComboBox.ValueMember = "Key";

      CBMComboBox fuelTypeComboBox = view.GetFuelTypeComboBox();
      fuelTypeComboBox.DataSource = fuelTypeComboBoxData;
      fuelTypeComboBox.DisplayMember = "Value";
      fuelTypeComboBox.ValueMember = "Key";
    }

    private void Save(object sender, EventArgs e) {
      Variant variant = new Variant {
        name = view.variantName,
        variantYear = view.variantYear,
        engineType = view.engineType,
        driveType = view.driveType,
        batteryType = view.batteryType,
        autoHeadlight = view.autoHeadlight,
        navigationSystem = view.navigationSystem,
        bluetoothInterface = view.bluetoothInterface,
        smartKey = view.smartKey,
        vehicleModelId = Guid.Parse(view.vehicleModelId.ToString()),
        fuelTypeId = Guid.Parse(view.fuelTypeId.ToString())
      };
      try {
        //ModelValidation.Validate(variant);
        if (view.isUpdate) {
          variant.id = view.id;
          VariantService.Update(variant);
          view.message = "Updated successfully";
        }
        else {
          VariantService.Create(variant);
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
      List<Variant> variantList = VariantService.GetPaginatedData(
        pageIndex: view.currentPage - 1,
        keyword: view.keyword.Equals(Constant.PLACEHOLDER_SEARCH_TXT) ? null : view.keyword,
        orderBy: view.orderBy,
        orderDirection: view.orderDirection
       );
      foreach (Variant variant in variantList) {
        VehicleModel vehicleModel = VehicleModelService.GetById(variant.vehicleModelId);
        Brand brand = BrandService.GetById(vehicleModel.brandId);

        variant.brandName = brand.name;
        variant.vehicleModelName = vehicleModel.name;
        KeyValuePair<Guid, string> selectedFuelType = fuelTypeComboBoxData.Find(item => item.Key == variant.fuelTypeId);
        variant.fuelTypeName = selectedFuelType.Value;
      }
      UpdatePageLabel();
      CheckAvailabilityNavigatingPage();
      bindingSource.DataSource = variantList;
    }

    private void UpdatePageLabel() {
      view.totalPages = VariantService.GetTotalPages();
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
      Variant variant = bindingSource.Current as Variant;
      view.id = variant.id;
      view.variantName = variant.name.Trim();
      view.variantYear = variant.variantYear.Trim();
      view.engineType = variant.engineType.Trim();
      view.driveType = variant.driveType.Trim();
      view.batteryType = variant.batteryType.Trim();
      view.autoHeadlight = variant.autoHeadlight;
      view.navigationSystem = variant.navigationSystem;
      view.bluetoothInterface = variant.bluetoothInterface;
      view.smartKey = variant.smartKey;
      
      VehicleModel vehicleModel = VehicleModelService.GetById(variant.vehicleModelId);
      Brand brand = BrandService.GetById(vehicleModel.brandId);

      KeyValuePair<Guid, string> selectedBrand = new KeyValuePair<Guid, string>(brand.id, brand.name);
      view.brandId = selectedBrand;
      KeyValuePair<Guid, string> selectedVehicleModel = new KeyValuePair<Guid, string>(vehicleModel.id, vehicleModel.name);
      view.vehicleModelId = selectedVehicleModel;
      KeyValuePair<Guid, string> selectedFuelType = fuelTypeComboBoxData.Find(item => item.Key == variant.fuelTypeId);
      view.fuelTypeId = selectedFuelType;
    }

    private void DeleteSelectedData(object sender, EventArgs e) {
      Variant variant = bindingSource.Current as Variant;
      VariantService.DeleteById(variant.id);
      LoadListingData();
    }
  }
}
