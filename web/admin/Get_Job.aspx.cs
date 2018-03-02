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
public partial class admin_Get_Job : System.Web.UI.Page
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
            JobSystem jobSystem = new JobSystem();
            AspNetPager1.RecordCount = jobSystem.Get_JobNum();
        }
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        BinData();
    }
    public void BinData()
    {
        JobSystem jobSystem = new JobSystem();
        Job_List.DataSource = jobSystem.Get_Job(AspNetPager1.StartRecordIndex, AspNetPager1.EndRecordIndex);
        Job_List.DataBind();
    }

    protected void Job_List_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int nID = Int32.Parse(Job_List.DataKeys[e.RowIndex].Value.ToString());
        JobSystem jobSystem = new JobSystem();
        jobSystem.Delete_Job(nID);
        BinData();
    }
}
