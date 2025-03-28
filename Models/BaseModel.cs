using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using CBM.Utilities;

namespace CBM.Models {
  public class BaseModel: IDataErrorInfo {

    public BaseModel() {
      id = Guid.NewGuid();
    }

    [Browsable(false)]
    public string this[string property] {
      get {
        var propertyDescriptor = TypeDescriptor.GetProperties(this)[property];
        if (propertyDescriptor == null)
          return string.Empty;

        var results = new List<ValidationResult>();
        var result = Validator.TryValidateProperty(
                                  propertyDescriptor.GetValue(this),
                                  new ValidationContext(this, null, null) { MemberName = property },
                                  results);
        if (!result)
          return results.First().ErrorMessage;
        return string.Empty;
      }
      //set {
      //  value = value == string.Empty || (object) value == DBNull.Value ? null : value;
      //  this.GetType().GetProperty(property).SetValue(this, value, null);
      //}
    }

    [Browsable(false)]
    public string Error {
      get {
        var results = new List<ValidationResult>();
        var result = Validator.TryValidateObject(this,
            new ValidationContext(this, null, null), results, true);
        if (!result)
          return string.Join("\n", results.Select(x => x.ErrorMessage));
        else
          return null;
      }
    }
    [Browsable(false)]
    public bool IsValid => string.IsNullOrEmpty(Error);

    //public object this[string propertyName] {
    //  get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
    //  set {
    //    value = value == DBNull.Value ? null : value;
    //    this.GetType().GetProperty(propertyName).SetValue(this, value, null);
    //  }
    //}
    public object GetValue(string propertyName) {
      return this.GetType().GetProperty(propertyName).GetValue(this, null);
    }
    public void SetValue(string propertyName, object value) {
      value = value == DBNull.Value ? null : value;
      PropertyInfo propertyInfo = this.GetType().GetProperty(propertyName);
      if (propertyInfo == null) return;
      if (propertyInfo.PropertyType == typeof(float)) {
        propertyInfo.SetValue(this, float.Parse(value.ToString()), null);
      }
      else {
        propertyInfo.SetValue(this, value, null);
      }
    }

    private Guid _id;
    private DateTime _created_time;

    public Guid id {
      get => _id;
      set => _id = value;
    }

    public DateTime? created_time {
      get => _created_time;
      set => _created_time = (DateTime) value;
    }
  }
}
