using System;
using System.Data;
using System.Configuration;
using System.Web;

/// <summary>
/// News 的摘要说明
/// </summary>
namespace Model
{
    public class News
    {
        #region Model
        private int _ID;
        private NewClass _NewClass;
        private string _Title;
        private string _Source;
        private string _Author;
        private string _Content;
        private DateTime _Updatatime;
        private int _Click;
        /// <summary>
        /// 新闻ID
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
        /// 新闻分类ID
        /// </summary>
        public NewClass NewClass
        {
            get
            {
                return _NewClass;
            }
            set
            {
                _NewClass = value;
            }
        }

        /// <summary>
        /// 新闻标题
        /// </summary>
        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
            }
        }
        /// <summary>
        /// 新闻来源
        /// </summary>
        public string Source
        {
            get
            {
                return _Source;
            }
            set
            {
                _Source = value;
            }
        }
        /// <summary>
        /// 新闻作者
        /// </summary>
        public string Author
        {
            get
            {
                return _Author;
            }
            set
            {
                _Author = value;
            }
        }
        /// <summary>
        /// 新闻内容
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
        /// 新闻添加时间
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
