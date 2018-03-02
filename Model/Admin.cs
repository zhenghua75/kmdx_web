using System;
using System.Data;
using System.Configuration;
using System.Web;
/// <summary>
/// Admin 的摘要说明
/// </summary>
namespace Model
{
    public class Admin
    {
        #region Model
        private int _ID;
        private string _UserName;
        private string _Password;
        private string _LastLoginIP;
        private DateTime _LastLoginTime;
        /// <summary>
        /// 管理员ID
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
        /// 管理员名称
        /// </summary>
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }
        /// <summary>
        /// 管理员密码
        /// </summary>
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }
        /// <summary>
        /// 最后登录IP
        /// </summary>
        public string LastLoginIP
        {
            get
            {
                return _LastLoginIP;
            }
            set
            {
                _LastLoginIP = value;
            }
        }
        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTime LastLoginTime
        {
            get
            {
                return _LastLoginTime;
            }
            set
            {
                _LastLoginTime = value;
            }
        }
        #endregion Model
    }
}
