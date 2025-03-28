using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CBM.Models {
  [Table("member")]
  public class Member : BaseModel {

    public Member() : base() { }

    public Member(string email, string password, string username, string address, string phone, string zipcode, byte[] avatar) : base() {
      _email = email;
      _password = password;
      _username = username;
      _address = address;
      _zipcode = zipcode;
      _avatar = avatar;
      _phone = phone;
    }

    private string _email;
    private string _password;
    private string _username;
    private string _phone;
    private string _address;
    private string _zipcode;
    private byte[] _avatar;
    private Guid _dealershipId;

    [DisplayName("Avatar")]
    [Column("avatar")]
    public byte[] avatar {
      get => _avatar;
      set => _avatar = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter email")]
    [DisplayName("Email")]
    [Column("email")]
    public string email {
      get => _email;
      set => _email = value;
    }
    [Column("password")]
    public string password {
      get => _password;
      set => _password = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter username")]
    [DisplayName("Username")]
    [Column("username")]
    public string username {
      get => _username;
      set => _username = value;
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
    [DisplayName("Zipcode")]
    [Column("zipcode")]
    public string zipcode {
      get => _zipcode;
      set => _zipcode = value;
    }

    [Column("dealership_id")]
    public Guid dealershipId {
      get => _dealershipId;
      set => _dealershipId = value;
    }
  }
}
