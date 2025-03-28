using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBM.Utilities {
  public class EntityValidator: IDataErrorInfo {

    public string this[string property] {
      get {
        var propertyDescriptor = TypeDescriptor.GetProperties(this)[property];
        if (propertyDescriptor == null) {
          return string.Empty;
        }
        var results = new List<ValidationResult>();
        var result = Validator.TryValidateProperty(
            propertyDescriptor.GetValue(this),
            new ValidationContext(this, null, null) { MemberName = property},
            results
          );
        return !result ? results.First().ErrorMessage : string.Empty;
      }
    }

    public string Error {
      get { 
        var results = new List<ValidationResult>();
        var result = Validator.TryValidateObject(this, new ValidationContext(this, null, null), results, true);
        return !result ? string.Join(Environment.NewLine, results.Select(x => x.ErrorMessage)) : null;
      }
    }

    public bool IsValid => string.IsNullOrEmpty(Error);
  }
}
