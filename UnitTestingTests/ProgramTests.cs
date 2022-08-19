using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace UnitTesting.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SalaryCalcTest()
        {
           decimal total = StaffBenefits.SalaryCalc(10, 15, 5);

            Assert.AreEqual(total, 60);
        }

        [TestMethod()]
        public void LeaveAllowanceTest()
        {
            decimal leaveAmount = StaffBenefits.LeaveAllowance(10, 15, 5);

            Assert.AreEqual(leaveAmount, 9);
        }
    }
}