using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBM.Models {
  public class ResetPassword: BaseModel {

    public ResetPassword(): base() { }
    public ResetPassword(string oldPassword, string password) {
      _oldPassword = oldPassword;
      _password = password;
    }

    private string _oldPassword;
    private string _password;

    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter old password")]
    public string oldPassword {
      get => _oldPassword; 
      set => _oldPassword = value;
    }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter new password")]
    public string password {
      get => _password;
      set => _password = value;
    }
  }
}
