namespace EmployeeWageCompute_248
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program");
            int isPresent = 1;
            int EMPWagePerHr = 20;
            int EmpHours = 8;
            int DailyWage = 0;
            //UC1-EmployeeAttendance
            Random random = new Random();
            int EmpAttendance = random.Next(0, 2);
            if (EmpAttendance == isPresent)
            {
                Console.WriteLine("Employee is Present");
                EmpHours = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                EmpHours = 0;
            }
            DailyWage = EmpHours * EMPWagePerHr;

            Console.WriteLine("Daily Wage Of Employee is {0}", DailyWage);
        }
    }
}

