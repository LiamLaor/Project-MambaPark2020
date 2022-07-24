using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    public string atr1;

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["username"] == null)
        {
            atr1 = " ";

        }
        else
        {
            atr1 = "<a href='The_Kingda_ka.aspx' style='color:blue'>For more information tap me!</a>";
        }



    }
}