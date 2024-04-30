using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyLinesLibrary
{
    public class Validations
    {
        public static bool CheckNumber(string enter)
        {
            if (string.IsNullOrEmpty(enter))
                return false;

            foreach (char c in enter)
            {
                if (!char.IsDigit(c) && c != '.')
                    return false;
            }

            return true;
        }
        public static bool CheckValidDate(string date)
        {
            string dateFormat = "dd-MM-yyyy";
            if (DateTime.TryParseExact(date, dateFormat, null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckValidTime(string time)
        {
            string timeFormat = "hh:mm tt";
            if (DateTime.TryParseExact(time, timeFormat, null, System.Globalization.DateTimeStyles.None, out DateTime parsedTime))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckInteger(string enter)
        {
            if (string.IsNullOrEmpty(enter))
                return false;

            foreach (char c in enter)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }
        public static bool CheckCommaColon(string enter)
        {
            for (int i = 0; i < enter.Length; i++)
            {
                if (enter[i] == ',' || enter[i] == ';')
                    return false;
            }
            return true;
        }
        public static bool CheckSemicolon(string enter)
        {
            for (int i = 0; i < enter.Length; i++)
            {
                if (enter[i] == ';')
                    return false;
            }
            return true;
        }
    }
}

