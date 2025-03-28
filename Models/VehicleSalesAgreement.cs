using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace CBM.Models {
  [Table("vehicle_sales_agreement")]
  public class VehicleSalesAgreement : BaseModel {

    public VehicleSalesAgreement() : base() { }

    public VehicleSalesAgreement(string remark, DateTime signDate, string status) : base() {
      _remark = remark;
      _signDate = signDate;
      _status = status;
    }

    private string _remark;
    private DateTime _signDate;
    private string _status;

    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter remark")]
    [DisplayName("Remark")]
    [Column("remark")]
    public string remark {
      get => _remark;
      set => _remark = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter sign date")]
    [DisplayName("Sign Date")]
    [Column("sign_date")]
    public DateTime signDate {
      get => _signDate;
      set => _signDate = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter status")]
    [DisplayName("Status")]
    [Column("status")]
    public string status {
      get => _status;
      set => _status = value;
    }
  }
}
