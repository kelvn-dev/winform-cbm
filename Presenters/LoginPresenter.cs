using CBM.Models;
using CBM.Services;
using CBM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBM.Presenters {
  public class LoginPresenter {

    private LoginView view;

    public LoginPresenter(LoginView view) {
      this.view = view;
      this.view.LoginEvent += Login;
    }

    private void Login(object sender, EventArgs e) {
      Administrator administrator = AdminService.Login(view.email.Trim(), view.password.Trim());
      if (administrator == null) {
        view.isSuccessful = false;
      }
      else {
        view.isSuccessful = true;
        view.administrator = administrator;
      }
    }

  }
}
