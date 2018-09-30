using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBankManagement
{
    public class Transfer_Business
    {
        public double TransferTaka(double amount, string name,string email)
        {
            Transfer_Database Tran_DB = new Transfer_Database();
            return Tran_DB.Tran_DB(amount, name,email);
        }
        public int TransferNull(double? amount, string name,string email)
        {
            Transfer_Database Tran_DB = new Transfer_Database();
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