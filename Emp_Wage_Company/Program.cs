namespace Emp_Wage_Company
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee Wage Computation Portal");

            CalcEmpWage TataSteel = new CalcEmpWage("Infosys", 30, 20, 140);
            TataSteel.CalcWage();

            CalcEmpWage Sony = new CalcEmpWage("IBM", 40, 22, 160);
            Sony.CalcWage();

            CalcEmpWage ITC = new CalcEmpWage("TCS", 33, 26, 170);
            ITC.CalcWage();
        }
    }

    internal class CalcEmpWage
    {
        private string company;
        private int empRatePerHour, noOfWorkingDays, maxHrsPerMonth;

        public CalcEmpWage(string company, int empRatePerHour, int noOfWorkingDays, int maxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.noOfWorkingDays = noOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }

        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;

        public void CalcWage()
        {
            int empHrs = 0;
            int totalWage = 0;
            int day = 1;
            int totalHrs = 0;
            Random random = new Random();
            while (day <= noOfWorkingDays && totalHrs < maxHrsPerMonth)
            {
                int randomInput = random.Next(0, 3);
                switch (randomInput)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        //Console.WriteLine("Full time employee is present");

                        break;
                    case PART_TIME:
                        empHrs = 4;
                        //Console.WriteLine("Part time employee is present");

                        break;
                       
                }
                int empWage = empRatePerHour * empHrs;
                totalWage += empWage; //totalWage =totalWage+empWage;
                totalHrs += empHrs;
                day++;
            }
            Console.WriteLine("Compamy: {0}, Total Wage: {1}",company, totalWage);
        }
    }
}