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

public partial class admin_Get_Admin : System.Web.UI.Page
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
        AdminSystem adminSystem = new AdminSystem();
        List<Admin> List_Admin = new List<Admin>();
        List_Admin=adminSystem.Get_Admin();
        Admin_List.DataSource = List_Admin;
        Admin_List.DataBind();
    }

    protected void Admin_List_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int nID = Int32.Parse(Admin_List.DataKeys[e.RowIndex].Value.ToString());
        AdminSystem adminSystem = new AdminSystem();
        adminSystem.Delete_Admin(nID);
        BinData();
    }


}
