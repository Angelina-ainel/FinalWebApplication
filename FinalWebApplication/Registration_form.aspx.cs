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
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.Remoting.Messaging;

namespace FinalWebApplication
{
    public partial class Registration_form : System.Web.UI.Page
    {

        public string st = "";
        public string msg = "";
        public string sqlMsg = "";
        public string yearBorn = "";

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
                string city = Request.Form["city"];
                string HavingPets = Request.Form["pets"];
                bool havingPets = false;
                if (HavingPets == "yes")
                    havingPets = true;
                else
                    havingPets = false;
                string fileName = "First_UsersDB.mdf";
                string usersTable = "usersTbl";
                string citiesTable = "citiesTbl";
                string sqlSelect = $"SELECT * FROM {usersTable} WHERE username ='{username}'";
                if (DBHelper.Find(fileName, sqlSelect))
                {
                    msg = "This username has already been taken, please create a new one";
                    sqlMsg = sqlSelect;
                }
                else
                {
                    string CitiesQuery = $"select Id from {citiesTable} where cityName = '{city}'";
                    Console.WriteLine(CitiesQuery);
                    SqlConnection connection = DBHelper.ConnectToDb(fileName);
                    connection.Open();
                    SqlCommand com = new SqlCommand(CitiesQuery, connection);

                    SqlDataReader reader = com.ExecuteReader();
                    int cityId = 0;
                    Console.WriteLine(reader.Read());
                    if (reader.Read())
                        cityId = (int)reader.GetValue(0);
                    else
                    {
                        reader.Close();
                        com.Dispose();
                        string addNewCity = $"insert into {citiesTable} values ('{city}')";
                        DBHelper.DoQuery(fileName, addNewCity);
                        
                        SqlCommand com2 = new SqlCommand(CitiesQuery, connection);

                        SqlDataReader reader2 = com.ExecuteReader();
                        Console.WriteLine(reader2.Read());
                        cityId = (int)reader2.GetValue(0);
                        reader2.Close();
                        com2.Dispose();
                    }
                    Console.WriteLine(cityId);
                    
                    connection.Close();

                    string sqlInsert = $"insert into {usersTable} ";
                    sqlInsert += $"values ('{username}', '{firstName}', '{lastName}', '{email}', '{birthYear}', " +
                        $"'{gender}', '{prefix}', '{phone}', '{hobby1}', '{hobby2}', '{hobby3}', '{hobby4}', '{cityId}', '{havingPets}')";
                    sqlMsg = sqlInsert;
                    DBHelper.DoQuery(fileName, sqlInsert);
                    msg = "You were successfully registered on our website!";
                }

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

                st += "<tr><td> having pets: </td><td>" + HavingPets + "</td></tr>"; 


            }
        }
    }
}