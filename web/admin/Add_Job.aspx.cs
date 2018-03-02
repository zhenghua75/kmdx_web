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
public partial class admin_Add_Job : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Admin_User"] == null)
        {
            Response.Redirect("login.aspx");
            Response.End();
        }
    }
    protected void Add_Btn_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            Job job = new Job();
            job.Title = Title.Text.ToString();
            job.Click = Int32.Parse(Click.Text.ToString());
            job.Content = Content.Value.ToString();
            JobSystem jobSystem = new JobSystem();
            if (jobSystem.Add_Job(job) > 0)
            {
                Response.Write("<script>alert('添加成功');location.href='Get_Job.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('添加失败');history.back(1);</script>");
            }
        }
    }
}
