using CBM.Customs;
using CBM.Models;
using CBM.Services;
using CBM.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CBM.Presenters {
  public class MarketplaceVehiclePresenter {

    private MarketplaceVehicleForm view;
    private BindingSource bindingSource;
    private List<KeyValuePair<Guid, string>> brandComboBoxData;
    private List<KeyValuePair<Guid, string>> vehicleModelComboBoxData;
    private List<KeyValuePair<Guid, string>> variantComboBoxData;

    public MarketplaceVehiclePresenter(MarketplaceVehicleForm view) {
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
      this.view.LoadCorrespondingVariant += GetVariantsByVehicleModelId;
      this.view.IsMyCarCheckedChanged += IsMyCarCheckedChanged;
      this.view.BuyEvent += BuyEvent;
      this.view.CheckVehicleLimit += CheckVehicleLimit;
    }

    private void CheckVehicleLimit(object sender, EventArgs e) {
      Member member = MemberService.GetById(view.memberId);
      Dealership dealership = DealershipService.GetByMemberId(member.id, false);
      if (dealership == null) {
        view.isSuccessful = false;
        view.message = "You haven't registered for a dealership !";
        return;
      }
      SubscriptionPlan subscriptionPlan = SubscriptionPlanService.GetById(dealership.subscriptionPlanId);
      if (VehicleService.CountByMemberId(member.id) >= subscriptionPlan.vehicleLimit) {
        view.isSuccessful = false;
        view.message = "Your vehicle limit exceed, please delete cars or upgrade your subscription plan";
        return;
      }
      view.isSuccessful = true;
    }

    private void IsMyCarCheckedChanged(object sender, EventArgs e) {
      if (view.myCar) {
        LoadMyVehicle();
      }
      else {
        LoadListingData();
      }
    }

    private void LoadMyVehicle() {
      List<Vehicle> vehicleList = VehicleService.GetByMemberId(view.memberId);
      UpdatePageLabel();
      CheckAvailabilityNavigatingPage();
      bindingSource.DataSource = vehicleList;
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

    private void GetVariantsByVehicleModelId(object sender, EventArgs e) {
      if (view.vehicleModelId != null) {
        variantComboBoxData = VariantService.GetComboBoxDataByVehicleModelId("name", Guid.Parse(view.vehicleModelId.ToString()));
        CBMComboBox variantComboBox = view.GetVariantComboBox();
        variantComboBox.DataSource = variantComboBoxData;
        variantComboBox.DisplayMember = "Value";
        variantComboBox.ValueMember = "Key";
        if (variantComboBoxData.Count == 0) {
          variantComboBox.Texts = string.Empty;
        }
      }
    }

    private void LoadComboBoxData() {
      brandComboBoxData = BrandService.GetComboBoxData("name");
      vehicleModelComboBoxData = VehicleModelService.GetComboBoxData("name");
      variantComboBoxData = VariantService.GetComboBoxData("name");

      CBMComboBox brandComboBox = view.GetBrandComboBox();
      brandComboBox.DataSource = brandComboBoxData;
      brandComboBox.DisplayMember = "Value";
      brandComboBox.ValueMember = "Key";

      CBMComboBox vehicleModelComboBox = view.GetVehicleModelComboBox();
      vehicleModelComboBox.DataSource = vehicleModelComboBoxData;
      vehicleModelComboBox.DisplayMember = "Value";
      vehicleModelComboBox.ValueMember = "Key";

      CBMComboBox vehicleComboBox = view.GetVariantComboBox();
      vehicleComboBox.DataSource = variantComboBoxData;
      vehicleComboBox.DisplayMember = "Value";
      vehicleComboBox.ValueMember = "Key";
    }

    private void Save(object sender, EventArgs e) {
      if (string.IsNullOrEmpty(view.title)) {
        Variant variant = VariantService.GetById(Guid.Parse(view.variantId.ToString()));
        VehicleModel vehicleModel = VehicleModelService.GetById(variant.vehicleModelId);
        Brand brand = BrandService.GetById(vehicleModel.brandId);
        view.title = $"{brand.name} {vehicleModel.name} {variant.name}";
      }

      Vehicle vehicle = new Vehicle {
        title = view.title,
        plateNo = view.plateNo,
        manufacturingYear = view.manufacturingYear,
        mileage = float.Parse(view.mileage),
        price = float.Parse(view.price),
        variantId = Guid.Parse(view.variantId.ToString()),
        status = Enums.Status.PENDING.ToString(),
        memberId = view.memberId
    };
      try {
        //ModelValidation.Validate(vehicle);
        if (view.isUpdate) {
          vehicle.id = view.id;
          VehicleService.Update(vehicle);
          view.message = "Updated successfully";
        }
        else {
          VehicleService.Create(vehicle);
          view.message = "Created successfully";
        }
        view.isSuccessful = true;
        if (view.myCar) {
          LoadMyVehicle();
        }
        else {
          LoadListingData();
        }
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
      List<Vehicle> vehicleList = VehicleService.GetPaginatedData(
        pageIndex: view.currentPage - 1,
        keyword: view.keyword.Equals(Constant.PLACEHOLDER_SEARCH_TXT) ? null : view.keyword,
        orderBy: view.orderBy,
        orderDirection: view.orderDirection
       );
      List<Vehicle> filteredVehicleList = new List<Vehicle> ();
      int calculatedTotalItems = 0;
      foreach (Vehicle vehicle in vehicleList) {
        if (vehicle.status == Enums.Status.APPROVED.ToString()) {
          filteredVehicleList.Add(vehicle);
          ++calculatedTotalItems;
        }
      }
      UpdatePageLabel(calculatedTotalItems);
      CheckAvailabilityNavigatingPage();
      bindingSource.DataSource = filteredVehicleList;
    }

    private void UpdatePageLabel(int calculatedTotalItems = -1) {
      view.totalPages = VehicleService.GetTotalPages(calculatedTotalItems);
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
      Vehicle vehicle = bindingSource.Current as Vehicle;
      view.id = vehicle.id;
      view.title = vehicle.title.Trim();
      view.plateNo = vehicle.plateNo.Trim();
      view.manufacturingYear = vehicle.manufacturingYear.Trim();
      view.mileage = vehicle.mileage.ToString();
      view.price = vehicle.price.ToString();

      Variant variant = VariantService.GetById(vehicle.variantId);
      VehicleModel vehicleModel = VehicleModelService.GetById(variant.vehicleModelId);
      Brand brand = BrandService.GetById(vehicleModel.brandId);

      KeyValuePair<Guid, string> selectedBrand = new KeyValuePair<Guid, string>(brand.id, brand.name);
      view.brandId = selectedBrand;
      KeyValuePair<Guid, string> selectedVehicleModel = new KeyValuePair<Guid, string>(vehicleModel.id, vehicleModel.name);
      view.vehicleModelId = selectedVehicleModel;
      KeyValuePair<Guid, string> selectedVariant = new KeyValuePair<Guid, string>(variant.id, variant.name);
      view.variantId = selectedVariant;
    }

    private void DeleteSelectedData(object sender, EventArgs e) {
      Vehicle vehicle = bindingSource.Current as Vehicle;
      VehicleService.DeleteById(vehicle.id);
      if (view.myCar) {
        LoadMyVehicle();
      }
      else {
        LoadListingData();
      }
    }

    private void BuyEvent(object sender, EventArgs e) {
      Vehicle vehicle = bindingSource.Current as Vehicle;
      try {
        VehicleService.MarkAsSold(vehicle.id, view.memberId);
        view.isSuccessful = true;
        view.message = "We will reach out to you soon !";
        if (view.myCar) {
          LoadMyVehicle();
        }
        else {
          LoadListingData();
        }
      }
      catch (Exception ex) {
        view.isSuccessful = false;
        view.message = ex.Message;
      }
    }
  }
}
