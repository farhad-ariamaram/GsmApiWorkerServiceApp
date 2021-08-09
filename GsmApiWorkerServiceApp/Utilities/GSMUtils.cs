using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmApiApp.Utilities
{
    public static class GSMUtils
    {
        public static string Translate(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < str.Length; j += 4)
            {
                sb.AppendFormat("\\u{0:x4}", str.Substring(j, 4));
            }
            string result = System.Text.RegularExpressions.Regex.Unescape(sb.ToString()).Replace("\"", string.Empty);
            return result;
        }

        public static string StringToHex(string hexstring)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char t in hexstring)
            {
                if (Convert.ToInt32(t).ToString("X").Length == 1)
                    sb.Append("000" + Convert.ToInt32(t).ToString("X"));
                if (Convert.ToInt32(t).ToString("X").Length == 2)
                    sb.Append("00" + Convert.ToInt32(t).ToString("X"));
                if (Convert.ToInt32(t).ToString("X").Length == 3)
                    sb.Append("0" + Convert.ToInt32(t).ToString("X"));
            }
            return sb.ToString();
        }
    }
}
