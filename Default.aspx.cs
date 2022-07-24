using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    public string name;
    public string pass;
    public string msg = " ";
    public string FirstName, password, response;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.Form["submit"] == "submit")
        {
            name = Request.Form["username"];
            pass = Request.Form["pass"];

            if (name == "liam" && pass == "1234")
            {
                msg = "<div class='myimg'>";
                msg += "<table border='1'><tr>";
                msg += "<td>username:" + name + "</td>";
                msg += "<tr><tr/>";
                msg += "<td><font color = 'green' > Login success </ font > ";
                msg += "</div>";

                Session["username"] = name;
                Response.Redirect("Default2.aspx");
            }
            else
            {
                msg = "<p style='color:red; font-family:Arial;'>Login failed</p>";
            }

        }
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

        if (IsPostBack)
        {
            SqlConnection connection = new SqlConnection(ConnectionString());

            connection.Open();

            string sql = "SELECT * FROM Login";
            SqlCommand cmd = new SqlCommand(sql, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            connection.Close();

            for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
            {
                DataRow dr = ds.Tables[0].Rows[x];
                if (name == dr["Username"].ToString().Trim() && password == dr["Password"].ToString().Trim())
                {
                    msg = "<td><font color = 'green' > Login success </ font > ";
                }
                else
                {
                    msg = "<p style='color:red; font-family:Arial;'>Login failed</p>";
                }

            }

        }
    }
   static string ConnectionString()
    {
        return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\orna\source\repos\class_explain_29_11\class_explain_29_11\App_Data\Database.mdf;Integrated Security=True";
    }
}