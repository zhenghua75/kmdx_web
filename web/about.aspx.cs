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

public partial class about : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Title = "科技有限公司";
        if (!Page.IsPostBack)
        {
            BinData();
        }
    }
    public void BinData()
    {
        Config config = new Config();
        ConfigSystem configSystem = new ConfigSystem();
        config = configSystem.Get_Config();
        Abouts.Text = config.About;
    }
}
