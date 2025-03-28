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
  public class AdministratorPresenter {

    private AdministratorForm view;
    private BindingSource bindingSource;

    public AdministratorPresenter(AdministratorForm view) {
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
      if (view.avatarFilename != null) {
        MemoryStream stream = new MemoryStream();
        view.avatar.Save(stream, HelperUtils.GetImageFormat(view.avatarFilename));
        bytes = stream.ToArray();
      }
      Administrator admin = new Administrator {
        username  = view.username,
        email     = view.email,
        phone     = view.phone,
        address   = view.address,
        zipcode   = view.zipcode,
        avatar    = bytes
      };
      try {
        //ModelValidation.Validate(admin);
        if (view.isUpdate) {
          admin.id = view.id;
          AdminService.Update(admin);
          view.message = "Updated successfully";
        }
        else {
          admin.password = "12341234";
          AdminService.Create(admin);
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
      List<Administrator> administratorList = AdminService.GetPaginatedData(
        pageIndex: view.currentPage - 1,
        keyword: view.keyword.Equals(Constant.PLACEHOLDER_SEARCH_TXT) ? null : view.keyword,
        orderBy: view.orderBy,
        orderDirection: view.orderDirection
       );
      UpdatePageLabel();
      CheckAvailabilityNavigatingPage();
      bindingSource.DataSource = administratorList;
    }

    private void UpdatePageLabel() {
      view.totalPages = AdminService.GetTotalPages();
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
      Administrator admin = bindingSource.Current as Administrator;
      view.id = admin.id;
      view.username = admin.username.Trim();
      view.email = admin.email.Trim();
      view.phone = admin.phone.Trim();
      view.address = admin.address.Trim();
      view.zipcode = admin.zipcode.Trim();
      if (admin.avatar != null) {
        MemoryStream stream = new MemoryStream(admin.avatar);
        view.avatar = Image.FromStream(stream);
      }
    }

    private void DeleteSelectedData(object sender, EventArgs e) {
      Administrator admin = bindingSource.Current as Administrator;
      AdminService.DeleteById(admin.id);
      LoadListingData();
    }
  }
}
