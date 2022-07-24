using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public string name;
    public string pass;
    public string msg = " ";
    //public string FirstName, password, response;
    protected void Page_Load(object sender, EventArgs e)
    {
        name = Request.Form["username"];
        pass = Request.Form["password"];
       
        if (Application["admin"] == null)
        {
            Application["admin"] = 0;
        }
        if (Session["user"] != null && (bool)Session["user"] == false)
        {
            Session["user"] = true;
            Application.Lock();
            Application["admin"] = (int)Application["admin"] + 1;
            Application.UnLock();
        }
        else
        {
            Session["user"] = null;
        }

        if (IsPostBack)
        {
            SqlConnection connection = new SqlConnection(ConnectionString());
            connection.Open();

            string sql = "SELECT * FROM Users";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            connection.Close();

            for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
            {
                DataRow dr = ds.Tables[0].Rows[x];
                if (name == dr["Username"].ToString().Trim() && pass == dr["Password"].ToString().Trim())
                {
                   Session ["msg"] = "<p style='color =green' > Login success </p > ";
                   Session["username"] = "Hello, "+name;
                    
                   Response.Redirect("Home.aspx");
                }
                else
                {
                    Session ["msg"] = "<p style='color:red; font-family:Arial;'>Login failed</p>";
                }

            }

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
    //static string ConnectionString()
    //{
    //    return @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\orna\Desktop\Google Drive\Liam Website\class_explain_29_11\class_explain_29_11\App_Data\Database.mdf'; Integrated Security = True";
    //}
}


    //Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\orna\source\repos\class_explain_29_11\class_explain_29_11\App_Data\Database.mdf;Integrated Security = True