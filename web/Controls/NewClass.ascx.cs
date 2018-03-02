using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BLL;
using Model;

public partial class Controls_NewClass : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {            
            NewClassSystem newClassSystem = new NewClassSystem();          
            ClassID.DataSource = newClassSystem.Get_NewClass(0);
            ClassID.DataBind();
        }
    }
}
