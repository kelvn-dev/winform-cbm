using CBM.Models;
using CBM.Services;
using CBM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CBM.Presenters {
  public class MarketplaceSignupPresenter {

    private MarketplaceSignupView view;

    public MarketplaceSignupPresenter(MarketplaceSignupView view) {
      this.view = view;
      this.view.SignupEvent += Signup;
    }

    private void Signup(object sender, EventArgs e) {
      try {
        Signup signup = new Signup {
          username = view.username,
          email = view.email,
          password = view.password,
          phone = view.phone
        };

        MemberService.Signup(signup);
        view.isSuccessful = true;
        view.message = "Signup successfully";
      }
      catch (Exception exception) {
        view.isSuccessful = false;
        view.message = exception.Message;
      }
    }

  }
}
