using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace SimpleBankManagement
{
    public partial class CustomerSignUp : System.Web.UI.Page
    {
        private string sql;
        private SqlConnection con;
        private SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Convert.ToInt32(args.Value) >= 18)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Convert.ToInt32(args.Value) >= 1000)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void custsignup_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-REA59UK;initial catalog=bank ; Integrated Security=true;");
            con.Open();
            sql = "Insert into Customer (username,pass,email,age,balance) values(@username,@pass,@email,@age,@balance)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@username", CName.Text);
            cmd.Parameters.AddWithValue("@pass", CPass.Text);
            cmd.Parameters.AddWithValue("@email", CEmail.Text);
            cmd.Parameters.AddWithValue("@age", Age.Text);
            cmd.Parameters.AddWithValue("@balance", Balance.Text);
            cmd.ExecuteNonQuery();
            Label1.Text = "Save data Successfully...";

            cmd.Dispose();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CName.Text = "";
            CPass.Text = "";
            CEmail.Text = "";
            Age.Text = "";
            Balance.Text = "";
        }
    }
}