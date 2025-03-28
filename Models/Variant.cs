using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace CBM.Models {
  [Table("variant")]
  public class Variant : BaseModel {

    public Variant() : base() { }

    public Variant(
      string variantYear,
      string description,
      string name,
      string engineType,
      string batteryType,
      string driveType,
      bool autoHeadlight,
      bool navigationSystem,
      bool bluetoothInterface,
      bool smartKey,
      Guid vehicleModelId,
      Guid fuelTypeId
     ) : base() {
      _variantYear = variantYear;
      _description = description;
      _name = name;
      _engineType = engineType;
      _batteryType = batteryType;
      _driveType = driveType;
      _autoHeadlight = autoHeadlight;
      _navigationSystem = navigationSystem;
      _bluetoothInterface = bluetoothInterface;
      _smartKey = smartKey;
      _vehicleModelId = vehicleModelId;
      _fuelTypeId = fuelTypeId;
    }

    private string _brandName;
    private string _vehicleModelName;
    private string _fuelTypeName;
    private string _variantYear;
    private string _description;
    private string _name;
    private string _engineType;
    private string _batteryType;
    private string _driveType;
    private bool _autoHeadlight;
    private bool _navigationSystem;
    private bool _bluetoothInterface;
    private bool _smartKey;
    private Guid _vehicleModelId;
    private Guid _fuelTypeId;

    [DisplayName("Brand")]
    public string brandName {
      get => _brandName;
      set => _brandName = value;
    }
    [DisplayName("Model")]
    public string vehicleModelName {
      get => _vehicleModelName;
      set => _vehicleModelName = value;
    }
    [DisplayName("Fuel type")]
    public string fuelTypeName {
      get => _fuelTypeName;
      set => _fuelTypeName = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter name")]
    [DisplayName("Variant")]
    [Column("name")]
    public string name {
      get => _name;
      set => _name = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter variant year")]
    [RegularExpression("^\\d{4}$", ErrorMessage = "Invalid year")]
    [DisplayName("Variant Year")]
    [Column("variant_year")]
    public string variantYear {
      get => _variantYear;
      set => _variantYear = value;
    }
    [DisplayName("Description")]
    [Column("description")]
    public string description {
      get => _description;
      set => _description = value;
    }
    [DisplayName("Engine Type")]
    [Column("engine_type")]
    public string engineType {
      get => _engineType;
      set => _engineType = value;
    }
    [DisplayName("Battery Type")]
    [Column("battery_type")]
    public string batteryType {
      get => _batteryType;
      set => _batteryType = value;
    }
    [DisplayName("Drive Type")]
    [Column("drive_type")]
    public string driveType {
      get => _driveType;
      set => _driveType = value;
    }
    [DisplayName("Auto Headlight")]
    [Column("auto_headlight")]
    public bool autoHeadlight {
      get => _autoHeadlight;
      set => _autoHeadlight = value;
    }
    [DisplayName("Navigation System")]
    [Column("navigation_system")]
    public bool navigationSystem {
      get => _navigationSystem;
      set => _navigationSystem = value;
    }
    [DisplayName("Bluetooth Interface")]
    [Column("bluetooth_interface")]
    public bool bluetoothInterface {
      get => _bluetoothInterface;
      set => _bluetoothInterface = value;
    }
    [DisplayName("Smart Key")]
    [Column("smart_key")]
    public bool smartKey {
      get => _smartKey;
      set => _smartKey = value;
    }

    // Foregin keys
    [Column("vehicle_model_id")]
    public Guid vehicleModelId {
      get => _vehicleModelId;
      set => _vehicleModelId = value;
    }
    [Column("fuel_type_id")]
    public Guid fuelTypeId {
      get => _fuelTypeId;
      set => _fuelTypeId = value;
    }
  }
}
