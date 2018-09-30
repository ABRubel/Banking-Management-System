using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace SimpleBankManagement
{
    public partial class CustomerLogin : System.Web.UI.Page
    {
        private string sql;
        private SqlConnection con;
        private SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-REA59UK;initial catalog=bank ; Integrated Security=true;");
            sql = "select * from Customer where email='" + custname.Text + "'and pass='" + custpass.Text.ToString() + "'";
            con.Open();
            cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["username"] = custname.Text;
                Response.Redirect("Customer.aspx");
            }
            else
            {
                Label2.Text = "plz check username and passowrd";
                Label2.ForeColor = System.Drawing.Color.Red;
            }
            con.Close();
        }
    }
}