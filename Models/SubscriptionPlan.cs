using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CBM.Models {
  [Table("subscription_plan")]
  public class SubscriptionPlan : BaseModel {

    public SubscriptionPlan() : base() { }

    public SubscriptionPlan(string name, float yearlyPrice, float monthlyPrice, int vehicleLimit, string description) : base() {
      _name = name;
      _yearlyPrice = yearlyPrice;
      _monthlyPrice = monthlyPrice;
      _vehicleLimit = vehicleLimit;
      _description = description;
    }

    private string _name;
    private float _yearlyPrice;
    private float _monthlyPrice;
    private int _vehicleLimit;
    private string _description;

    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter name")]
    [DisplayName("Name")]
    [Column("name")]
    public string name {
      get => _name;
      set => _name = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter yearly price")]
    [DisplayName("Annual Price ($)")]
    [Column("yearly_price")]
    public float yearlyPrice {
      get => _yearlyPrice;
      set => _yearlyPrice = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter monthly price")]
    [DisplayName("Monthly Price ($)")]
    [Column("monthly_price")]
    public float monthlyPrice {
      get => _monthlyPrice;
      set => _monthlyPrice = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter vehicle limit")]
    [DisplayName("Vehicle Limit")]
    [Column("vehicle_limit")]
    public int vehicleLimit {
      get => _vehicleLimit;
      set => _vehicleLimit = value;
    }
    [DisplayName("Description")]
    [Column("description")]
    public string description {
      get => _description;
      set => _description = value;
    }
  }
}
