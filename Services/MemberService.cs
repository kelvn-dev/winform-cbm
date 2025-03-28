using CBM.Models;
using CBM.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBM.Services {
  public class MemberService : BaseService<Member> {

    public static Member GetByEmail(string email, bool isRequired = true) {
      Member member = new Member();
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
            member.SetValue(HelperUtils.ConvertSnakeCaseToCamelCase(reader.GetName(i)), reader.GetValue(i));
          }
          isFound = true;
          break;
        }
      }
      if (isRequired && !isFound) {
        throw new KeyNotFoundException();
      }
      return isFound ? member : null;
    }

    public static void Create(Member member) {
      member.password = BCrypt.Net.BCrypt.HashPassword(member.password);
      BaseService<Member>.Create(member);
    }

    public static void Update(Member member) {
      if (!string.IsNullOrEmpty(member.password)) {
        member.password = BCrypt.Net.BCrypt.HashPassword(member.password);
      }
      BaseService<Member>.Update(member);
    }

    public static Member Login(string email, string password) {
      Member member = GetByEmail(email, false);
      if (member == null) {
        return null;
      }
      if (BCrypt.Net.BCrypt.Verify(password, member.password)) {
        return member;
      }
      return null;
    }

    public static void ResetPassword(Member member, string oldPassword, string password) {
      if (BCrypt.Net.BCrypt.Verify(oldPassword, member.password)) {
        using (var connection = ConnectionFactory.Create()) {
          var command = connection.CreateCommand();
          command.CommandText = "Update [member] SET password = @password WHERE id = @id";
          command.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.HashPassword(password));
          command.Parameters.AddWithValue("@id", member.id);
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

    public static void Signup(Signup signup) {
      Member member = GetByEmail(signup.email, false);
      if (member != null) {
        throw new Exception("Account with this email already exist");
      }
      
      string sql = $"INSERT INTO [{tableName}] (id, username, email, phone, password, created_time) VALUES (@id, @username, @email, @phone, @password, @created_time)";
      using (var connection = ConnectionFactory.Create()) {
        var command = connection.CreateCommand();
        command.CommandText = sql;
        command.Parameters.AddWithValue("@id", signup.id);
        command.Parameters.AddWithValue("@created_time", TimeUtils.GetCurrentFormattedTime());
        command.Parameters.AddWithValue("@username", signup.username);
        command.Parameters.AddWithValue("@email", signup.email);
        command.Parameters.AddWithValue("@phone", signup.phone);
        command.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.HashPassword(signup.password));
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
  }
}
