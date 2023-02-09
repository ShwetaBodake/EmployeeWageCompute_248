using System;
namespace EmployeeWageCompute_248
{
	public class EmpWageBuilder
	{
        public const int IS_PART_TIME = 1;
        public const int IS_FUL_TIME = 2;
        //int[] arr=new int[5];
        CompanyDetails[] companies;
		int numOfCompany = 0;

		public EmpWageBuilder()
		{
			companies = new CompanyDetails[3];
		}

		public void AddCompanyDetails(string company, int maxWorkingDays, int maxWorkingHrs, int empRatePerHr)
		{
			CompanyDetails companyDetails = new CompanyDetails(company, maxWorkingDays, maxWorkingHrs, empRatePerHr);
			companies[numOfCompany] = companyDetails;
			numOfCompany++;
		}

        private int computeEmpWage(CompanyDetails companyEmpWage)
        {
            int empHrs = 0, totalHr = 0, totalWorkingDays = 0;

            while (totalHr <= companyEmpWage.maxWorkingHrs && totalWorkingDays < companyEmpWage.maxWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FUL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalHr += empHrs;
                Console.WriteLine("Days:  {0} and Employee Hrs: {1}", totalWorkingDays, empHrs);

            }
            return totalHr * companyEmpWage.empRatePerHr;
        }
        public void IterateOverCompanies()
		{
			for(int i=0;i<companies.Length;i++)
			{
				int totalWage = computeEmpWage(companies[i]);
				companies[i].SetTotalWage(totalWage);
				Console.WriteLine(companies[i]);
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine("WelCome To Employee Wage Computaion Problem");
			EmpWageBuilder builder = new EmpWageBuilder();
			builder.AddCompanyDetails("Deloitte", 25, 50, 30);
            builder.AddCompanyDetails("BridgeLabz", 45, 80, 60);
            builder.AddCompanyDetails("Microsoft", 27, 25, 10);
			builder.IterateOverCompanies();
			Console.ReadLine();
        }
      
    }
}

