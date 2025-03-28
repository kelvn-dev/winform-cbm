using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace CBM.Models {
  [Table("group")]
  public class Group : BaseModel {

    public Group() : base() { }

    public Group(string name, string description) : base() {
      _name = name;
      _description = description;
    }

    private string _name;
    private string _description;


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
