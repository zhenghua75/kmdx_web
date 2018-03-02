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

public partial class admin_Get_Product : System.Web.UI.Page
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
            ProductSystem productSystem = new ProductSystem();
            AspNetPager1.RecordCount = productSystem.Get_ProductNum();           
        }
    }

    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        BinData();
    }

    public void BinData()
    {
        List<Product> List_Product = new List<Product>();
        ProductSystem productSystem = new ProductSystem();
        List_Product = productSystem.Get_Product(AspNetPager1.StartRecordIndex, AspNetPager1.EndRecordIndex);
        Product_List.DataSource = List_Product;
        Product_List.DataBind();        
    }

    protected void Product_List_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int nID = Int32.Parse(Product_List.DataKeys[e.RowIndex].Value.ToString());
        ProductSystem productSystem = new ProductSystem();
        productSystem.Delete_Product(nID);
        BinData();
    }
}
