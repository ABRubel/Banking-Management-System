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
    public partial class Deposit : System.Web.UI.Page
    {
        public Deposit_Business dep_bn = new Deposit_Business();
        public string name;
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
            name = Session["username"].ToString();
            double amount = Convert.ToDouble(Amount.Text);
            double? amount1 = Convert.ToDouble(Amount.Text);
            if (amount1 ==null)
            {
                Label2.Text = "Records updated successfully";
            }
             if (amount > 0.0)
            {
                double dep_re = dep_bn.DepositTaka(amount, name);
                Label2.Text = "Records updated successfully";
            }
            if (amount < 0.0)
            {
                Label2.Text = "Records are not updated as deposit amount cannot be negative";
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