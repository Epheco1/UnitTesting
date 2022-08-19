using System;

namespace UnitTesting
{

    public class StaffBenefits
    {
        public static int Basic { get; set; } = 10;
        public int Housing { get; set; } = 15;
        public int Transportation { get; set; } = 5;
        public static void Main(string[] args)
        {
            var total = SalaryCalc(10, 15, 5);
            var leaveAmount = LeaveAllowance(10, 15, 5);
            Console.WriteLine($"The total is {total} and leave allowance is {leaveAmount}");
        }
        public static decimal SalaryCalc(decimal basic, decimal housing, decimal transportation)
        {
            return (basic + housing + transportation) * 2;

        }
        public static decimal LeaveAllowance(decimal basic, decimal housing, decimal transportation)
        {
            return (SalaryCalc(10, 15, 5) * 15/100);
        }
    }

}