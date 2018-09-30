using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBankManagement
{
    [TestFixture]
    public class UnitTesting
    {
        public UnitTesting()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        [Test]
        public void DepositTestingFunction()
        {
            Deposit_Business Dep_Bl = new Deposit_Business();
            double result = Dep_Bl.DepositTaka(500.0, "rubel@gmail.com");
            Assert.AreEqual(500.0, result);
        }
        [Test]
        public void DepositTestingNull()
        {
            Deposit_Business Dep_Bl = new Deposit_Business();
            int result = Dep_Bl.DepositNull(500.0, "rubel@gmail.com");
            Assert.AreEqual(0, result);
        }
        [Test]
        public void WithdrawTestingFunction()
        {
            Withdraw_Business With_bus = new Withdraw_Business();
            double result = With_bus.WithdrawTaka(501.0, "rubel@gmail.com");
            Assert.AreEqual(500.0, result);
        }
        [Test]
        public void WithdrawTestingForNull()
        {
            Withdraw_Business With_bus = new Withdraw_Business();
            int result = With_bus.WithdrawNull(501.0, "rubel@gmail.com");
            Assert.AreEqual(0, result);
        }
        [Test]
        public void TransferTestingFunction()
        {
            Transfer_Business Tra_bus = new Transfer_Business();
            double result = Tra_bus.TransferTaka(500.0, "rubel@gmail.com", "Fayez@gmail.com");
            Assert.AreEqual(500.0, result);
        }
        [Test]
        public void TransferTestingForNull()
        {
            Transfer_Business Tra_bus = new Transfer_Business();
            int result = Tra_bus.TransferNull(500.0, "rubel@gmail.com","Fayez@gmail.com");
            Assert.AreEqual(0, result);
        }
    }
}