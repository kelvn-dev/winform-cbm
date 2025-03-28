using CBM.Models;
using CBM.Services;
using CBM.Utilities;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static CBM.Enums;

namespace CBM.Views {
  public partial class BuyerForm : Form {

    #region Css

    private void CssBtn() {
      UserControlUtils.CssSaveBtn(backBtn);
    }
    private void CssLabel() {
      UserControlUtils.CssFieldLabel(avatarLabel);
      UserControlUtils.CssFieldLabel(usernameLabel);
      UserControlUtils.CssFieldLabel(emailLabel);
      UserControlUtils.CssFieldLabel(phoneLabel);
      UserControlUtils.CssFieldLabel(addressLabel);
    }
    private void CssTextbox() {
      UserControlUtils.CssTextbox(usernameField, string.Empty);
      UserControlUtils.CssTextbox(emailField, string.Empty);
      UserControlUtils.CssTextbox(phoneField, string.Empty);
      UserControlUtils.CssTextbox(addressField, string.Empty);
      UserControlUtils.CssTextbox(zipcodeField, string.Empty);
    }
    private void CssIconPictureBox() {
      avatarPictureBox.IconColor = ColorTranslator.FromHtml("#183153");
      avatarPictureBox.ForeColor = ColorTranslator.FromHtml("#183153");
    }

    #endregion

    public BuyerForm(Guid id, VehicleForm vehicleForm) {
      InitializeComponent();
      _id = id;
      this.vehicleForm = vehicleForm;

      CssBtn();
      CssLabel();
      CssTextbox();
      CssIconPictureBox();

      AssociateEvents();
      LoadData();
    }

    private void LoadData() {
      Member member = MemberService.GetById(id);
      usernameField.Texts = member.username.Trim();
      emailField.Texts = member.email.Trim();
      phoneField.Texts = member.phone.Trim();
      addressField.Texts = member.address != null ? member.address.Trim() : string.Empty;
      zipcodeField.Texts = member.zipcode != null ? member.zipcode.Trim() : string.Empty;
      if (member.avatar != null) {
        MemoryStream stream = new MemoryStream(member.avatar);
        avatarPictureBox.Image = Image.FromStream(stream);
      }
    }

    #region Events

    private void AssociateEvents() {
      backBtn.Click += delegate {
        vehicleForm.Show();
        this.Hide();
      };
    }

    #endregion

    #region Variables

    private Guid _id;
    private VehicleForm vehicleForm;

    public Guid id {
      get => _id;
      set => _id = value;
    }

    #endregion
  }
}
