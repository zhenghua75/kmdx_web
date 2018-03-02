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

public partial class admin_Update_NewClass : System.Web.UI.Page
{
    int nClassID = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Admin_User"] == null)
        {
            Response.Redirect("login.aspx");
            Response.End();
        }
        else
        {
            if (Request.Params["ClassID"] != null)
            {
                if (!IsPostBack)
                {
                    nClassID = Int32.Parse(Request.Params["ClassID"].ToString());
                    if (nClassID > 0)
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
            else
            {
                Response.Write("<script>alert('请选择要修改的数据');history.back(1);</script>");
                Response.End();
            }
        }
    }

    public void BinData()
    {
        NewClass newClass = new NewClass();
        NewClassSystem newClassSystem = new NewClassSystem();
        newClass = newClassSystem.Get_SintNewClass(nClassID);
        ClassID.Value = newClass.ClassID.ToString();
        ClassName.Text = newClass.ClassName.ToString();
        ParentID.Value = newClass.ParentID.ToString();
    }
    protected void Update_Btn_Click(object sender, EventArgs e)
    {
        NewClass newClass = new NewClass();
        newClass.ClassID = Int32.Parse(ClassID.Value.ToString());
        newClass.ClassName = ClassName.Text.ToString();
        newClass.ParentID = Int32.Parse(ParentID.Value.ToString());
        NewClassSystem newClassSystem = new NewClassSystem();
        newClassSystem.Update_NewClass(newClass);
        Response.Write("<script>alert('修改成功');location.href='Get_NewClass.aspx';</script>");
    }
}
