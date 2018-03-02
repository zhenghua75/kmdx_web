using System;
using System.Data;
using System.Configuration;
using System.Web;

/// <summary>
/// config 的摘要说明
/// </summary>
namespace Model
{
    public class Config
    {
        #region Model
        private string _About;
        private string _Contact;
        /// <summary>
        /// 公司简介
        /// </summary>
        public string About
        {
            get
            {
                return _About;
            }
            set
            {
                _About = value;
            }
        }
        /// <summary>
        /// 联系我们
        /// </summary>
        public string Contact
        {
            get
            {
                return _Contact;
            }
            set
            {
                _Contact = value;
            }
        }
        #endregion Model
    }
}
