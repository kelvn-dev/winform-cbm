using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CBM.Models {
  [Table("vehicle")]
  public class Vehicle : BaseModel {

    public Vehicle() : base() { }

    public Vehicle(string title, string description, string status, float price, string plateNo, string manufacturingYear, float mileage, Guid variantId, Guid memberId) : base() {
      _title = title;
      _description = description;
      _status = status;
      _price = price;
      _plateNo = plateNo;
      _manufacturingYear = manufacturingYear;
      _mileage = mileage;
      _variantId = variantId;
      _memberId = memberId;
    }

    private string _title;
    private string _description;
    private string _status;
    private float _price;
    private string _plateNo;
    private string _manufacturingYear;
    private float _mileage;
    private Guid _variantId;
    private Guid _memberId;
    private Guid _buyerId;

    [DisplayName("Title")]
    [Column("title")]
    public string title {
      get => _title;
      set => _title = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter plate number")]
    [DisplayName("Plate No")]
    [Column("plate_no")]
    public string plateNo {
      get => _plateNo;
      set => _plateNo = value;
    }
    [RegularExpression("^\\d{4}$", ErrorMessage = "Invalid year")]
    [DisplayName("Manufacturing Year")]
    [Column("manufacturing_year")]
    public string manufacturingYear {
      get => _manufacturingYear;
      set => _manufacturingYear = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter mileage")]
    [DisplayName("Mileage (Km)")]
    [Column("mileage")]
    public float mileage {
      get => _mileage;
      set => _mileage = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter price")]
    [DisplayName("Price ($)")]
    [Column("price")]
    public float price {
      get => _price;
      set => _price = value;
    }
    [DisplayName("Description")]
    [Column("description")]
    public string description {
      get => _description;
      set => _description = value;
    }
    [DisplayName("Status")]
    [Column("status")]
    public string status {
      get => _status;
      set => _status = value;
    }

    // Foregin keys
    [Column("variant_id")]
    public Guid variantId {
      get => _variantId;
      set => _variantId = value;
    }
    [Column("member_id")]
    public Guid memberId {
      get => _memberId;
      set => _memberId = value;
    }
    [Column("buyer_id")]
    public Guid buyerId {
      get => _buyerId;
      set => _buyerId = value;
    }
  }
}
