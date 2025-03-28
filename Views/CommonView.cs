using CBM.Customs;
using CBM.Presenters;
using CBM.Utilities;
using FontAwesome.Sharp;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CBM.Views {
  public partial class CommonView : Form {

    #region Css

    private void CssThis() {
      // Remove header
      this.Text = string.Empty;
      this.ControlBox = false;
      this.DoubleBuffered = true;
      this.BackColor = ColorTranslator.FromHtml(Constant.BG_COLOR);

      headerBar.BackColor = Color.White;
    }

    private void CssPanelSideBar() {
      panelSideBar.BackColor = Color.White;
    }
    private void CssPanelHeader() {
      panelHeader.BackColor = ColorTranslator.FromHtml(Constant.DARK_BLUE_COLOR);
      panelHeader.MouseDown += DragForm;
    }
    private void CssPanelTitle() {
      panelTitle.BackColor = Color.White;
    }
    private void CssPanelShadow(Panel panel) {
      panel.BackColor = ColorTranslator.FromHtml("#f0f2f5");
    }
    private void CssPanelBg(Panel panel) {
      panel.BackColor = this.BackColor;
    }
    private void CssHeaderIcon(IconButton iconButton) {
      UserControlUtils.CssIconButton(iconButton, panelHeader.BackColor, Color.White, Constant.NORMAL_ICON_SIZE);
    }
    private void CssTitleIcon(IconButton iconButton) {
      UserControlUtils.CssIconButton(iconButton, Color.White, ColorTranslator.FromHtml("#001529"), 50);
    }
    private void CssTab(IconButton iconButton) {
      UserControlUtils.CssIconButton(iconButton, Color.White, ColorTranslator.FromHtml(Constant.ICON_COLOR), Constant.NORMAL_ICON_SIZE);
      iconButton.ImageAlign = ContentAlignment.MiddleLeft;
      iconButton.TextAlign = ContentAlignment.MiddleLeft;
      iconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
      iconButton.Padding = new Padding(left: 16, top: 0, right: 10, bottom: 0);
    }
    private void CssClickedTab(IconButton iconButton) {
      iconButton.BackColor = ColorTranslator.FromHtml(Constant.BG_COLOR);
      iconButton.ForeColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      iconButton.TextAlign = ContentAlignment.MiddleCenter;
      iconButton.IconColor = iconButton.ForeColor;
      iconButton.TextImageRelation = TextImageRelation.TextBeforeImage;
      iconButton.ImageAlign = ContentAlignment.MiddleCenter;
    }
    private void CssSubTab(Panel panel) {
      panel.BackColor = this.BackColor;
      panel.ForeColor = ColorTranslator.FromHtml(Constant.ICON_COLOR);
      panel.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE, FontStyle.Regular);
    }
    private void CssSubTab(CBMButton button) {
      button.TextAlign = ContentAlignment.MiddleLeft;
      button.BackColor = this.BackColor;
      button.ForeColor = ColorTranslator.FromHtml(Constant.ICON_COLOR);
      button.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE, FontStyle.Regular);
      button.Padding = new Padding(left: 16, top: 0, right: 10, bottom: 0);
    }
    private void CssClickedSubTab(CBMButton button) {
      button.BackColor = ColorTranslator.FromHtml(Constant.BOLD_BG_COLOR);
      button.ForeColor = Color.Black;
      button.BorderSize = 6;
      button.BorderColor = ColorTranslator.FromHtml(Constant.BG_COLOR);
      button.BorderRadius = 2;
    }
    private void CssLabelTitle(Label label) {
      label.ForeColor = ColorTranslator.FromHtml(Constant.BOLD_GRAY_COLOR);
      label.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE, FontStyle.Regular);
    }
    private void CssLabel(Label label) {
      UserControlUtils.CssFieldLabel(label);
    }

    #endregion

    public CommonView(LoginView loginView = null) {
      this.loginView = loginView;
      InitializeComponent();
      englishFIeld.Checked = true;
      CssThis();

      CssPanelSideBar();
      CssPanelHeader();
      CssPanelTitle();
      CssLabelTitle(labelTitle);
      CssLabelTitle(labelDetail);
      CssLabel(englistLabel);

      CssPanelShadow(panelShadow);
      CssPanelShadow(leftPanelShadow);

      CssPanelBg(panelBg);
      CssPanelBg(leftPanelBg);

      CssTitleIcon(iconTitle);

      CssHeaderIcon(iconButtonBell);
      CssHeaderIcon(iconButtonQuestion);
      CssHeaderIcon(iconButtonSearch);
      CssHeaderIcon(iconProfile);
      CssHeaderIcon(iconNotification);

      UserControlUtils.CssIconButton(closeBtn, Color.White, ColorTranslator.FromHtml(Constant.RED_COLOR));
      UserControlUtils.CssIconButton(restoreBtn, Color.White, ColorTranslator.FromHtml(Constant.YELLO_COLOR));
      UserControlUtils.CssIconButton(minBtn, Color.White, ColorTranslator.FromHtml(Constant.GREEN_COLOR));
      UserControlUtils.CssIconButton(iconTitle, Color.White, ColorTranslator.FromHtml(Constant.DARK_BLUE_COLOR), 50);

      CssTab(tabHome);
      CssTab(tabAdministrator);
      CssTab(tabCommonData);
      CssTab(tabAccountManagement);
      CssTab(tabUsedCar);
      CssTab(tabBidding);
      CssTab(tabCampaign);
      CssTab(tabBroadcast);
      CssTab(tabReportManagement);
      CssTab(tabSetting);

      CssSubTab(panelAdministrator);
      CssSubTab(panelCommonData);
      CssSubTab(panelAccountManagement);

      CssSubTab(tabUser);
      CssSubTab(tabGroup);
      CssSubTab(tabBrand);
      CssSubTab(tabModel);
      CssSubTab(tabVariant);
      CssSubTab(tabVehicleType);
      CssSubTab(tabFuelType);
      CssSubTab(tabCoe);
      CssSubTab(tabSubscriptionPlan);

      // Hide sub tabs
      hideAllSubTabs();

      AssociateEvents();

      ActivateDefaultTab();
    }

    #region Common

    

    private void hideAllSubTabs() {
      panelAdministrator.Visible = false;
      panelCommonData.Visible = false;
      panelAccountManagement.Visible = false;
    }
    private void showSubTab(Panel subTab) {
      // Toggle sub tab
      if (subTab.Visible == false) {
        hideAllSubTabs();
        subTab.Visible = true;
      }
      else
        subTab.Visible = false;
    }

    private void ActivateSubtab(object senderTab) {
      if (senderTab != null) {
        DisableSubTab();
        currentSubTab = (CBMButton)senderTab;
        CssClickedSubTab(currentSubTab);
        labelTitle.Text = $"{currentTab.Text} / {currentSubTab.Text}";
      }
    }
    private void DisableSubTab() {
      if (this.currentSubTab != null) {
        CssSubTab(currentSubTab);
      }
    }

    private void ActivateTab(object senderTab) {
      if (senderTab != null) {
        DisableTab();
        //Button
        currentTab = (IconButton)senderTab;
        CssClickedTab(currentTab);
        //Current Child Form Icon
        iconTitle.IconChar = currentTab.IconChar;
        labelTitle.Text = currentTab.Text;
        labelDetail.Text = string.Empty;
      }
    }

    private void DisableTab() {
      if (currentTab != null) {
        CssTab(currentTab);
      }
    }

    #endregion

    #region Events

    private void ActivateDefaultTab() {
      ActivateTab(tabHome);
      labelDetail.Text = englishFIeld.Checked == true ? "Manage your CBM dashboard" : "Quản lý bảng điều khiển CBM của bạn";
      HomeForm form = new HomeForm(loginView.administrator);
      new HomePresenter(form);
      OpenChildForm(form);
    }

    private void applyResources(ComponentResourceManager resources, Control.ControlCollection ctls, String lang) {
      foreach (Control ctl in ctls) {
        resources.ApplyResources(ctl, ctl.Name, new System.Globalization.CultureInfo(lang));
        applyResources(resources, ctl.Controls, lang);
      }
    }

    private void AssociateEvents() {
      closeBtn.Click += CloseForm;
      restoreBtn.Click += RestoreForm;
      minBtn.Click += MinimizeForm;

      englishFIeld.CheckedChanged += delegate {
        ComponentResourceManager resources = new ComponentResourceManager(this.GetType());
        applyResources(resources, this.Controls, englishFIeld.Checked == true ? "en" : "vi-VN");
        if (currentChildForm != null) {
          currentChildForm.Close();
          labelTitle.Text = englishFIeld.Checked == true ? "NOTE !!!" : "Chú ý !!!";
          labelDetail.Text = englishFIeld.Checked == true ? "Please reopen the tab that you're working on" : "Vui lòng mở lại tab mà bạn đang làm việc";
        }
      };

      // Tabs
      tabHome.Click += delegate (object sender, EventArgs e) {
        ActivateDefaultTab();
      };
      tabAdministrator.Click += delegate (object sender, EventArgs e) {
        ActivateTab(sender);
        showSubTab(panelAdministrator);
      };
      tabCommonData.Click += delegate (object sender, EventArgs e) {
        ActivateTab(sender);
        showSubTab(panelCommonData);
      };
      tabAccountManagement.Click += delegate (object sender, EventArgs e) {
        ActivateTab(sender);
        showSubTab(panelAccountManagement);
      };
      tabUsedCar.Click += delegate (object sender, EventArgs e) {
        ActivateTab(sender);
        hideAllSubTabs();
        VehicleForm form = new VehicleForm(this);
        new VehiclePresenter(form);
        OpenChildForm(form);
      };
      tabBidding.Click += delegate (object sender, EventArgs e) {
        ActivateTab(sender);
      };
      tabCampaign.Click += delegate (object sender, EventArgs e) {
        ActivateTab(sender);
      };
      tabBroadcast.Click += delegate (object sender, EventArgs e) {
        ActivateTab(sender);
      };
      tabReportManagement.Click += delegate (object sender, EventArgs e) {
        ActivateTab(sender);
      };
      tabSetting.Click += delegate (object sender, EventArgs e) {
        ActivateTab(sender);
      };

      // Sub tabs
      tabUser.Click += delegate (object sender, EventArgs e) {
        ActivateSubtab(sender);
        labelDetail.Text = englishFIeld.Checked == true ? "Invite and manage all users of the Admin Portal" : "Mời và quản lý tất cả người dùng của Cổng thông tin quản trị";
        AdministratorForm form = new AdministratorForm();
        new AdministratorPresenter(form);
        OpenChildForm(form);
      };
      tabGroup.Click += delegate (object sender, EventArgs e) {
        ActivateSubtab(sender);
        labelDetail.Text = englishFIeld.Checked == true ? "Create and manage all groups of the Admin Portal" : "Tạo và quản lý tất cả các nhóm của Cổng thông tin quản trị";
        GroupForm form = new GroupForm();
        new GroupPresenter(form);
        OpenChildForm(form);
      };
      tabBrand.Click += delegate (object sender, EventArgs e) {
        ActivateSubtab(sender);
        labelDetail.Text = englishFIeld.Checked == true ? "Create and manage all Brands of the Common Data" : "Tạo và quản lý tất cả các Nhãn hiệu của Dữ liệu chung";
        BrandForm form = new BrandForm();
        new BrandPresenter(form);
        OpenChildForm(form);
      };
      tabModel.Click += delegate (object sender, EventArgs e) {
        ActivateSubtab(sender);
        labelDetail.Text = englishFIeld.Checked == true ? "Create and manage all Models of the Common Data" : "Tạo và quản lý tất cả các Mô hình Dữ liệu chung";
        VehicleModelForm form = new VehicleModelForm();
        new VehicleModelPresenter(form);
        OpenChildForm(form);
      };
      tabVariant.Click += delegate (object sender, EventArgs e) {
        ActivateSubtab(sender);
        labelDetail.Text = englishFIeld.Checked == true ? "Create and manage all Variants of the Common Data" : "Tạo và quản lý tất cả các Biến thể của Dữ liệu chung";
        VariantForm form = new VariantForm();
        new VariantPresenter(form);
        OpenChildForm(form);
      };
      tabVehicleType.Click += delegate (object sender, EventArgs e) {
        ActivateSubtab(sender);
        labelDetail.Text = englishFIeld.Checked == true ? "Create and manage all Vehicle Type of the Common Data" : "Tạo và quản lý tất cả Loại phương tiện của Dữ liệu chung";
        VehicleTypeForm form = new VehicleTypeForm();
        new VehicleTypePresenter(form);
        OpenChildForm(form);
      };
      tabFuelType.Click += delegate (object sender, EventArgs e) {
        ActivateSubtab(sender);
        labelDetail.Text = englishFIeld.Checked == true ? "Create and manage all Fuel Type of the Common Data" : "Tạo và quản lý tất cả Loại nhiên liệu của Dữ liệu chung";
        FuelTypeForm form = new FuelTypeForm();
        new FuelTypePresenter(form);
        OpenChildForm(form);
      };
      tabCoe.Click += delegate (object sender, EventArgs e) {
        ActivateSubtab(sender);
        labelDetail.Text = englishFIeld.Checked == true ? "Create and manage all Coe Category of the Common Data" : "Tạo và quản lý tất cả Danh mục Coe của Dữ liệu chung";
        CoeCategoryForm form = new CoeCategoryForm();
        new CoeCategoryPresenter(form);
        OpenChildForm(form);
      };
      tabSubscriptionPlan.Click += delegate (object sender, EventArgs e) {
        ActivateSubtab(sender);
        labelDetail.Text = englishFIeld.Checked == true ? "Create and manage all Subscription Plan of the Common Data" : "Tạo và quản lý tất cả Gói đăng ký của Dữ liệu chung";
        SubscriptionPlanForm form = new SubscriptionPlanForm();
        new SubscriptionPlanPresenter(form);
        OpenChildForm(form);
      };
      tabMember.Click += delegate (object sender, EventArgs e) {
        ActivateSubtab(sender);
        labelDetail.Text = englishFIeld.Checked == true ? "Create and manage all Members of CBM" : "Tạo và quản lý tất cả Thành viên của CBM";
        MemberForm form = new MemberForm();
        new MemberPresenter(form);
        OpenChildForm(form);
      };
      tabDealership.Click += delegate (object sender, EventArgs e) {
        ActivateSubtab(sender);
        labelDetail.Text = englishFIeld.Checked == true ? "Create and manage all Dealerships of CBM" : "Tạo và quản lý tất cả các Đại lý của CBM";
        DealershipForm form = new DealershipForm();
        new DealershipPresenter(form);
        OpenChildForm(form);
      };
    }

    //Drag Form
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    private void DragForm(object sender, MouseEventArgs e) {
      ReleaseCapture();
      SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    public void OpenChildForm(Form childForm, bool isHide = false) {
      //open only form
      if (currentChildForm != null) {
        if (!isHide) {
          currentChildForm.Close();
        }
        else {
          currentChildForm.Hide();
        }
      }
      currentChildForm = childForm;
      ComponentResourceManager resources = new ComponentResourceManager(childForm.GetType());
      applyResources(resources, childForm.Controls, englishFIeld.Checked == true ? "en" : "vi-VN");
      //End
      childForm.TopLevel = false;
      childForm.FormBorderStyle = FormBorderStyle.None;
      childForm.Dock = DockStyle.Fill;
      panelForm.Controls.Add(childForm);
      panelForm.Tag = childForm;
      childForm.BringToFront();
      childForm.Show();
    }

    private void CloseForm(object sender, EventArgs e) {
      this.Close();
      loginView.Show();
    }
    private void RestoreForm(object sender, EventArgs e) {
      if (WindowState == FormWindowState.Normal) {
        WindowState = FormWindowState.Maximized;
      }
      else {
        WindowState = FormWindowState.Normal;
      }
    }
    private void MinimizeForm(object sender, EventArgs e) {
      WindowState = FormWindowState.Minimized;
    }

    #endregion

    #region Variables

    private LoginView loginView;
    private IconButton currentTab;
    private CBMButton currentSubTab;
    public Form currentChildForm;

    #endregion
  }
}
