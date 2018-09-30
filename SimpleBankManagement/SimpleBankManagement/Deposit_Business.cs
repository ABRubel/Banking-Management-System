using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBankManagement
{
    public class Deposit_Business
    {
        public double DepositTaka(double amount, string name)
        {
            Deposit_Database db = new Deposit_Database();
            return db.Dep_DB(amount, name);
        }
        public int DepositNull(double? amount, string name)
        {
            if (amount == null)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}