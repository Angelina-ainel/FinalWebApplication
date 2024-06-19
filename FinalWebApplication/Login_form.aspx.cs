using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Remoting.Messaging;

namespace FinalWebApplication
{
    public partial class Login_form : System.Web.UI.Page
    {
        public string msg ="";
        public string sqlLogin;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["submit"] != null)
            {
                string username = Request.Form["username"];
                string email = Request.Form["email"];

                string fileName = "First_UsersDB.mdf";
                string usersTable = "usersTbl";

                sqlLogin = $"SELECT * FROM {usersTable} WHERE username = '{username}' AND email = '{email}'";
                if (DBHelper.Find(fileName, sqlLogin))
                {
                    DataTable table = DBHelper.ExecuteDataTable(fileName, sqlLogin);
                                        
                    Session["username"] = table.Rows[0]["username"];
                    Session["firstName"] = table.Rows[0]["firstName"];
                    Response.Redirect("WebForm1.aspx");
                    
                }
                else
                {
                    msg = "The user is not found, try registering on the website first";
                   // Response.Redirect("Login_form.aspx");
                }

            }
        }
    }
}