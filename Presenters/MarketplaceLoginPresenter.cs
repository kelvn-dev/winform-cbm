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
  public class MarketplaceLoginPresenter {

    private MarketplaceLoginView view;

    public MarketplaceLoginPresenter(MarketplaceLoginView view) {
      this.view = view;
      this.view.LoginEvent += Login;
    }

    private void Login(object sender, EventArgs e) {
      Member member = MemberService.Login(view.email, view.password);
      if (member == null) {
        view.isSuccessful = false;
      }
      else {
        view.isSuccessful = true;
        view.member = member;
      }
    }

  }
}
