using System.ComponentModel.DataAnnotations;

namespace CBM.Models {
  public class User: BaseModel {

    public User(): base() {
    }

    public User(string email, string password) {
      _email = email;
      _password = password;
    }

    protected string _email;
    protected string _password;

    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Email")]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string email {
      get => _email;
      set => _email = value;
    }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Password")]
    [StringLength(maximumLength: 20, MinimumLength = 8, ErrorMessage = "Password must be 8 – 20 characters")]
    public string password {
      get => _password;
      set => _password = value;
    }
  }
}
