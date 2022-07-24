using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public string facilities="";
    public string login_href;
    public string register_href="";
    public string logout;
    public string name;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {

            login_href = "<a href='Login.aspx'>Login</a>";
            
            register_href = "<a href='Register.aspx'>Register</a>";
            logout = "";
            name = "";

        }
        else
        {
            login_href = "";
            
            register_href = "";
            logout = "<a href='Logout.aspx' style='float:right'>Log Out</a>";
            name = (string)Session["username"];


        }
    }

}
