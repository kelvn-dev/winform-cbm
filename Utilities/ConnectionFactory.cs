using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CBM.Utilities {
  public class ConnectionFactory {
    public static SqlConnection Create() {
      string dbConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
      SqlConnection sqlConnection = new SqlConnection(dbConnectionString);
      sqlConnection.Open();
      return sqlConnection;
    }
  }
}
