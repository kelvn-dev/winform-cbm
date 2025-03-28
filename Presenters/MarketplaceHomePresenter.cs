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
  public class MarketplaceHomePresenter {

    private MarketplaceHomeForm view;

    public MarketplaceHomePresenter(MarketplaceHomeForm view) {
      this.view = view;
      LoadSelectedData();

      this.view.SaveEvent += Save;
      this.view.ResetPasswordEvent += ResetPassword;
    }

    private void LoadSelectedData() {
      Member member = MemberService.GetById(view.id);
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

    private void ResetPassword(object sender, EventArgs e) {
      try {
        MemberService.ResetPassword(view.member, view.oldPassword, view.password);
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
      Member member = new Member {
        username  = view.username,
        email     = view.email,
        phone     = view.phone,
        address   = view.address,
        zipcode   = view.zipcode,
        avatar    = bytes,
      };
      try {
        //ModelValidation.Validate(member);
        member.id = view.id;
        MemberService.Update(member);
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
