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

public partial class admin_Add_ProductClass : System.Web.UI.Page
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
            ProductClass productClass = new ProductClass();
            productClass.ClassName = ClassName.Text.ToString();
            productClass.ParentID = 0;
            ProductClassSystem productClassSystem = new ProductClassSystem();
            if (productClassSystem.Add_ProductClass(productClass) > 0)
            {
                Response.Write("<script>alert('添加成功');location.href='Get_ProductClass.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('添加失败');history.back(1);</script>");
            }
        }
    }
}
