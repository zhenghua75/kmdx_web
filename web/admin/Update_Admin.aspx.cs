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

public partial class admin_Update_Admin : System.Web.UI.Page
{
    string sUserName = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Admin_User"] == null)
        {
            Response.Redirect("login.aspx");
            Response.End();
        }
        else
        {
            if (Request.Params["UserName"] != null)
            {
                    sUserName = Request.Params["UserName"].ToString();
            }
            if (!Page.IsPostBack)
            {
                if (sUserName != null && sUserName!="")
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
    }

    public void BinData()
    {
        AdminSystem adminSystem = new AdminSystem();
        Admin admin = new Admin();
        admin = adminSystem.Get_SingAdmin(sUserName);
        ID.Value = admin.ID.ToString();
        UserName.Text = admin.UserName;
        LastLoginIP.Value = admin.LastLoginIP;
        LastLoginTime.Value = admin.LastLoginTime.ToString();
    }
    protected void UpdateBtn_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            Admin admin = new Admin();
            admin.ID = Int32.Parse(ID.Value.ToString());
            admin.UserName = UserName.Text.ToString();
            admin.Password = FormsAuthentication.HashPasswordForStoringInConfigFile(Password.Text.ToString(), "MD5");
            admin.LastLoginIP = LastLoginIP.Value.ToString();
            admin.LastLoginTime = DateTime.Parse(LastLoginTime.Value.ToString());
            AdminSystem adminSystem = new AdminSystem();
            adminSystem.Update_Admin(admin);
            Response.Write("<script>alert('修改成功');location.href='Get_admin.aspx';</script>");
        }
    }
}
