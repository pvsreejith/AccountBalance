using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests
{
    [TestClass()]
    public class BankingTests
    {
        [TestMethod()]
        public void withdrawalTest()
        {
            //Arrange
            double withdrawal = 10000;
            double expected = 10000;

            //Act
            Banking banking = new Banking();
            banking.accountBalance = 20000;
            banking.withdrawal(withdrawal);
            double actual = banking.accountBalance;

            //Act
            Assert.AreEqual(actual, expected);
        }
    }
}