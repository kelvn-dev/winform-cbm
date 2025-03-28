using CBM.Customs;
using CBM.Models;
using CBM.Presenters;
using CBM.Utilities;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CBM.Views {
  public partial class EntryView : Form {

    #region Css

    private void CssThis() {
      // Remove header
      this.Text = string.Empty;
      this.ControlBox = false;
      this.DoubleBuffered = true;
      this.BackColor = ColorTranslator.FromHtml(Constant.BG_COLOR);

      headerBar.BackColor = Color.White;
    }

    private void CssLabel() {
      instructionLabel.ForeColor = ColorTranslator.FromHtml("#595959");
      instructionLabel.Font = new Font(Constant.FONT_FAMILY, Constant.MEDIUM_FONT_SIZE, FontStyle.Regular);
    }

    private void CssBtn() {
      adminBtn.BackColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      adminBtn.ForeColor = ColorTranslator.FromHtml(Constant.WHITE_COLOR);
      adminBtn.BorderColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      adminBtn.BorderRadius = Constant.MIN_BORDER_RADIUS;
      adminBtn.BorderSize = Constant.MIN_BORDER_SIZE;
      adminBtn.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE);

      memberBtn.BackColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      memberBtn.ForeColor = ColorTranslator.FromHtml(Constant.WHITE_COLOR);
      memberBtn.BorderColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      memberBtn.BorderRadius = Constant.MIN_BORDER_RADIUS;
      memberBtn.BorderSize = Constant.MIN_BORDER_SIZE;
      memberBtn.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE);
    }

    #endregion

    public EntryView() {
      InitializeComponent();
      CssThis();
      CssLabel();
      CssBtn();

      UserControlUtils.CssIconButton(closeBtn, Color.White, ColorTranslator.FromHtml(Constant.RED_COLOR));
      UserControlUtils.CssIconButton(restoreBtn, Color.White, ColorTranslator.FromHtml(Constant.YELLO_COLOR));
      UserControlUtils.CssIconButton(minBtn, Color.White, ColorTranslator.FromHtml(Constant.GREEN_COLOR));

      AssociateEvents();
    }

    #region Common


    #endregion

    #region Events

    public event EventHandler LoginEvent;

    private void AssociateEvents() {
      closeBtn.Click += CloseForm;
      restoreBtn.Click += RestoreForm;
      minBtn.Click += MinimizeForm;

      adminBtn.Click += delegate {
        LoginView loginView = new LoginView();
        new LoginPresenter(loginView);
        loginView.Show();
      };

      memberBtn.Click += delegate {
        MarketplaceLoginView marketplaceLoginView = new MarketplaceLoginView();
        new MarketplaceLoginPresenter(marketplaceLoginView);
        marketplaceLoginView.Show();
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

    private void CloseForm(object sender, EventArgs e) {
      this.Close();
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
  }
}
