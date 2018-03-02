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

public partial class admin_Get_ProductClass : System.Web.UI.Page
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
        List<ProductClass> List_productClass = new List<ProductClass>();
        ProductClassSystem productClassSystem = new ProductClassSystem();
        List_productClass = productClassSystem.Get_ProductClass(0);
        ProductClass_List.DataSource = List_productClass;
        ProductClass_List.DataBind();
    }

    protected void ProductClass_List_RowDeleting(object sender,GridViewDeleteEventArgs e)
    {
        int nClassID = Int32.Parse(ProductClass_List.DataKeys[e.RowIndex].Value.ToString());
        ProductClassSystem productClassSystem = new ProductClassSystem();
        productClassSystem.Delete_ProductClass(nClassID);
        BinData();
    }
}
