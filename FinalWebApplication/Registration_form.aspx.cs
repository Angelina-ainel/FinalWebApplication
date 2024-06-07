using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Data;

namespace FinalWebApplication
{
    public partial class Registration_form : System.Web.UI.Page
    {

        public string st = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["submit"] != null)
            {
        
                
               
                st += "<tr><th colspan='2'> Registered user </th></tr>";

                string username = Request.Form["username"];
                string firstName = Request.Form["firstName"];
                string lastName = Request.Form["lastName"];
                string email = Request.Form["email"];
                int birthYear = int.Parse(Request.Form["birthYear"].ToString().Trim());
                string gender = Request.Form["gender"];
                string prefix = Request.Form["phonePrefix"];
                string phone = Request.Form["phone"];
                string hobby1 = Request.Form["hobby1"];
                string hobby2 = Request.Form["hobby2"];
                string hobby3 = Request.Form["hobby3"];
                string hobby4 = Request.Form["hobby4"];
                string havingPets = Request.Form["pets"];

                string fileName = "First_UsersDB.mdf";
                string tableName = "usersTbl";
                string sqlSelect = $"SELECT * FROM {tableName} WHERE username ='{username}'";
                

                st += "<tr><td> user name: </td><td>" + username + "</td></tr>";
                st += "<tr><td> first name: </td><td>" + firstName + "</td></tr>";
                st += "<tr><td> last name: </td><td>" + lastName + "</td></tr>";
                st += "<tr><td> email: </td><td>" + email + "</td></tr>";
                st += "<tr><td> year of birth: </td><td>" + birthYear + "</td></tr>";
                st += "<tr><td> gender: </td><td>" + gender + "</td></tr>";
                st += "<tr><td> Phone: </td><td>" + prefix + "-" + phone + "</td></tr>";
                Console.WriteLine(hobby2);
                
                if (hobby1 != "")
                    st += "<tr><td> hobby1: </td><td>" + hobby1 + "</td></tr>";
                if (hobby2 != "")
                    st += "<tr><td> hobby2: </td><td>" + hobby2 + "</td></tr>";
                if (hobby3 != "")
                    st += "<tr><td> hobby3: </td><td>" + hobby3 + "</td></tr>";
                if (hobby4 != "")
                    st += "<tr><td> hobby4: </td><td>" + hobby4 + "</td></tr>";

                st += "<tr><td> having pets: </td><td>" + havingPets + "</td></tr>"; 


            }
        }
    }
}