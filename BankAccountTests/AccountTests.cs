using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod]
        [DataRow(99)]
        [DataRow(99.99)]
        [DataRow(10000)]
        [DataRow(10.995)]
        [TestCategory("Deposit")]
        public void Deposit_SinglePositiveAmounts(double amt)
        {
            Account checking = new Account();
            double expectedBalance = amt;

        }

        [TestMethod()]
        [TestCategory("Deposit")]
        public void Deposit_PositiveAmount_AddsToBalance()
        {
            // AAA Patter (Arrange, Act, Assert)

            // Arrange - Init objects/variables
            Account checking = new Account();
            double depositAmt = 10;
            double expectedBalance = 10;

            // Act - Call method under test
            checking.Deposit(depositAmt);

            // Assert - Verification step
            Assert.AreEqual(expectedBalance, checking.Balance);
        }

        [TestMethod]
        [TestCategory("Deposit")]
        public void Deposit_PositiveAmount_ReturnsUpdateBalance()
        {
            // Arrange
            Account acc = new Account();
            double depositAmt = 10.55;
            double expectedReturn = 10.55;

            // Act
            double result = acc.Deposit(depositAmt);

            // Assert
            Assert.AreEqual(expectedReturn, result);
        }

        [TestMethod]
        public void Deposit_NegativeAmount_ThrowsArgumentException()
        {
            // Arrange
            Account acc = new Account();
            double depositAmt = -1;

            // Assert => Act
            Assert.ThrowsException<ArgumentException>(() => acc.Deposit(depositAmt));
        }
    }
}