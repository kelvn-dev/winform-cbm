using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace CBM.Models {
  [Table("vehicle_model")]
  public class VehicleModel : BaseModel {

    public VehicleModel() : base() { }

    public VehicleModel(string name, string modelYear, Guid brandId, Guid vehicleTypeId) : base() {
      _name = name;
      _modelYear = modelYear;
      _brandId = brandId;
      _vehicleTypeId = vehicleTypeId;
    }

    private string _brandName;
    private string _vehicleTypeName;
    private string _name;
    private string _modelYear;
    private Guid _brandId;
    private Guid _vehicleTypeId;

    [DisplayName("Brand")]
    public string brandName {
      get => _brandName;
      set => _brandName = value;
    }
    [DisplayName("Type")]
    public string vehicleTypeName {
      get => _vehicleTypeName;
      set => _vehicleTypeName = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter name")]
    [DisplayName("Model")]
    [Column("name")]
    public string name {
      get => _name;
      set => _name = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter model year")]
    [RegularExpression("^\\d{4}$", ErrorMessage = "Invalid year")]
    [DisplayName("Model Year")]
    [Column("model_year")]
    public string modelYear {
      get => _modelYear;
      set => _modelYear = value;
    }
    [Column("brand_id")]
    public Guid brandId {
      get => _brandId;
      set => _brandId = value;
    }
    [Column("vehicle_type_id")]
    public Guid vehicleTypeId {
      get => _vehicleTypeId;
      set => _vehicleTypeId = value;
    }
  }
}
