using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Text;
using System.Collections.Generic;
using DAL;
using Model;
/// <summary>
/// AdminSystem 的摘要说明
/// </summary>
namespace BLL
{
    public class AdminSystem
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public int Add_Admin(Admin admin)
        {
            AdminSQL adminSQL = new AdminSQL();
            return (adminSQL.Add_Admin(admin));
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="admin"></param>
        public void Update_Admin(Admin admin)
        {
            AdminSQL adminSQL = new AdminSQL();
            adminSQL.Update_Admin(admin);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="nID"></param>
        public void Delete_Admin(int nID)
        {
            AdminSQL adminSQL = new AdminSQL();
            adminSQL.Delete_Admin(nID);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns></returns>
        public List<Admin> Get_Admin()
        {
            AdminSQL adminSQL = new AdminSQL();
            return (adminSQL.Get_Admin());
        }
        /// <summary>
        /// 查看单个
        /// </summary>
        /// <param name="nID"></param>
        /// <returns></returns>
        public Admin Get_SingAdmin(string sUserName)
        {
            AdminSQL adminSQL = new AdminSQL();
            return (adminSQL.Get_SingAdmin(sUserName));
        }
        /// <summary>
        /// 查看用户是否存在
        /// </summary>
        /// <param name="sUserName"></param>
        /// <returns></returns>
        public bool Login_Admin(string sUserName)
        {
            AdminSQL adminSQL = new AdminSQL();
            return (adminSQL.Login_Admin(sUserName));
        }
    }
}
