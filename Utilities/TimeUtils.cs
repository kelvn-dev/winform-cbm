using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBM.Utilities {
  public class TimeUtils {

    public static DateTime GetCurrentTime() {
      return DateTime.Now;
    }

    public static string GetCurrentFormattedTime() {
      return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            //return DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        }

  }
}
