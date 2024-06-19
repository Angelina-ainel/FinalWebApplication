using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalWebApplication
{
    public partial class non_recycableWaste : System.Web.UI.MasterPage
    {
        public string loginMsg;
        protected void Page_Load(object sender, EventArgs e)
        {
            loginMsg = $"<h3>Hello, {Session["firstName"].ToString()} </h3>";
            if (Session["username"].ToString() == "guest")
            {
                /*loginMsg += "You can register or login on our website :)";
                 loginMsg += "[<a href= 'Registration_form.aspx'> Sign up</a>] <br />";
                loginMsg += "[<a href= 'Login_form.aspx'>Log in</a>]"; */
            }
            else
            {
                /* loginMsg += "[<a href= 'Registration_form.aspx'> Update details </a>] <br />";  What is updateUser form? */
                loginMsg += "<a class='link' href= 'Logout.aspx'>[log out]</a>";
                
            }

        }
    }
}