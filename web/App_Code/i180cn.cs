using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


/// <summary>
/// i180cn 的摘要说明
/// </summary>
namespace i180cn
{
    public class i180cn
    {
        public static void SetListBoxItem(ListBox listBox, string sItemValue)
        {
            int index = 0;
            foreach (ListItem item in listBox.Items)
            {
                ///判断值是否相等，并且设置控件的SelectedIndex
                if (item.Value.ToLower() == sItemValue.ToLower())
                {
                    listBox.SelectedIndex = index;
                    break;
                }
                index++;
            }
        }

        public static void SetListBoxItem(DropDownList listBox, string sItemValue)
        {
            int index = 0;
            foreach (ListItem item in listBox.Items)
            {
                ///判断值是否相等，并且设置控件的SelectedIndex
                if (item.Value.ToLower() == sItemValue.ToLower())
                {
                    listBox.SelectedIndex = index;
                    break;
                }
                index++;
            }
        }

        /// 删除文件文件或图片
        /// </summary>
        /// <param name="path">当前文件的路径</param>
        /// <returns>是否删除成功</returns>
        public static void FilePicDelete(string path)
        {            
            System.IO.FileInfo file = new System.IO.FileInfo(path);
            if (file.Exists)
            {
                file.Delete();                
            }            
        }
    }
}
