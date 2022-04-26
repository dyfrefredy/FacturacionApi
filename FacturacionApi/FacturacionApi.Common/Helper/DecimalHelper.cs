using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FacturacionApi.Common.Helper
{
    public static class DecimalHelper
    {
        public static string GetDdecimal(this string decimalNumber)
        {
            string decimalResult = decimalNumber.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberGroupSeparator).Replace(",", CultureInfo.CurrentUICulture.NumberFormat.NumberGroupSeparator);
            return decimalResult;
        }
    }
}
