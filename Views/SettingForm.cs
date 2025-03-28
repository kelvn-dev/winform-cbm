using CBM.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBM.Views {
  public partial class SettingForm : Form {

    #region Css

    private void CssLabel() {
      UserControlUtils.CssInformationLabel(informationLabel);
      UserControlUtils.CssFieldLabel(renewalLabel);
    }

    #endregion

    public SettingForm() {
      InitializeComponent();
      CssLabel();
      AssociateEvents();
    }

    #region Events

    private void AssociateEvents() {
      renewalField.CheckedChanged += delegate {
        Console.WriteLine("COMEEEE");
        System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-FR");
        ComponentResourceManager resources = new ComponentResourceManager(this.GetType());
        resources.ApplyResources(this, "$this");
        applyResources(resources, this.Controls);
      };
    }

    private void applyResources(ComponentResourceManager resources, Control.ControlCollection ctls) {
      foreach (Control ctl in ctls) {
        resources.ApplyResources(ctl, ctl.Name, new System.Globalization.CultureInfo("fr-FR"));
        applyResources(resources, ctl.Controls);
      }
    }


    #endregion
  }
}
