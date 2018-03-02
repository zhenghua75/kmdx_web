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
using System.Text;
using System.Collections.Generic;
using Model;
using BLL;
public partial class admin_Get_NewClass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Admin_User"] == null)
        {
            Response.Redirect("login.aspx");
            Response.End();
        }
        else
        {
            if (!Page.IsPostBack)
            {
                BinData();
            }
        }
    }

    public void BinData()
    {
        NewClassSystem newClassSystem = new NewClassSystem();
        NewClass_List.DataSource = newClassSystem.Get_NewClass(0);
        NewClass_List.DataBind();
    }

    protected void NewClass_List_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int nClassID = Int32.Parse(NewClass_List.DataKeys[e.RowIndex].Value.ToString());
        NewClassSystem newClassSystem = new NewClassSystem();
        newClassSystem.Delete_NewClass(nClassID);
        BinData();
    }
}
