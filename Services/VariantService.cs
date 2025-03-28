using CBM.Models;
using CBM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBM.Services {
  public class VariantService : BaseService<Variant> {

    public static List<KeyValuePair<Guid, string>> GetComboBoxDataByVehicleModelId(string displayedColumn, Guid vehicleModelId) {
      string sqlQuery = $"SELECT id, {displayedColumn} FROM [{tableName}] WHERE vehicle_model_id = @vehicle_model_id";
      List<KeyValuePair<Guid, string>> data = new List<KeyValuePair<Guid, string>>();

      using (var connection = ConnectionFactory.Create()) {
        var command = connection.CreateCommand();
        command.CommandText = sqlQuery;
        command.Parameters.AddWithValue("@vehicle_model_id", vehicleModelId);
        var reader = command.ExecuteReader();
        while (reader.Read()) {
          Guid id = reader.GetGuid(0);
          string displayedValue = reader.GetString(1);
          data.Add(new KeyValuePair<Guid, string>(id, displayedValue));
        }
      }
      return data;
    }

  }
}
