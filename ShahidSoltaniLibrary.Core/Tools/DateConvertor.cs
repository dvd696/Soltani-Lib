using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ShahidSoltaniLibrary.Core.Tools
{
    public static class DateConvertor
    {
        public static string ToShamsi(this DateTime date)
        {
            PersianCalendar persian = new PersianCalendar();
            string ShamsiDate = 
                persian.GetYear(date).ToString("00")+"/"+
                persian.GetMonth(date).ToString("00")+"/"+
                persian.GetDayOfMonth(date).ToString("00");
            return ShamsiDate;
        }
    }
}
