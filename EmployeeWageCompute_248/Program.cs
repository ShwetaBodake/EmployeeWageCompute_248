namespace EmployeeWageCompute_248
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program");
            int isPresent = 1;
            //UC1-EmployeeAttendance
            Random random = new Random();
            int EmpAttendance = random.Next(0, 2);
            if (EmpAttendance == isPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}

