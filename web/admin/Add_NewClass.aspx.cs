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
public partial class admin_Add_NewClass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Admin_User"] == null)
        {
            Response.Redirect("login.aspx");
            Response.End();
        }
    }
    protected void Add_Btn_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            NewClass newClass = new NewClass();
            newClass.ClassName = ClassName.Text.ToString();
            newClass.ParentID = 0;
            NewClassSystem newClassSystem = new NewClassSystem();
            if (newClassSystem.Add_NewClass(newClass) > 0)
            {
                Response.Write("<script>alert('添加成功');location.href='Get_NewClass.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('添加失败');history.back(1);</script>");
            }
        }
    }
}
