using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    public string pass1, pass2, username, email;
    public int age;
    public string message = " ";
    bool flag = false;
   

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            pass1 = Request.Form["Password_1"];
            pass2 = Request.Form["Password_2"];
            email = Request.Form["signupEmail"];
            age = int.Parse(Request.Form["signupAge"]);

            string Username = Request.Form["signupName_"];


            if (pass1.ToString() != pass2.ToString())
            {
                message = "<p style='color:red; font-family:Arial;'>password do not match</p>";
                

            }
            else if (Username == null || Username == "")
            {
                message = "<p style='color:red; font-family:Arial;'>username is not valid</p>";
                username = "Invlaid username";

            }
            else
            {
                SqlConnection connection = new SqlConnection(ConnectionString());
                connection.Open();

                string sql = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(sql, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.InsertCommand = builder.GetInsertCommand();

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
                {
                    DataRow dr = ds.Tables[0].Rows[x];
                    if (Username == dr["Username"].ToString().Trim())
                    {
                        flag = true;
                        message = "<p style='color:red; font-family:Arial;'>username is already exist</p>";            // if database contains a similar username flag changes to true.
                    }
                    if (!flag)
                    {
                        DataRow newRow = ds.Tables[0].NewRow();

                        newRow["Username"] = Username;
                        newRow["Password"] = pass1;
                        newRow["Email"] = email;
                        newRow["Age"] = age;

                        ds.Tables[0].Rows.Add(newRow);

                        adapter.Update(ds);


                        //message = "Username: " + username + " was successfully added.";
                        Response.Redirect("Login.aspx");
                    }

                    connection.Close();






                    
                }



            }

            string ConnectionString()
            {
                string path = HttpContext.Current.Server.MapPath("App_Data/");
                path += "Database.mdf";
                //path += "dbName.mdf";
                string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";
                return conStr;
            }
            // string ConnectionString()
            //{

            //    return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C: \Users\orna\Desktop\Google Drive\Liam Website\class_explain_29_11\class_explain_29_11\App_Data\Database.mdf';Integrated Security=True";

            //}
        }
    }
}