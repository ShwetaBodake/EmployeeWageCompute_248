namespace EmployeeWageCompute_248
{
    class Program
    {
        public static void Main(string[] args)
        {
            ComputeWage();
        }
        public static void ComputeWage()
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program");
            const int isPresent = 1;
            const int isPartTime = 2;
            const int EMPWagePerHr = 20;
            int DaysInMonth = 20;
            int EmpHours = 0;
            int DailyWage = 0;
            int TotalWage = 0;
            int totalhrs = 0;
            int day = 1;
            int MaxHours = 100;
       
            Random random = new Random();
            while (day <= DaysInMonth && EmpHours <= MaxHours)
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
                Console.WriteLine("Daily Wage Of Employee is {0} at day{1}", DailyWage, day);
                //TotalWageOfMonth = TotalWageOfMonth + DailyWage;
                TotalWage += DailyWage;
                Console.WriteLine("Monthly Wage of Employee is {0}", TotalWage);
                day++;
                totalhrs += EmpHours;
                Console.WriteLine(totalhrs);
                // EmpHours++;

                //Console.ReadLine();
            
        }


    }
    }
}

