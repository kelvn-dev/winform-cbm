using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CBM.Models {
  [Table("dealership")]
  public class Dealership : BaseModel {

    public Dealership() : base() { }

    public Dealership(DateTime startDate, DateTime endDate, bool isRenewal, string name, string uen, string description, string websiteUrl, string facebookUrl, string whatsappUrl, string instagramUrl, string youtubeUrl, string status, string phone, string address, string zipcode) : base() {
      _startDate = startDate;
      _endDate = endDate;
      _isRenewal = isRenewal;
      _status = status;
    }

    private DateTime _startDate;
    private DateTime _endDate;
    private bool _isRenewal;
    private Guid _memberId;
    private Guid _subscriptionPlanId;
    private string _memberName;
    private string _subscriptionPlanName;
    private string _status;


    [DisplayName("Subscription Plan")]
    public string subscriptionPlanName {
      get => _subscriptionPlanName;
      set => _subscriptionPlanName = value;
    }
    [DisplayName("Member")]
    public string memberName {
      get => _memberName;
      set => _memberName = value;
    }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter start date")]
    [DisplayName("Start Date")]
    [Column("start_date")]
    public DateTime startDate {
      get => _startDate;
      set => _startDate = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter end date")]
    [DisplayName("End Date")]
    [Column("end_date")]
    public DateTime endDate {
      get => _endDate;
      set => _endDate = value;
    }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter this value")]
    [DisplayName("Renewal")]
    [Column("is_renewal")]
    public bool isRenewal {
      get => _isRenewal;
      set => _isRenewal = value;
    }

    // Foreign keys
    [Column("member_id")]
    public Guid memberId {
      get => _memberId;
      set => _memberId = value;
    }
    [Column("subscription_plan_id")]
    public Guid subscriptionPlanId {
      get => _subscriptionPlanId;
      set => _subscriptionPlanId = value;
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
