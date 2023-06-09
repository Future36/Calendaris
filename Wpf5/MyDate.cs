using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarProgram
{
    internal class MyDate
    {
        public static string SetDays(string date, int day)
        {
            string[] dateSplit = SplitDate(date);
            dateSplit[0] = (day >= 10) ? day.ToString() : $"0{day}";
            return UnsplitDate(dateSplit);
        }

        public static string UnsplitDate(string[] dateSplit)
        {
            string date = string.Join(".", dateSplit);
            return date;
        }

        public static string[] SplitDate(string date)
        {
            string[] DMY = date.Split(".");
            for (int i = 0; i < 3; i++)
            {
                if (DMY[i][0] == '0')
                {
                    DMY[i] = DMY[i][1].ToString();
                }
            }
            return DMY;
        }

        public static string NextDate(string date)
        {
            string[] dateSplit = SplitDate(date);
            dateSplit[1] = (Convert.ToInt32(dateSplit[1]) + 1).ToString();
            if (Convert.ToInt32(dateSplit[1]) > 12)
            {
                dateSplit[1] = "1";
                dateSplit[2] = (Convert.ToInt32(dateSplit[2]) + 1).ToString();
            }
            return UnsplitDate(dateSplit);
        }

        public static string BackDate(string date)
        {
            string[] dateSplit = SplitDate(date);
            dateSplit[1] = (Convert.ToInt32(dateSplit[1]) - 1).ToString();
            if (Convert.ToInt32(dateSplit[1]) < 1)
            {
                dateSplit[1] = "12";
                dateSplit[2] = (Convert.ToInt32(dateSplit[2]) - 1).ToString();
            }
            return UnsplitDate(dateSplit);
        }
    }

}
