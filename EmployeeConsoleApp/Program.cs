using System;

namespace EmployeeConsoleApp
{
    internal class Program
    {
        static int CheckAttendance()
        {
            Random rnd = new Random();
            int attendance = rnd.Next(0,3);
            return attendance;
        }

        static int CalculateDailyWage(int attendance)
        {
            int WagePerHour = 20;
            switch (attendance)
            {
                case 0:
                    return 0;
                case 1:
                    return WagePerHour*4;
                case 2:
                    return WagePerHour*8;
            }
            return 0;
        }


        static void Main(string[] args)
        {
            int totalWage = 0;
            int totalWorkingHours = 0;
            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Day {i} :");
                int attendance = CheckAttendance();
                int dailyWage = CalculateDailyWage(attendance);
                switch (attendance)
                {
                    case 0:
                        Console.WriteLine("\tAttendance : Absent");
                        break;
                    case 1:
                        Console.WriteLine("\tAttendance : Present-PartTime");
                        totalWorkingHours += 4;
                        break;
                    case 2:
                        Console.WriteLine("\tAttendance : Present-FullTime");
                        totalWorkingHours += 8;
                        break;
                }
                Console.WriteLine($"\tDaily Wage : {dailyWage}");
                totalWage += dailyWage;

                if (totalWorkingHours >= 100)
                {
                    break;
                }
            }

            Console.WriteLine("\nMonthly Total Working Hours : " + totalWorkingHours);
            Console.WriteLine("Monthly Total wage : " + totalWage);
        }
    }
}
