using CBM.Models;
using CBM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBM.Services {
  public class DealershipService : BaseService<Dealership> {

    public static Dealership GetByMemberId(Guid memberId, bool isRequired = true) {
      Dealership dealership = new Dealership();
      bool isFound = false;
      string sqlQuery = $"SELECT * FROM [{tableName}] WHERE member_id = @member_id";
      Console.WriteLine($"Detail query: {sqlQuery}");
      using (var connection = ConnectionFactory.Create()) {
        var command = connection.CreateCommand();
        command.CommandText = sqlQuery;
        command.Parameters.AddWithValue("@member_id", memberId);
        var reader = command.ExecuteReader();
        while (reader.Read()) {
          for (int i = 0; i < reader.FieldCount; i++) {
            //model[reader.GetName(i)] = reader.GetValue(i);
            dealership.SetValue(HelperUtils.ConvertSnakeCaseToCamelCase(reader.GetName(i)), reader.GetValue(i));
          }
          isFound = true;
          break;
        }
      }
      if (isRequired && !isFound) {
        throw new KeyNotFoundException();
      }
      return isFound ? dealership : null;
    }

  }
}
