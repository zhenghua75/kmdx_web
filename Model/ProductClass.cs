using System;
using System.Data;
using System.Configuration;
using System.Web;

/// <summary>
/// ProductClass 的摘要说明
/// </summary>
namespace Model
{
    public class ProductClass
    {
        #region Model
        private int _ClassID;
        private int _ParentID;
        private string _ClassName;
        private int _ParentOrder;
        /// <summary>
        /// 商品分类ID
        /// </summary>
        public int ClassID
        {
            get
            {
                return _ClassID;
            }
            set
            {
                _ClassID = value;
            }
        }
        /// <summary>
        /// 上级分类
        /// </summary>
        public int ParentID
        {
            get
            {
                return _ParentID;
            }
            set
            {
                _ParentID = value;
            }
        }
        /// <summary>
        /// 分类名
        /// </summary>
        public string ClassName
        {
            get
            {
                return _ClassName;
            }
            set
            {
                _ClassName = value;
            }
        }
        /// <summary>
        /// 排序ID
        /// </summary>
        public int ParentOrder
        {
            get
            {
                return _ParentOrder;
            }
            set
            {
                _ParentOrder = value;
            }
        }
        #endregion Model
    }
}
