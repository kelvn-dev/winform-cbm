using CBM.Customs;
using CBM.Models;
using CBM.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;
using static CBM.Enums;

namespace CBM.Views {
  public partial class MarketplaceDealershipForm : Form {

    #region Css

    private void CssBtn() {
      UserControlUtils.CssCancelBtn(cancelBtn);
      UserControlUtils.CssSaveBtn(saveBtn);
    }
    private void CssLabel() {
      UserControlUtils.CssInformationLabel(informationLabel);
      UserControlUtils.CssFieldLabel(subscriptionPlanLabel);
      UserControlUtils.CssFieldLabel(renewalLabel);
      UserControlUtils.CssFieldLabel(startDateLabel);
      UserControlUtils.CssFieldLabel(endDateLabel);
      UserControlUtils.CssFieldLabel(statusLabel);
    }
    private void CssTextbox() {
    }
    private void CssTabControl() {
    }
    private void CssDatagridView() {
    }
    private void CssComboBox() {
      UserControlUtils.CssComboBox(subscriptionPlanComboBox);
      UserControlUtils.CssComboBox(statusField);
    }

    #endregion

    public MarketplaceDealershipForm(Guid memberId) {
      InitializeComponent();
      _memberId = memberId;

      CssBtn();
      CssLabel();
      CssTextbox();
      CssTabControl();
      CssDatagridView();
      CssComboBox();

      AssociateEvents();
      AssociateValidation();
    }

    #region Common

    #endregion

    #region Validation

    private void AssociateValidation() {
      
    }

    #endregion

    #region Events

    public event EventHandler RegisterEvent;
    public event EventHandler CancelEvent;

    private void AssociateEvents() {

      saveBtn.Click += delegate {
        RegisterEvent?.Invoke(this, EventArgs.Empty);
        if (isSuccessful) {

        }
        else {
          MessageBox.Show(message);
        }
      };

      cancelBtn.Click += delegate {
        CancelEvent?.Invoke(this, EventArgs.Empty);
      };
    }

    #endregion

    #region Variables

    private Guid _memberId;
    private Guid _id;
    private bool _isSuccessful;
    private string _message;

    public Guid memberId {
      get => _memberId;
      set => _memberId = value;
    }
    public Guid id {
      get => _id;
      set => _id = value;
    }
    public bool isSuccessful {
      get => _isSuccessful;
      set => _isSuccessful = value;
    }
    public string message {
      get => _message;
      set => _message = value;
    }

    public CBMComboBox GetSubscriptionPlanComboBox() {
      return subscriptionPlanComboBox;
    }

    public object subscriptionPlanId {
      get => subscriptionPlanComboBox.SelectedValue;
      set => subscriptionPlanComboBox.SelectedItem = value;
    }
    public bool isRenewal {
      get => renewalField.Checked;
      set => renewalField.Checked = value;
    }
    public DateTime startDate {
      get => startDateField.Value;
      set => startDateField.Value = value;
    }
    public DateTime endDate {
      get => endDateField.Value;
      set => endDateField.Value = value;  
    }
    public object status {
      get => statusField.SelectedValue;
      set => statusField.SelectedItem = value;
    }

    #endregion
  }
}
