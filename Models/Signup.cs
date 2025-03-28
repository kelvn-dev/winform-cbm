using System.ComponentModel.DataAnnotations;

namespace CBM.Models {
  public class Signup : User {

    public Signup() : base() { }

    public Signup(string username, string email, string phone, string password) : base() {
      _username = username;
      _email = email;
      _phone = phone;
      _password = password;
    }

    private string _username;
    private string _phone;

    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Username")]
    public string username {
      get => _username;
      set => _username = value;
    }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Phone Number")]
    [RegularExpression(@"(((\+|)84)|0)(3|5|7|8|9)+([0-9]{8})\b", ErrorMessage = "Invalid phone number")]
    public string phone {
      get => _phone;
      set => _phone = value;
    }
  }
}
