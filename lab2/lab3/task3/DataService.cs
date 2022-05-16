using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class DataService
    {
        static int day = 0;
        static int month = 0;
        static int year = 0;
        public static bool IsInvalidDate(string date)
        {
            if (date.Length == 10)
            {
                day = Convert.ToInt32(date[0].ToString()) * 10 + Convert.ToInt32(date[1].ToString());
                month = Convert.ToInt32(date[3].ToString()) * 10 + Convert.ToInt32(date[4].ToString());
                year = Convert.ToInt32(date[6].ToString()) * 1000 + Convert.ToInt32(date[7].ToString()) * 100 + Convert.ToInt32(date[8].ToString()) * 10 + Convert.ToInt32(date[9].ToString());
                int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                if (month > 12 || month < 0)
                { 
                    return false;
                }
                int day1 = days[month];
                if (month == 2 && ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0))
                {
                    day1 += 1;
                }
                if ((year < 1) || (month < 0 || month > 12) || (day < 0 || day > day1))
                {
                    return false;
                }
                return true;
            }
            else return false;
        }
        public static string GetDay(string date)
        {
            if (IsInvalidDate(date))
            {
                DateTime dt = new DateTime(year, month, day);
                return ($"День недели: {dt.ToString("dddd")}");
            }
            else
            {
                return ("Дата введена некорректно");
            }
        }

        public static int GetDaysSpan(int day1, int month1, int year1)
        {
            int a1 = (14 - month) / 12;
            int y1 = year + 4800 - a1;
            int m1 = month + 12 * a1 - 3;
            int JDN1 = day + (int)((153 * m1 + 2) / 5) + 365 * y1 + (int)(y1 / 4) - (int)(y1 / 100) + (int)(y1 / 400) - 32045;

            int a2 = (14 - month1) / 12;
            int y2 = year1 + 4800 - a2;
            int m2 = month1 + 12 * a2 - 3;
            int JDN2 = day1 + (int)((153 * m2 + 2) / 5) + 365 * y2 + (int)(y2 / 4) - (int)(y2 / 100) + (int)(y2 / 400) - 32045;
            return Math.Abs(JDN2 - JDN1);
        }

    }
}
