using System;
namespace EmployeeWageCompute_248
{
	public class CompanyDetails
	{
		public string company;
		public int maxWorkingDays, maxWorkingHrs, empRatePerHr, totalWage;

		public CompanyDetails(string company,int maxWorkingDays, int maxWorkingHrs, int empRatePerHr)
		{
			this.company = company;
			this.maxWorkingDays = maxWorkingDays;
			this.maxWorkingHrs = maxWorkingHrs;
			this.empRatePerHr = empRatePerHr;
		}

		public void SetTotalWage(int totalWage)
		{
			this.totalWage = totalWage;
		}

        public override string ToString()
        {
			return $"Company:{company} empRate:{empRatePerHr} totalWage:{totalWage}";

		}
    }
}

