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

public partial class Contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Title = "科技有限公司";
        if (!IsPostBack)
        {
            BinData();
        }
    }
    public void BinData()
    {
        Model.Config config = new Model.Config();
        ConfigSystem configSystem = new ConfigSystem();
        config = configSystem.Get_Config();
        Content.Text = config.Contact;
    }
}
