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
public partial class admin_about : System.Web.UI.Page
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
                BinData();
            }
        }
    }
    public void BinData()
    {
        Config config = new Config();
        ConfigSystem configSystem = new ConfigSystem();
        config = configSystem.Get_Config();
        About.Value = config.About;
        Contact.Value = config.Contact;
    }
    protected void Update_Btn_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            Config config = new Config();
            config.About = About.Value.ToString();
            config.Contact = Contact.Value.ToString();
            ConfigSystem configSystem = new ConfigSystem();
            configSystem.Update_Config(config);
            Response.Write("<script>alert('修改成功');location.href='about.aspx';</script>");
        }
    }
}
