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

public partial class admin_Update_Product : System.Web.UI.Page
{
    int nID = 0;
    protected void Page_Load(object sender, EventArgs e)
    {         
        if (Session["Admin_User"] == null)
        {
            Response.Redirect("login.aspx");
            Response.End();
        }
        else
        {
            if (Request.Params["ID"] != null)
            {
                if (!IsPostBack)
                {
                    nID = Int32.Parse(Request.Params["ID"].ToString());
                    if (nID > 0)
                    {
                        BinClassData();
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

    public void BinClassData()
    {
        ProductClassSystem productClass = new ProductClassSystem();
        ClassID.DataSource = productClass.Get_ProductClass(0);
        ClassID.DataTextField = "ClassName";
        ClassID.DataValueField = "ClassID";
        ClassID.DataBind();
    }
    public void BinData()
    {
        Product product = new Product();
        ProductSystem productSystem = new ProductSystem();
        product = productSystem.Get_SingProduct(nID);
        ID.Value = product.ID.ToString();
        Pro_Name.Text = product.Pro_Name;
        Click.Text = product.Click.ToString();
        Pic.Value = product.Pic;
        Updatatime.Value = product.Updatatime.ToString();
        Content.Value = product.Content;
        i180cn.i180cn.SetListBoxItem(ClassID, product.productClass.ClassID.ToString());        
    }
    

    protected void Update_Btn_Click(object sender, EventArgs e)
    {
        string sPic = Pic.Value.ToString();
        if (FileUpload1.HasFile)
        {
            string savePath = @"../UploadFiles/";
            string savePath1 = @"../UploadFiles/smaill/";
            string savePath3 = @"../UploadFiles/";
            string savePath4 = @"../UploadFiles/smaill/";
            string fileName = Server.HtmlEncode(FileUpload1.FileName);
            string extension = System.IO.Path.GetExtension(fileName);
            string ImageName = null;
            if ((extension == ".jpg") | (extension == ".gif"))
            {
                ImageName = DateTime.Now.ToString("yyyyMMddhhmmssfff") + extension;
                savePath += ImageName;
                savePath1 += ImageName;
                savePath3 += sPic;
                savePath4 += sPic;               
                savePath = Server.MapPath(savePath);
                savePath1 = Server.MapPath(savePath1);
                savePath3 = Server.MapPath(savePath3);
                savePath4 = Server.MapPath(savePath4);                
                FileUpload1.SaveAs(savePath);
                //生成小图
                ImageClass.ImageClass imageClass = new ImageClass.ImageClass();
                imageClass.ShowThumbnail(savePath, savePath1, 200, 153);           
                sPic = ImageName;
                //删除旧图片
                i180cn.i180cn.FilePicDelete(savePath3);
                i180cn.i180cn.FilePicDelete(savePath4);
            }
            else
            {
                Response.Write("<script>alert('文件上传格式错误');history.back(1);</script>");
                Response.End();
            }
        }
        Product product = new Product();
        ProductSystem productSystem = new ProductSystem();
        product.ID = Int32.Parse(ID.Value.ToString());
        product.Pro_Name = Pro_Name.Text.ToString();
        product.Pic = sPic;
        product.Updatatime = DateTime.Parse(Updatatime.Value.ToString());
        product.Click = Int32.Parse(Click.Text.ToString());
        product.Content = Content.Value;
        ProductClassSystem productClassSystem = new ProductClassSystem();
        product.productClass = productClassSystem.Get_SingProductClass(Int32.Parse(ClassID.SelectedValue));
        productSystem.Update_Product(product);
        Response.Write("<script>alert('修改成功');location.href='Get_product.aspx';</script>");
    }
}
