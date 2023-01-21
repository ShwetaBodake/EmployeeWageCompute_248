﻿namespace EmployeeWageCompute_248
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program");
            const int isPresent = 1;
            const int isPartTime = 2;
            const int EMPWagePerHr = 20;
            int DaysInMonth = 20;
            int EmpHours = 8;
            int DailyWage = 0;
            int TotalWage = 0;
            int day = 1;
            //UC1-EmployeeAttendance
            Random random = new Random();
            for (day = 1; day <= DaysInMonth; day++)
            {
                int EmpAttendance = random.Next(0, 3);

                switch (EmpAttendance)
                {
                    case isPresent:
                        Console.WriteLine("\nEmployee is Present");
                        EmpHours = 8;
                        break;
                    case isPartTime:
                        Console.WriteLine("\nEmployee is Part time Present");
                        EmpHours = 4;
                        break;
                    default:
                        Console.WriteLine("\nEmployee is Absent");
                        EmpHours = 0;
                        break;
                }


                DailyWage = EmpHours * EMPWagePerHr;
                Console.WriteLine("Daily Wage Of Employee is {0}", DailyWage);
                //TotalWageOfMonth = TotalWageOfMonth + DailyWage;
                TotalWage+= DailyWage;
                Console.WriteLine("Monthly Wage of Employee is {0}", TotalWage);
                //Console.ReadLine();
            }
        }
    }
}

