using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleBankManagement
{
    public partial class Customer : System.Web.UI.Page
    {
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


        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("About.aspx");
        }

        protected void Diposit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Deposit.aspx");

        }

        protected void Withdraw_Click(object sender, EventArgs e)
        {
            Response.Redirect("Withdraw.aspx");

        }

        protected void Transfer_Click(object sender, EventArgs e)
        {
            Response.Redirect("Transfer.aspx");

        }
    }
}