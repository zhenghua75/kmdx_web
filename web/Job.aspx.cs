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

public partial class Job : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Title = "科技有限公司";
        if (!Page.IsPostBack)
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
        List_Job.DataSource = jobSystem.Get_Job(AspNetPager1.StartRecordIndex, AspNetPager1.EndRecordIndex);
        List_Job.DataBind();
    }
}
