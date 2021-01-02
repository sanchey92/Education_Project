using System.Collections.Generic;

namespace SoftwareDevelopDomain.Persons
{
    public class Manager : Staff
    {
        public static decimal MonthBonus => 20000;
        public decimal TotalPay { get; }

        public Manager(string name, List<TimeRecord> timeRecords) : base(name, 200000, timeRecords)
        {
            var payPerHour = MonthSalary / Settings.WorkHoursInMonth;
            var bonusPerDay = (MonthBonus / Settings.WorkHoursInMonth) * Settings.WorkHoursInDay;

            decimal totalPay = 0;

            foreach (var timeRecord in timeRecords)
            {
                if (timeRecord.Hours <= Settings.WorkHoursInDay)
                {
                    totalPay += timeRecord.Hours * payPerHour;
                }
                else
                {
                    totalPay += Settings.WorkHoursInDay * payPerHour + bonusPerDay;
                }
            }

            TotalPay = totalPay;
        }
    }
}