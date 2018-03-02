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
public partial class admin_Add_News : System.Web.UI.Page
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
                BinClassData();
            }
        }
    }
    public void BinClassData()
    {
        NewClassSystem newClassSystem = new NewClassSystem();
        ClassID.DataSource = newClassSystem.Get_NewClass(0);
        ClassID.DataTextField = "ClassName";
        ClassID.DataValueField = "ClassID";
        ClassID.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        News news = new News();
        news.Title = Title.Text.ToString();
        news.Source = Source.Text.ToString();
        news.Author = Author.Text.ToString();
        news.Content = Content.Value.ToString();
        news.Updatatime = DateTime.Now;
        news.Click = Int32.Parse(Click.Text.ToString());
        NewClassSystem newClassSystem = new NewClassSystem();
        news.NewClass = newClassSystem.Get_SintNewClass(Int32.Parse(ClassID.SelectedValue));
        NewsSystem newsSystem = new NewsSystem();
        if (newsSystem.Add_News(news) > 0)
        {
            Response.Write("<script>alert('添加成功');location.href='Get_News.aspx';</script>");
        }
        else
        {
            Response.Write("<script>alert('添加失败');history.back(1);</script>");
        }
    }
}
