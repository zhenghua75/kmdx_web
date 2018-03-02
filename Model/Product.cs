using System;
using System.Data;
using System.Configuration;
using System.Web;

/// <summary>
/// Product 的摘要说明
/// </summary>
namespace Model
{
    public class Product
    {
        #region Model
        private int _ID;
        private Model.ProductClass _productClass;
        private string _Pro_Name;
        private string _Pic;
        private string _Content;
        private DateTime _Updatatime;
        private int _Click;
        /// <summary>
        /// 产品ID
        /// </summary>
        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }
        /// <summary>
        /// 产品分类
        /// </summary>
        public Model.ProductClass productClass
        {
            get
            {
                return _productClass;
            }
            set
            {
                _productClass = value;
            }
        }
        /// <summary>
        /// 产品名称
        /// </summary>
        public string Pro_Name
        {
            get
            {
                return _Pro_Name;
            }
            set
            {
                _Pro_Name = value;
            }
        }
        /// <summary>
        /// 产品图片
        /// </summary>
        public string Pic
        {
            get
            {
                return _Pic;
            }
            set
            {
                _Pic = value;
            }
        }
        /// <summary>
        /// 产品描术
        /// </summary>
        public string Content
        {
            get
            {
                return _Content;
            }
            set
            {
                _Content = value;
            }
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime Updatatime
        {
            get
            {
                return _Updatatime;
            }
            set
            {
                _Updatatime = value;
            }
        }
        /// <summary>
        /// 访问量
        /// </summary>
        public int Click
        {
            get
            {
                return _Click;
            }
            set
            {
                _Click = value;
            }
        }
        #endregion Model
    }
}
