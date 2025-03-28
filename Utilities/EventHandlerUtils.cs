using CBM.Customs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBM.Utilities {
  public class EventHandlerUtils {

    public static void AllowInteger_KeyPress(object sender, KeyPressEventArgs e) {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
        e.Handled = true;
      }
    }

    public static void AllowFloat_KeyPress(object sender, KeyPressEventArgs e) {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
        e.Handled = true;
      }

      // only allow one decimal point
      if ((e.KeyChar == '.') && ((sender as CBMTextbox).Texts.IndexOf('.') > -1)) {
        e.Handled = true;
      }
    }
  }
}
