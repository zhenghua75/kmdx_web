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
public partial class admin_login : System.Web.UI.Page
{
    static string sValidator = "";
    private readonly string sValidatorImageUrl = "ValidateImage.aspx?Validator=";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            sValidator = GetRandomint();
            ValidateImage.ImageUrl = sValidatorImageUrl + sValidator;
        }
    }

    private String GetRandomint()
    {
        Random random = new Random();
        return (random.Next(100000, 999999).ToString());
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (Page.IsValid)
        {
            if (sValidator == Code.Text.ToString())
            {
                AdminSystem adminSystem = new AdminSystem();
                Admin admin = new Admin();
                admin=adminSystem.Get_SingAdmin(UserName.Text.ToString());                
                if (admin.UserName==UserName.Text.ToString())
                {
                    if(FormsAuthentication.HashPasswordForStoringInConfigFile(PassWord.Text.ToString(),"MD5")==admin.Password.ToString())
                    {
                        Session["Admin_User"] = UserName.Text.ToString();
                        Response.Redirect("Default.aspx", false);
                    }
                    else
                    {
                        Response.Write("<script>alert('管理员密码错误');location.href='login.aspx';</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('管理员不存在');location.href='login.aspx';</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('验证码错误');location.href='login.aspx';</script>");
            }
        }
    }
    

}
