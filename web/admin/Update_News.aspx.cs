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

public partial class admin_Update_News : System.Web.UI.Page
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
                        BinClassData();
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

    public void BinClassData()
    {
        NewClassSystem newClassSystem = new NewClassSystem();
        ClassID.DataSource = newClassSystem.Get_NewClass(0);
        ClassID.DataTextField = "ClassName";
        ClassID.DataValueField = "ClassID";
        ClassID.DataBind();
    }
    public void BinData()
    {
        News news = new News();
        NewsSystem newsSystem = new NewsSystem();
        news = newsSystem.Get_SintNews(nID);
        ID.Value = news.ID.ToString();
        Title.Text = news.Title;
        Source.Text = news.Source;
        Author.Text = news.Source;
        Content.Value = news.Content;
        Updatatime.Value = news.Updatatime.ToString();
        Click.Text = news.Click.ToString();
        i180cn.i180cn.SetListBoxItem(ClassID, news.NewClass.ClassID.ToString());
    }
    protected void Update_Btn_Click(object sender, EventArgs e)
    {
        News news = new News();
        news.ID = Int32.Parse(ID.Value.ToString());
        news.Title = Title.Text.ToString();
        news.Source = Source.Text.ToString();
        news.Author = Author.Text.ToString();
        news.Content = Content.Value.ToString();
        news.Updatatime =DateTime.Parse(Updatatime.Value.ToString());
        news.Click = Int32.Parse(Click.Text.ToString());
        NewClassSystem newClassSystem = new NewClassSystem();
        news.NewClass = newClassSystem.Get_SintNewClass(Int32.Parse(ClassID.SelectedValue));
        NewsSystem newsSystem = new NewsSystem();
        newsSystem.Update_News(news);
        Response.Write("<script>alert('修改成功');location.href='Get_News.aspx';</script>");
    }
}
