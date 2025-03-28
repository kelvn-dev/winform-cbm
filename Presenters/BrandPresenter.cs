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
  public class BrandPresenter {

    private BrandForm view;
    private BindingSource bindingSource;

    public BrandPresenter(BrandForm view) {
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
      Brand brand = new Brand {
        name          = view.name,
        description   = view.description,
        logo          = bytes
      };
      try {
        //ModelValidation.Validate(brand);
        if (view.isUpdate) {
          brand.id = view.id;
          BrandService.Update(brand);
          view.message = "Updated successfully";
        }
        else {
          BrandService.Create(brand);
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
      List<Brand> brandList = BrandService.GetPaginatedData(
        pageIndex: view.currentPage - 1,
        keyword: view.keyword.Equals(Constant.PLACEHOLDER_SEARCH_TXT) ? null : view.keyword,
        orderBy: view.orderBy,
        orderDirection: view.orderDirection
       );
      UpdatePageLabel();
      CheckAvailabilityNavigatingPage();
      bindingSource.DataSource = brandList;
    }

    private void UpdatePageLabel() {
      view.totalPages = BrandService.GetTotalPages();
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
      Brand brand = bindingSource.Current as Brand;
      view.id = brand.id;
      view.name = brand.name.Trim();
      view.description = brand.description.Trim();
      if (brand.logo != null) {
        MemoryStream stream = new MemoryStream(brand.logo);
        view.logo = Image.FromStream(stream);
      }
    }

    private void DeleteSelectedData(object sender, EventArgs e) {
      Brand brand = bindingSource.Current as Brand;
      try {
        BrandService.DeleteById(brand.id);
        LoadListingData();
      } 
      catch(Exception ex) {
        view.message = ex.Message;
        view.isSuccessful = false;
      }
    }
  }
}
