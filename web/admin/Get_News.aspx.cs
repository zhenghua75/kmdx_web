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
using Model;
using BLL;
public partial class admin_Get_News : System.Web.UI.Page
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
            NewsSystem newsSystem = new NewsSystem();
            AspNetPager1.RecordCount = newsSystem.Get_NewsNum();
        }
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        BinData();
    }
    public void BinData()
    {
        NewsSystem newsSystem = new NewsSystem();
        News_List.DataSource = newsSystem.Get_News(AspNetPager1.StartRecordIndex, AspNetPager1.EndRecordIndex);
        News_List.DataBind();
    }

    protected void News_List_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int nID = Int32.Parse(News_List.DataKeys[e.RowIndex].Value.ToString());
        NewsSystem newsSystem = new NewsSystem();
        newsSystem.Delete_News(nID);
        BinData();
    }
}
