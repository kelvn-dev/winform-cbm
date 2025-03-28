using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace CBM.Models {
  [Table("administrator")]
  public class Administrator : BaseModel {

    public Administrator() : base() { }

    public Administrator(string username, string email, string phone, string address, string zipcode, byte[] avatar, string password) : base() {
      _username = username;
      _email = email;
      _phone = phone;
      _address = address;
      _zipcode = zipcode;
      _avatar = avatar;
      _password = password;
    }

    private string _username;
    private string _email;
    private string _phone;
    private string _address;
    private string _zipcode;
    private byte[] _avatar;
    private string _password;

    [DisplayName("Avatar")]
    [Column("avatar")]
    public byte[] avatar {
      get => _avatar;
      set => _avatar = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Username")]
    [DisplayName("Username")]
    [Column("username")]
    public string username {
      get => _username;
      set => _username = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Email")]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    [DisplayName("Email")]
    [Column("email")]
    public string email {
      get => _email;
      set => _email = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Phone Number")]
    [DisplayName("Phone Number")]
    [Column("phone")]
    public string phone {
      get => _phone;
      set => _phone = value;
    }
    [DisplayName("Address")]
    [Column("address")]
    public string address {
      get => _address;
      set => _address = value;
    }
    [DisplayName("Zip Code")]
    [Column("zipcode")]
    public string zipcode {
      get => _zipcode;
      set => _zipcode = value;
    }
    [Column("password")]
    public string password {
      get => _password;
      set => _password = value;
    }
  }
}
