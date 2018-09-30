using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace SimpleBankManagement
{
    public class Transfer_Database
    {
        private SqlConnection con;
        private SqlCommand cmd;
        public double Tran_DB(double amount, string name, string email)
        {
            con = new SqlConnection("Data Source=DESKTOP-REA59UK;initial catalog=bank ; Integrated Security=true;");
            cmd = new SqlCommand("SelectCustomerForTransfer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TEmail", email);
            cmd.Parameters.Add("@SelectCustomerForTransfer", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            int count = int.Parse(cmd.Parameters["@SelectCustomerForTransfer"].Value.ToString());
            if (count == 1)
            {
                float _amount = (float)Convert.ToDouble(amount);
                cmd = new SqlCommand("SelectCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.Add("@SelectCustomer", SqlDbType.Float).Direction = ParameterDirection.ReturnValue;
                cmd.Connection = con;
                //con.Open();
                cmd.ExecuteNonQuery();
                float baln = float.Parse(cmd.Parameters["@SelectCustomer"].Value.ToString());
                if ((baln - _amount) >= 1000.00)
                {
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "_Transfer";
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@TEmail", email);
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
            else
            {
                return 1;
            }
        }
    }
}
