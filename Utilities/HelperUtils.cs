using CBM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Windows.Forms;

namespace CBM.Utilities {
  public class HelperUtils {

    public static string ConvertSnakeCaseToCamelCase(string snakeCaseString) {
      string[] words = snakeCaseString.Split('_');
      if (words.Length == 1) {
        return snakeCaseString;
      }
      string camelCaseString = words[0];
      for(int i=1; i<words.Length; i++) {
        camelCaseString += words[i][0].ToString().ToUpper() + words[i].Substring(1);
      }
      return camelCaseString;
    }

    public static string GetTableName(Type type) {
      var tableAttribute = type.GetCustomAttribute<TableAttribute>();
      if (tableAttribute != null) {
        return tableAttribute.Name;
      }
      throw new KeyNotFoundException();
    }

    static bool IsUsedProperty(string propertyName) {
      if (propertyName.Equals("Item") || propertyName.Equals("id") || propertyName.Equals("createdTime")) {
        return false;
      }
      return true;
    }

    static bool IsColumnProperty(PropertyInfo propertyInfo) {
      ColumnAttribute columnAttribute = propertyInfo.GetCustomAttribute<ColumnAttribute>();
      return columnAttribute == null ? false : true;
    }

    public static PropertyInfo[] GetPublicPropertyInfos(Type type) {
      PropertyInfo[] propertyInfos = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
      //return propertyInfos.Where(e => IsUsedProperty(e.Name)).ToArray();
      return propertyInfos.ToArray();
    }

    public static PropertyInfo GetPropertyByDisplayName<T>(string displayedName) {
      PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

      foreach (PropertyInfo property in properties) {
        DisplayNameAttribute displayAttribute = property.GetCustomAttribute<DisplayNameAttribute>();

        if (displayAttribute != null && displayAttribute.DisplayName == displayedName) {
          return property;
        }
      }
      return null;
    }

    public static string GetColumnName(PropertyInfo property) {
      if (property == null) {
        return null;
      }
      ColumnAttribute columnAttribute = property.GetCustomAttribute<ColumnAttribute>();
      return columnAttribute != null ? columnAttribute.Name : null;
    }

    public static void MapModelToInsertCommand(BaseModel model, SqlCommand command) {
      string sqlQuery = command.CommandText;
      // INSERT INTO admin (id, name, age) VALUES (@name, @age)
      //                    columns             values
      string columns = "(id, created_time, ";
      string values = "(@id, @created_time, ";

      PropertyInfo[] propertyInfos = GetPublicPropertyInfos(model.GetType());
      foreach (PropertyInfo propertyInfo in propertyInfos) {
        ColumnAttribute column = propertyInfo.GetCustomAttribute<ColumnAttribute>();
        if (column != null) {
          string name = column.Name;
          //object value = model[propertyInfo.Name];
          object value = model.GetValue(propertyInfo.Name);
          columns += $"{name}, ";
          values += $"@{name}, ";
          if (propertyInfo.PropertyType == typeof(byte[])) {
            // To fix bug with null value for image datatype
            SqlParameter imageParameter = new SqlParameter($"@{name}", SqlDbType.Image);
            imageParameter.Value = value == null ? DBNull.Value : value;
            command.Parameters.Add(imageParameter);
          } else {
            command.Parameters.AddWithValue($"@{name}", value == null ? DBNull.Value : value);
          }
        }
      }
      // At this stage, the tail of columns and values is having 2 unused characters left
      columns = $"{columns.Remove(columns.Length - 2)})";
      values = $"{values.Remove(values.Length - 2)})";
      command.CommandText = $@"{sqlQuery} {columns} VALUES {values}";
    }

    public static void MapModelToUpdateCommand(BaseModel model, SqlCommand command) {
      string sqlQuery = command.CommandText;
      bool isEmptyModel = true;
      PropertyInfo[] propertyInfos = GetPublicPropertyInfos(model.GetType());
      foreach (PropertyInfo propertyInfo in propertyInfos) {
        ColumnAttribute column = propertyInfo.GetCustomAttribute<ColumnAttribute>();
        if (column != null) {
          string name = column.Name;
          if (name == "member_id") continue; // Magic to fix bug
          //object value = model[propertyInfo.Name];
          object value = model.GetValue(propertyInfo.Name);
          if (value != null) {
            sqlQuery += $"{name} = @{name}, ";
            command.Parameters.AddWithValue($"@{name}", value);
            isEmptyModel = false;
          }
        }
      }
      // Generate an empty query if there is an empty model
      command.CommandText = isEmptyModel ? "" : $@"{sqlQuery.Remove(sqlQuery.Length - 2)} ";
    }

    public static ImageFormat GetImageFormat(string filename) {
      string[] parts = filename.Split('.');
      string fileExtention = parts[parts.Length - 1];
      switch (fileExtention) {
        case "jpg":
          return ImageFormat.Jpeg;
        case "jpeg":
          return ImageFormat.Jpeg;
        case "png":
          return ImageFormat.Png;
        case "gif":
          return ImageFormat.Gif;
        default:
        return null;
      }
    }
  }
}
