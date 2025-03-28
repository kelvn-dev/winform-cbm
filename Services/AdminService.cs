using CBM.Models;
using CBM.Utilities;
using System.Collections.Generic;
using System;
using BCrypt.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace CBM.Services {
  public class AdminService : BaseService<Administrator> {

    public static Administrator GetByEmail(string email, bool isRequired = true) {
      Administrator administrator = new Administrator();
      bool isFound = false;
      string sqlQuery = $"SELECT * FROM [{tableName}] WHERE email = @email";
      Console.WriteLine($"Detail query: {sqlQuery}");
      using (var connection = ConnectionFactory.Create()) {
        var command = connection.CreateCommand();
        command.CommandText = sqlQuery;
        command.Parameters.AddWithValue("@email", email);
        var reader = command.ExecuteReader();
        while (reader.Read()) {
          for (int i = 0; i < reader.FieldCount; i++) {
            //model[reader.GetName(i)] = reader.GetValue(i);
            administrator.SetValue(HelperUtils.ConvertSnakeCaseToCamelCase(reader.GetName(i)), reader.GetValue(i));
          }
          isFound = true;
          break;
        }
      }
      if (isRequired && !isFound) {
        throw new KeyNotFoundException();
      }
      return isFound ? administrator : null;
    }

    public static void Create(Administrator administrator) {
      administrator.password = BCrypt.Net.BCrypt.HashPassword(administrator.password);
      BaseService<Administrator>.Create(administrator);
    }

    public static void Update(Administrator administrator) {
      if (!string.IsNullOrEmpty(administrator.password)) {
        administrator.password = BCrypt.Net.BCrypt.HashPassword(administrator.password);
      }
      BaseService<Administrator>.Update(administrator);
    }

    public static Administrator Login(string email, string password) {
      Administrator administrator = GetByEmail(email, false);
      if (administrator == null) {
        return null;
      }
      if (BCrypt.Net.BCrypt.Verify(password, administrator.password)) {
        return administrator;
      }
      return null;
    }

    public static void ResetPassword(Administrator administrator, string oldPassword, string password) {
      if (BCrypt.Net.BCrypt.Verify(oldPassword, administrator.password)) {
        using (var connection = ConnectionFactory.Create()) {
          var command = connection.CreateCommand();
          command.CommandText = "Update [administrator] SET password = @password WHERE id = @id";
          command.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.HashPassword(password));
          command.Parameters.AddWithValue("@id", administrator.id);
          try {
            int result = command.ExecuteNonQuery();
            if (result < 1) {
              throw new Exception();
            }
          }
          catch (SqlException ex) {
            throw new Exception(ex.Message);
          }
        }
      }
      else {
        throw new Exception("Wrong old password");
      }
    }
  }
}
