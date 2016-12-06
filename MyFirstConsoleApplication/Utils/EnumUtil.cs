using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication.Utils
{
   public static class EnumUtil
   {

      public static String GetAllValuesAsString<TEnum>()
          where TEnum : struct, IConvertible, IComparable, IFormattable
      {

         var values = Enum.GetValues(typeof(TEnum)).Cast<TEnum>();
         String enumValues = "";
         foreach(TEnum value in values)
         {
            enumValues = enumValues == string.Empty ?  enumValues + value : enumValues + ", " + value;
         }
         return enumValues;
      }
   }
}
