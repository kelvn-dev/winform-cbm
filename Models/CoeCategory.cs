using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace CBM.Models {
  [Table("coe_category")]
  public class CoeCategory : BaseModel {

    public CoeCategory() : base() { }

    public CoeCategory(string name, string description, int engineCapacity, int maxPowerOutput, float price, int periodYear) : base() {
      _name = name;
      _description = description;
      _engineCapacity = engineCapacity;
      _maxPowerOutput = maxPowerOutput;
      _price = price;
      _periodYear = periodYear;
    }

    private string _name;
    private string _description;
    private int _engineCapacity;
    private int _maxPowerOutput;
    private float _price;
    private int _periodYear;

    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter cname")]
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
    [Required(ErrorMessage = "Please enter engine capacity")]
    [DisplayName("Engine Capacity (CC)")]
    [Column("engine_capacity")]
    public int engineCapacity {
      get => _engineCapacity;
      set => _engineCapacity = value;
    }
    [Required(ErrorMessage = "Please enter maximum power output")]
    [DisplayName("Maximum Power Output (KW)")]
    [Column("max_power_output")]
    public int maxPowerOutput {
      get => _maxPowerOutput;
      set => _maxPowerOutput = value;
    }
    [Required(ErrorMessage = "Please enter price")]
    [DisplayName("Price ($)")]
    [Column("price")]
    public float price {
      get => _price;
      set => _price = value;
    }
    [Required(ErrorMessage = "Please enter period year")]
    [DisplayName("Period Year")]
    [Column("period_year")]
    public int periodYear {
      get => _periodYear;
      set => _periodYear = value;
    }
  }
}
