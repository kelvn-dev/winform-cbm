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
  public class MemberPresenter {

    private MemberForm view;
    private BindingSource bindingSource;

    public MemberPresenter(MemberForm view) {
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
      Member member = new Member {
        username  = view.username,
        email     = view.email,
        phone     = view.phone,
        address   = view.address,
        zipcode   = view.zipcode,
        avatar    = bytes
      };
      try {
        //ModelValidation.Validate(member);
        if (view.isUpdate) {
          member.id = view.id;
          MemberService.Update(member);
          view.message = "Updated successfully";
        }
        else {
          member.password = "12341234";
          MemberService.Create(member);
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
      List<Member> memberistratorList = MemberService.GetPaginatedData(
        pageIndex: view.currentPage - 1,
        keyword: view.keyword.Equals(Constant.PLACEHOLDER_SEARCH_TXT) ? null : view.keyword,
        orderBy: view.orderBy,
        orderDirection: view.orderDirection
       );
      UpdatePageLabel();
      CheckAvailabilityNavigatingPage();
      bindingSource.DataSource = memberistratorList;
    }

    private void UpdatePageLabel() {
      view.totalPages = MemberService.GetTotalPages();
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
      Member member = bindingSource.Current as Member;
      view.id = member.id;
      view.username = member.username.Trim();
      view.email = member.email.Trim();
      view.phone = member.phone.Trim();
      view.address = member.address != null ? member.address.Trim() : string.Empty;
      view.zipcode = member.zipcode != null ? member.zipcode.Trim() : string.Empty;
      if (member.avatar != null) {
        MemoryStream stream = new MemoryStream(member.avatar);
        view.avatar = Image.FromStream(stream);
      }
    }

    private void DeleteSelectedData(object sender, EventArgs e) {
      Member member = bindingSource.Current as Member;
      MemberService.DeleteById(member.id);
      LoadListingData();
    }
  }
}
