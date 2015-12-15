using System;

namespace _01.HumanStudentAndWorker.Models
{
    public class Worker: Human
    {
        private const string WeekSalaryErrorMsg = "The week salary cannot be negative";
        private const string WorkHoursPerDayErrorMsg = "The work hours cannot be negative";
        private const int WorkDaysPerWeek = 5;

        private decimal weekSalary;
        private int workHoursPerDay;


        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary; 
                
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(WeekSalaryErrorMsg);
                }

                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;

            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(WorkHoursPerDayErrorMsg);
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary/WorkDaysPerWeek*this.WorkHoursPerDay;
        }

        public override string ToString()
        {
            return string.Format("{0} - Money per hour: {1:F2}", base.ToString(), this.MoneyPerHour());
        }
    }
}
