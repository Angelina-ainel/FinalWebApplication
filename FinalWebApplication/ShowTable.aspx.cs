using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Security.Cryptography;

namespace FinalWebApplication
{
    public partial class ShowTable : System.Web.UI.Page
    {
        public string st = "";
        public string msg = "";
        public string sqlSelect = "";
        public string sqlSelect2 = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            string fileName = "First_UsersDB.mdf";
            string tableNameUsers = "usersTbl";
            string tableNameCities = "citiesTbl";
            sqlSelect = "SELECT * FROM " + tableNameUsers;
            sqlSelect2 = $"SELECT username, firstName, lastName, yearBorn FROM {tableNameUsers} WHERE {tableNameUsers}.yearBorn > 19";
            // 1.
            DataTable table = DBHelper.ExecuteDataTable(fileName, sqlSelect);
            int length = table.Rows.Count;
            if (length == 0)
                msg = "no registered users";
            else
            {
                st += "<tr>";
                st += "<th>Username</th>";
                st += "<th>First name</th>";
                st += "<th>Last name</th>";
                st += "<th>email</th>";
                st += "<th>Year of birth</th>";
                st += "<th>gender</th>";
                st += "<th>prefix</th>";
                st += "<th>phone</th>";
                st += "<th>city</th>";
                st += "<th> hobby 1 </th>";
                st += "<th> hobby 2 </th>";
                st += "<th> hobby 3 </th>";
                st += "<th> hobby 4 </th>";
                st += "<th> Having pets </th>";
                st += "<tr>";
            }
            for (int i = 0; i < length; i++)

            {
                st += "<tr>";
                st += "<td>" + table.Rows[i]["userName"] + "</td>";
                st += "<td>" + table.Rows[i]["firstName"] + "</td>";
                st += "<td>" + table.Rows[i]["lastName"] + "</td>";
                st += "<td>" + table.Rows[i]["email"] + "</td>";
                st += "<td>" + table.Rows[i]["yearBorn"] + "</td>";
                st += "<td>" + table.Rows[i]["gender"] + "</td>";
                st += "<td>" + table.Rows[i]["prefix"] + "</td>";
                st += "<td>" + table.Rows[i]["phone"] + "</td>";
                st += "<td>" + table.Rows[i]["city"] + "</td>";
                st += "<td>" + table.Rows[i]["hobby1"] + "</td>";
                st += "<td>" + table.Rows[i]["hobby2"] + "</td>";
                st += "<td>" + table.Rows[i]["hobby3"] + "</td>";
                st += "<td>" + table.Rows[i]["hobby4"] + "</td>";
                st += "<td>" + table.Rows[i]["havingPets"] + "</td>";
                st += "</tr>";
            }
            
            msg += $"{length} registered users";
        }
    }
}