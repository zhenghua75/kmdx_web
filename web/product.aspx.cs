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
public partial class product : System.Web.UI.Page
{
    int nClassID = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        Title = "科技有限公司";        
        if (!Page.IsPostBack)
        {            
            ProductSystem productSystem = new ProductSystem();
            ProductClassSystem productClassSystem = new ProductClassSystem();
            if (Request.Params["ClassID"] != null)
            {
                nClassID = Int32.Parse(Request.Params["ClassID"].ToString());
            }
            if (nClassID > 0)
            {
                AspNetPager1.RecordCount = productSystem.Get_ProductNum(nClassID);
                ClassName.Text = "&gt;"+ productClassSystem.Get_SingProductClass(nClassID).ClassName.ToString();
            }
            else
            {
                AspNetPager1.RecordCount = productSystem.Get_ProductNum();
            }
        }
    }    
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        BinData();
    }

    public void BinData()
    {
        ProductSystem productSystme = new ProductSystem();
        if (nClassID > 0)
        {
            List_Product.DataSource = productSystme.Get_Product(AspNetPager1.StartRecordIndex, AspNetPager1.EndRecordIndex, nClassID);
        }
        else
        {
            List_Product.DataSource = productSystme.Get_Product(AspNetPager1.StartRecordIndex, AspNetPager1.EndRecordIndex);
        }
        List_Product.DataBind();
    }
    
}
