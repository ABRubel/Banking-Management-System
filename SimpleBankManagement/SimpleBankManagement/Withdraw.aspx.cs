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
    public partial class Withdraw : System.Web.UI.Page
    {
        private double with_res;
        private SqlConnection con;
        private SqlCommand cmd;

        /*private Int32 count;
        private DataTable dt;
        private SqlDataAdapter da;*/
        public Withdraw_Business With_Bus = new Withdraw_Business();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("CustomerLogin.aspx");
            }
            else
            {
                Label1.Text = Session["username"].ToString();
            }
        }
        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("About.aspx");
        }
        public void Confirm_Click(object sender, EventArgs e)
        {
            string name = Session["username"].ToString();
            double amount = Convert.ToDouble(Amount.Text);
            if (amount > 0.0)
            {
                with_res = With_Bus.WithdrawTaka(amount, name);
                Label2.Text = "TK Withdraw Successful";
                Label2.ForeColor = System.Drawing.Color.Blue;
            }
            if (with_res == 0)
            {
                Label2.Text = "Sorry! You have to have atleast 1000 TK in your account";
                Label2.ForeColor = System.Drawing.Color.Red;
            }
            if (amount < 0.0)
            {
                Label2.Text = "Amount cannot be negative";
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Convert.ToInt32(args.Value) > 0)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}