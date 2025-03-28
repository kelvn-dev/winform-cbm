using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace CBM.Models {
  [Table("vehicle_type")]
  public class VehicleType : BaseModel {

    public VehicleType() : base() { }

    public VehicleType(string name, string description, byte[] logo) : base() {
      _name = name;
      _description = description;
      _logo = logo;
    }

    private string _name;
    private string _description;
    private byte[] _logo;

    [DisplayName("Logo")]
    [Column("logo")]
    public byte[] logo {
      get => _logo;
      set => _logo = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter name")]
    [DisplayName("Name")]
    [Column("name")]
    public string name {
      get => _name;
      set => _name = value;
    }
    [DisplayName("Description")]
    [Column("description")]
    public string description {
      get => _description;
      set => _description = value;
    }
  }
}
