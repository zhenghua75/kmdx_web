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


public partial class admin_Add_Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Admin_User"] == null)
        {
            Response.Redirect("login.aspx");
            Response.End();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            Admin admin = new Admin();
            admin.UserName = UserName.Text.ToString();
            admin.Password = FormsAuthentication.HashPasswordForStoringInConfigFile(Password.Text.ToString(), "MD5");
            admin.LastLoginIP = Request.UserHostAddress;
            admin.LastLoginTime = DateTime.Now;
            AdminSystem adminSystem = new AdminSystem();
            if (!adminSystem.Login_Admin(admin.UserName))
            {
                if (adminSystem.Add_Admin(admin) > 0)
                {
                    Response.Write("<script>alert('添加成功');location.href='Get_admin.aspx';</script>");
                }
                else
                {
                    Response.Write("<script>alert('添加失败');location.href='Get_admin.aspx';</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('管理员已存在');history.back(1);</script>");
            }            
        }
    }
}
