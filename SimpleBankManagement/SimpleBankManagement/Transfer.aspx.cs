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
    public partial class Transfer : System.Web.UI.Page
    {
        private double trans_res;
        private SqlConnection con;
        private SqlCommand cmd;
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

            string email = TEmail.Text.ToString();

            double? amount1 = Convert.ToDouble(Amount.Text);

            if (email==null || amount1 == null)
            {
                Label2.Text = "Transaction Email/Amount Cannot be Null";
            }
            
            if (amount > 0.0)
            {
                Transfer_Business Tran_Bus = new Transfer_Business();
                trans_res = Tran_Bus.TransferTaka(amount, name, email);
                Label2.Text = "TK Transfer Successful";
                Label2.ForeColor = System.Drawing.Color.Blue;
            }
            if (trans_res == 0)
            {
                Label2.Text = "Sorry! You have to have atleast 1000 TK in your account";
                Label2.ForeColor = System.Drawing.Color.Red;
            }
            if (trans_res == 1)
            {
                Label2.Text = "Sorry! No Email is mathched";
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