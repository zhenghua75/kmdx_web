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

public partial class Article : System.Web.UI.Page
{
    int nID = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["ID"] != null)
        {
            Title = "科技有限公司";
            nID = Int32.Parse(Request.Params["ID"].ToString());
            if (!Page.IsPostBack)
            {
                if (nID > 0)
                {
                    BinData();
                }
                else
                {
                    Response.Write("<script>alert('请选择数据');history.back(1);</script>");
                    Response.End();
                }
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
        Model.News news = new Model.News();
        NewsSystem newsSystem = new NewsSystem();
        news = newsSystem.Get_SintNews(nID);
        if (news.ID == nID)
        {
            ClassName.Text = "&gt;"+news.NewClass.ClassName;
            Title_1.Text = "&gt;"+news.Title;
            Title_2.Text = news.Title;
            Updatatime.Text = news.Updatatime.ToString();
            Author.Text = news.Author;
            Source.Text = news.Source;
            Content.Text = news.Content;
        }
        else
        {
            Response.Write("<script>alert('数据不存在');history.back(1);</script>");
            Response.End();
        }
    }
}
