using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
namespace SimpleBankManagement
{
    public class Deposit_Database
    {
        private SqlConnection con;
        private SqlCommand cmd;
        public double Dep_DB(double amount, string name)
        {
            con = new SqlConnection("Data Source=DESKTOP-REA59UK;initial catalog=bank ; Integrated Security=true;");
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_Deposit";
            cmd.Parameters.AddWithValue("@Amount", amount);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            return amount;
        }
    }
}