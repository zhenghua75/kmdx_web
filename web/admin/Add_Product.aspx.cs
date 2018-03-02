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

public partial class admin_Add_Product : System.Web.UI.Page
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
            if (!IsPostBack)
            {
                BinData();
            }
        }
    }
    public void BinData()
    {
        List<ProductClass> List_ProductClass = new List<ProductClass>();
        ProductClassSystem productClassSystem = new ProductClassSystem();
        List_ProductClass = productClassSystem.Get_ProductClass(0);
        ClassID.DataSource = List_ProductClass;
        ClassID.DataTextField = "ClassName";
        ClassID.DataValueField = "ClassID";
        ClassID.DataBind();
    }
    protected void Add_Btn_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            string savePath = @"../UploadFiles/";
            string savePath1 = @"../UploadFiles/smaill/";
            string fileName = Server.HtmlEncode(FileUpload1.FileName);
            string extension = System.IO.Path.GetExtension(fileName);
            string ImageName = null;
            if ((extension == ".jpg") | (extension == ".gif"))
            {
                ImageName = DateTime.Now.ToString("yyyyMMddhhmmssfff") + extension;
                savePath += ImageName;
                savePath1 += ImageName;
                savePath = Server.MapPath(savePath);
                savePath1 = Server.MapPath(savePath1);
                FileUpload1.SaveAs(savePath);
                //生成小图
                ImageClass.ImageClass imageClass = new ImageClass.ImageClass();
                imageClass.ShowThumbnail(savePath, savePath1,200,153);
            }
            else
            {
                Response.Write("<script>alert('文件上传格式错误');history.back(1);</script>");
                Response.End();
            }
            Product product = new Product();
            ProductClassSystem productClassSystem = new ProductClassSystem();
            product.productClass = productClassSystem.Get_SingProductClass(Int32.Parse(ClassID.SelectedValue));
            product.Pro_Name = Pro_Name.Text.ToString();
            product.Pic = ImageName;
            product.Click = Int32.Parse(Click.Text.ToString());
            product.Content = Content.Value.ToString();
            product.Updatatime = DateTime.Now;
            ProductSystem productSystem = new ProductSystem();
            if (productSystem.Add_Product(product) > 0)
            {
                Response.Write("<script>alert('添加成功');location.href='Get_Product.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('添加失败');history.back(1);</script>");
            }
        }
    }
}
