using System;
using static System.Console;

namespace CA1
{
    class _
    {
        static void Main()
        {
            Title = "CA Get Month Name"; 
            int monthNumber;
            Write("Enter a Month N | 1 - 12 | : ");
            monthNumber = Convert.ToInt32(ReadLine());
            switch (monthNumber)
            {
                case 1:
                    WriteLine("January");
                    break;
                case 2:
                    WriteLine("February");
                    break;
                case 3:
                    WriteLine("March");
                    break;
                case 4:
                    WriteLine("April");
                    break;
                case 5:
                   WriteLine("May");
                    break;
                case 6:
                    WriteLine("June");
                    break;
                case 7:
                    WriteLine("July");
                    break;
                case 8:
                    WriteLine("August");
                    break;
                case 9:
                    WriteLine("September");
                    break;
                case 10:
                    WriteLine("October");
                    break;
                case 11:
                    WriteLine("November");
                    break;
                case 12:
                    WriteLine("December");
                    break;
                default:
                    WriteLine("You did not enter correct value for month name");
                    break;
            }
            ReadLine();
        }
    }
}
