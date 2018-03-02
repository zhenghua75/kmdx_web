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
public partial class admin_Update_Job : System.Web.UI.Page
{
    int nID = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Admin_User"] == null)
        {
            Response.Redirect("login.aspx");
            Response.End();
        }
        else
        {
            if (Request.Params["ID"] != null)
            {
                if (!Page.IsPostBack)
                {
                    nID = Int32.Parse(Request.Params["ID"].ToString());
                    if (nID > 0)
                    {                        
                        BinData();
                    }
                    else
                    {
                        Response.Write("<script>alert('请选择要修改的数据');history.back(1);</script>");
                        Response.End();
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('请选择要修改的数据');history.back(1);</script>");
                Response.End();
            }
        }
    }

    public void BinData()
    {
        Job job = new Job();
        JobSystem jobSystem = new JobSystem();
        job=jobSystem.Get_SingJob(nID);
        Title.Text = job.Title;
        ID.Value = job.ID.ToString();
        Content.Value = job.Content;
        Click.Text = job.Click.ToString();
    }
    protected void Update_Btn_Click(object sender, EventArgs e)
    {
        Job job = new Job();
        job.ID = Int32.Parse(ID.Value.ToString());
        job.Title = Title.Text.ToString();
        job.Content = Content.Value.ToString();
        job.Click = Int32.Parse(Click.Text.ToString());
        JobSystem jobSystem = new JobSystem();
        jobSystem.Update_Job(job);
        Response.Write("<script>alert('修改成功');location.href='Get_Job.aspx';</script>");
    }
}
