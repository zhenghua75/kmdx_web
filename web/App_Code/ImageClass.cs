using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
/// <summary>
/// ImageClass 的摘要说明
/// </summary>
namespace ImageClass
{
    public class ImageClass
    {
        public bool ThumbnailCallback()
        {
            return false;
        }
        public  void ShowThumbnail(string oldfile, string newfile,int white,int height)
        {
            System.Drawing.Image image = System.Drawing.Image.FromFile(oldfile);
            //获取原图高度和宽度
            int oldh = image.Height;
            int oldw = image.Width;
            int neww, newh;
            neww = white; newh = height;   //直接设定新图的高宽,,

            try
            {
                System.Drawing.Image.GetThumbnailImageAbort callb = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);
                System.Drawing.Image bt = new System.Drawing.Bitmap(neww, newh);
                System.Drawing.Graphics gr = System.Drawing.Graphics.FromImage(bt);
                gr.Clear(Color.White);
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                gr.DrawImage(image, new Rectangle(0, 0, neww, newh), 0, 0, oldw, oldh, GraphicsUnit.Pixel);
                switch (oldfile.Substring(oldfile.Length - 3).ToUpper())
                {
                    case "JPG":
                        bt.Save(newfile, ImageFormat.Jpeg);
                        break;
                    case "GIF":
                        bt.Save(newfile, ImageFormat.Gif);
                        break;
                    case "PNG":
                        bt.Save(newfile, ImageFormat.Png);
                        break;
                    default:
                        bt.Save(newfile, ImageFormat.Jpeg);
                        break;
                }
                gr.Dispose();
                bt.Dispose();
                image.Dispose();
            }
            catch { }

        }
    }
}
