using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace SimpleBankManagement
{
    public class Withdraw_Database
    {
        private SqlConnection con;
        private SqlCommand cmd;
        public double With_DB(double amount, string name)
        {
            float _amount = (float)Convert.ToDouble(amount);
            con = new SqlConnection("Data Source=DESKTOP-REA59UK;initial catalog=bank ; Integrated Security=true;");
            cmd = new SqlCommand("SelectCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.Add("@SelectCustomer", SqlDbType.Float).Direction = ParameterDirection.ReturnValue;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            float baln = float.Parse(cmd.Parameters["@SelectCustomer"].Value.ToString());
            if ((baln - _amount) >= 1000.00)
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "WithdrawUpdate";
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                return (baln - _amount);
            }
            else
            {
                return 0;
            }
        }
    }
}