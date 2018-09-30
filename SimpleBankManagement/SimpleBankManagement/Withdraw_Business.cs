using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBankManagement
{
    public class Withdraw_Business
    {
        public double WithdrawTaka(double amount, string name)
        {
            Withdraw_Database With_DB = new Withdraw_Database();
            return With_DB.With_DB(amount, name);
        }

        public int WithdrawNull(double? amount, string name)
        {
            Withdraw_Database With_DB = new Withdraw_Database();
            if(amount==null)
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