using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFHW1_3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*DateTime dateValue = new DateTime(2008, 6, 11);
            Console.WriteLine(dateValue.ToString("dddd"));*/
            string dateString = "6/11/2007";
            DateTime dateValue;
            DateTimeOffset dateOffsetValue;

            try
            {
                DateTimeFormatInfo dateTimeFormats;
                // Convert date representation to a date value
                dateValue = DateTime.Parse(dateString, CultureInfo.InvariantCulture);
                dateOffsetValue = new DateTimeOffset(dateValue,
                                             TimeZoneInfo.Local.GetUtcOffset(dateValue));

                // Convert date representation to a number indicating the day of week
                Console.WriteLine((int)dateValue.DayOfWeek);
                Console.WriteLine((int)dateOffsetValue.DayOfWeek);

                // Display abbreviated weekday name using current culture
                Console.WriteLine(dateValue.ToString("ddd"));
                Console.WriteLine(dateOffsetValue.ToString("ddd"));

                // Display full weekday name using current culture
                Console.WriteLine(dateValue.ToString("dddd"));
                Console.WriteLine(dateOffsetValue.ToString("dddd"));

                // Display abbreviated weekday name for de-DE culture
                Console.WriteLine(dateValue.ToString("ddd", new CultureInfo("de-DE")));
                Console.WriteLine(dateOffsetValue.ToString("ddd",
                                                            new CultureInfo("de-DE")));

                // Display abbreviated weekday name with de-DE DateTimeFormatInfo object
                dateTimeFormats = new CultureInfo("de-DE").DateTimeFormat;
                Console.WriteLine(dateValue.ToString("ddd", dateTimeFormats));
                Console.WriteLine(dateOffsetValue.ToString("ddd", dateTimeFormats));

                // Display full weekday name for fr-FR culture
                Console.WriteLine(dateValue.ToString("ddd", new CultureInfo("fr-FR")));
                Console.WriteLine(dateOffsetValue.ToString("ddd",
                                                           new CultureInfo("fr-FR")));

                // Display abbreviated weekday name with fr-FR DateTimeFormatInfo object
                dateTimeFormats = new CultureInfo("fr-FR").DateTimeFormat;
                Console.WriteLine(dateValue.ToString("dddd", dateTimeFormats));
                Console.WriteLine(dateOffsetValue.ToString("dddd", dateTimeFormats));
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert {0} to a date.", dateString);
            }
        }
    }
    }

