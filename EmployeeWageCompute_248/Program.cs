namespace EmployeeWageCompute_248
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
            int TotalWageOfMonth = 0;
            //UC1-EmployeeAttendance
            Random random = new Random();
            int EmpAttendance = random.Next(0, 3);
            switch(EmpAttendance)
            {
                case isPresent:
                    Console.WriteLine("Employee is Present");
                    EmpHours = 8;
                    break;
                case isPartTime:
                    Console.WriteLine("Employee is Part time Present");
                    EmpHours = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    EmpHours = 0;
                    break;
            }
         
            DailyWage = EmpHours * EMPWagePerHr;
            Console.WriteLine("Daily Wage Of Employee is {0}", DailyWage);
            TotalWageOfMonth = DailyWage * DaysInMonth;
            Console.WriteLine("Monthly Wage of Employee is {0}", TotalWageOfMonth);

        }
    }
}

