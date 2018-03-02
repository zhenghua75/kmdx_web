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

public partial class News : System.Web.UI.Page
{
    int nClassID = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        Title = "科技有限公司";
        if (Request.Params["ClassID"] != null)
        {
            nClassID = Int32.Parse(Request.Params["ClassID"].ToString());
        }
        if (!Page.IsPostBack)
        {
            NewsSystem newsSystem = new NewsSystem();
            if (nClassID > 0)
            {
                AspNetPager1.RecordCount = newsSystem.Get_NewsNum(nClassID);
                NewClassSystem newClassSystem = new NewClassSystem();
                ClassName.Text = "&gt;"+newClassSystem.Get_SintNewClass(nClassID).ClassName;
            }
            else
            {
                AspNetPager1.RecordCount = newsSystem.Get_NewsNum();
            }
        }               
    }

    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        BinData();
    }
    public void BinData()
    {
        NewsSystem newsSystem = new NewsSystem();
        if (nClassID > 0)
        {
            List_News.DataSource = newsSystem.Get_News(AspNetPager1.StartRecordIndex, AspNetPager1.EndRecordIndex,nClassID);
        }
        else
        {
            List_News.DataSource = newsSystem.Get_News(AspNetPager1.StartRecordIndex, AspNetPager1.EndRecordIndex);
        }
        List_News.DataBind();
    }
}
