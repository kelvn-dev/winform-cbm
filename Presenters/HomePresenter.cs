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
  public class HomePresenter {

    private HomeForm view;

    public HomePresenter(HomeForm view) {
      this.view = view;
      LoadSelectedData();

      this.view.SaveEvent += Save;
      this.view.ResetPasswordEvent += ResetPassword;
    }

    private void LoadSelectedData() {
      Administrator admin = AdminService.GetById(view.id);
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

    private void ResetPassword(object sender, EventArgs e) {
      try {
        AdminService.ResetPassword(view.administrator, view.oldPassword, view.password);
        view.isSuccessful = true;
        view.message = "Reset password successfully";
      }
      catch (Exception exception) {
        view.isSuccessful = false;
        view.message = exception.Message;
      }
      
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
        avatar    = bytes,
      };
      try {
        //ModelValidation.Validate(admin);
        admin.id = view.id;
        AdminService.Update(admin);
        view.message = "Updated successfully";
        view.isSuccessful = true;
      }
      catch (Exception ex) {
        view.isSuccessful = false;
        view.message = ex.Message;
      }
    }
  }
}
