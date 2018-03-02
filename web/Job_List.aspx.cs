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

public partial class Job_List : System.Web.UI.Page
{
    int nID = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        Title = "科技有限公司";
        if (Request.Params["ID"] != null)
        {
            nID = Int32.Parse(Request.Params["ID"].ToString());
            if (nID > 0)
            {
                if (!Page.IsPostBack)
                {
                    BinData();
                }
            }
            else
            {
                Response.Write("<script>alert('请选择数据');history.back(1);</script>");
                Response.End();
            }
        }
        else
        {
            Response.Write("<script>alert('请选择数据');history.back(1);</script>");
            Response.End();
        }
    }

    public void BinData()
    {
        Model.Job job = new Model.Job();
        JobSystem jobSystem = new JobSystem();
        job = jobSystem.Get_SingJob(nID);
        if (job.ID == nID)
        {
            Title_2.Text = job.Title;
            Updatatime.Text = job.Updatatime.ToString();
            Content.Text = job.Content;
        }
        else
        {
            Response.Write("<script>alert('数据不存在');history.back(1);</script>");
            Response.End();
        }
    }
}
