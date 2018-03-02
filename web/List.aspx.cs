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

public partial class List : System.Web.UI.Page
{
    int nID = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        Title = "科技有限公司";
        if (!Page.IsPostBack)
        {
            if (Request.Params["ID"]!=null)
            {
                nID = Int32.Parse(Request.Params["ID"].ToString());
                if (nID > 0)
                {
                    BinData();
                }
                else
                {
                    Response.Write("<script>alert('请选择数据');history.back(1);</script>");
                    Response.End();
                }
            }
            else
            {
                Response.Write("<script>alert('请选择数据');history.back(1);</script>");
                Response.End();
            }
        }
    }

    public void BinData()
    {
        Product product = new Product();
        ProductSystem productSystem = new ProductSystem();
        product = productSystem.Get_SingProduct(nID);
        Image1.ImageUrl = "UploadFiles/" + product.Pic;
        Pro_Name.Text = product.Pro_Name;
        Content.Text = product.Content;
        ClassName.Text = "&gt;" + product.productClass.ClassName;
        Pro_Name1.Text = "&gt;"+product.Pro_Name;
    }
}
