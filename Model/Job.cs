using System;
using System.Data;
using System.Configuration;
using System.Web;

/// <summary>
/// Job 的摘要说明
/// </summary>
namespace Model
{
    public class Job
    {
        #region Model
        private int _ID;
        private string _Title;
        private string _Content;
        private DateTime _Updatatime;
        private int _Click;
        /// <summary>
        /// 人才招聘ID
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
        /// 人才招聘标题
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
        /// 人才招聘内容
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
