using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBM.Utilities {
  public class ModelValidation {

    public static void Validate(object model) {
      string errorMessage = "";
      List<ValidationResult> results = new List<ValidationResult>();
      ValidationContext validationContext = new ValidationContext(model);
      bool isValid = Validator.TryValidateObject(model, validationContext, results, true);
      if (!isValid) {
        foreach (ValidationResult result in results) {
          errorMessage += $"- {result.ErrorMessage}\n";
        }
        throw new Exception(errorMessage);
      }
    }

  }
}
