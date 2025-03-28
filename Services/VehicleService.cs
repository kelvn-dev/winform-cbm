using CBM.Models;
using CBM.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBM.Services {
  public class VehicleService : BaseService<Vehicle> {

    public static List<Vehicle> GetByMemberId(Guid memberId) {
      string sqlQuery = @$"SELECT * FROM [{tableName}] WHERE member_id = @member_id";
      Console.WriteLine($"Listing query: {sqlQuery}");
      List<Vehicle> modelList = new List<Vehicle>();
      using (var connection = ConnectionFactory.Create()) {
        var command = connection.CreateCommand();
        command.CommandText = sqlQuery;
        command.Parameters.AddWithValue("@member_id", memberId);
        var reader = command.ExecuteReader();
        while (reader.Read()) {
          Vehicle model = new Vehicle();
          for (int i = 0; i < reader.FieldCount; i++) {
            //model[reader.GetName(i)] = reader.GetValue(i);
            model.SetValue(HelperUtils.ConvertSnakeCaseToCamelCase(reader.GetName(i)), reader.GetValue(i));
          }
          modelList.Add(model);
        }
      }
      return modelList;
    }

    public static void MarkAsSold(Guid id, Guid buyerId) {
      string sqlQuery = @$"UPDATE [{tableName}] SET status = 'SOLD', buyer_id = @buyer_id WHERE id = @id";
      Console.WriteLine($"Update query: {sqlQuery}");
      using (var connection = ConnectionFactory.Create()) {
        try {
          var command = connection.CreateCommand();
          command.CommandText = sqlQuery;
          command.Parameters.AddWithValue("@id", id);
          command.Parameters.AddWithValue("@buyer_id", buyerId);
          int result = command.ExecuteNonQuery();
          if ( result < 1 ) {
            throw new Exception();
          }
        }
        catch (SqlException e){
          throw new Exception(e.Message);
        }
      }
    }

    public static int CountByMemberId(Guid memberId) {
      string sqlQuery = @$"SELECT COUNT(*) FROM [{tableName}] WHERE member_id = @member_id";
      Console.WriteLine($"Count query: {sqlQuery}");
      using (var connection = ConnectionFactory.Create()) {
        var command = connection.CreateCommand();
        command.CommandText = sqlQuery;
        command.Parameters.AddWithValue("@member_id", memberId);
        object result = command.ExecuteScalar();
        return Convert.ToInt32(result);
      }
    }

  }
}
