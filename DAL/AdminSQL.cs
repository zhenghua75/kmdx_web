using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Text;
using System.Collections.Generic;
using System.Data.SqlClient;
using SQLHelper;
using Model;
/// <summary>
/// AdminSQL 的摘要说明
/// </summary>
namespace DAL
{
    public class AdminSQL
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public int Add_Admin(Admin admin)
        {
             SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
             SqlParameter[] ParamList ={ 
                 sqlHelper.CreateInParam("@UserName",SqlDbType.NVarChar,50,admin.UserName),
                 sqlHelper.CreateInParam("@Password",SqlDbType.NVarChar,50,admin.Password),
                 sqlHelper.CreateInParam("@LastLoginIP",SqlDbType.NVarChar,50,admin.LastLoginIP),
                 sqlHelper.CreateInParam("@LastLoginTime",SqlDbType.DateTime,8,admin.LastLoginTime)
             };
             try
             {
                 return(sqlHelper.RunProc("Add_Admin", ParamList));
             }
             catch (Exception ex)
             {
                 SystemError.CreateErrorLog(ex.Message);
                 throw new Exception(ex.Message, ex);
             }
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="admin"></param>
        public void Update_Admin(Admin admin)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ 
                 sqlHelper.CreateInParam("@ID",SqlDbType.Int,4,admin.ID),
                 sqlHelper.CreateInParam("@UserName",SqlDbType.NVarChar,50,admin.UserName),
                 sqlHelper.CreateInParam("@Password",SqlDbType.NVarChar,50,admin.Password),
                 sqlHelper.CreateInParam("@LastLoginIP",SqlDbType.NVarChar,50,admin.LastLoginIP),
                 sqlHelper.CreateInParam("@LastLoginTime",SqlDbType.DateTime,8,admin.LastLoginTime)
             };
            try
            {
                sqlHelper.RunProc("Update_Admin", ParamList);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="nID"></param>
        public void Delete_Admin(int nID)
        {
             SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
             SqlParameter[] ParamList ={ sqlHelper.CreateInParam("@ID",SqlDbType.Int,4,nID)};
             try
             {
                 sqlHelper.RunProc("Delete_Admin", ParamList);
             }
             catch (Exception ex)
             {
                 SystemError.CreateErrorLog(ex.Message);
                 throw new Exception(ex.Message, ex);
             }
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns></returns>
        public List<Admin> Get_Admin()
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlDataReader rec = null;
            try
            {
                sqlHelper.RunProc("Get_Admin", out rec);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
            List<Admin> List_Admin = new List<Admin>();
            while (rec.Read())
            {
                Admin admin = new Admin();
                admin.ID = Int32.Parse(rec["ID"].ToString());
                admin.UserName = rec["UserName"].ToString();
                admin.Password = rec["Password"].ToString();
                admin.LastLoginIP = rec["LastLoginIP"].ToString();
                admin.LastLoginTime = DateTime.Parse(rec["LastLoginTime"].ToString());
                List_Admin.Add(admin);
                admin = null;
            }
            return List_Admin;
        }
        /// <summary>
        /// 查看单个
        /// </summary>
        /// <param name="nID"></param>
        /// <returns></returns>
        public Admin Get_SingAdmin(string sUserName)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ sqlHelper.CreateInParam("@UserName", SqlDbType.NVarChar,50,sUserName) };
            SqlDataReader rec = null;
            try
            {
                sqlHelper.RunProc("Get_SingAdmin", ParamList, out rec);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
            Admin admin = new Admin();
            while (rec.Read())
            {
                admin.ID = Int32.Parse(rec["ID"].ToString());
                admin.UserName = rec["UserName"].ToString();
                admin.Password = rec["Password"].ToString();
                admin.LastLoginIP = rec["LastLoginIP"].ToString();
                admin.LastLoginTime = DateTime.Parse(rec["LastLoginTime"].ToString());
            }
            return admin;
        }
        /// <summary>
        /// 用户是否存在
        /// </summary>
        /// <param name="sUserName"></param>
        /// <returns></returns>
        public bool Login_Admin(string sUserName)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ sqlHelper.CreateInParam("@UserName", SqlDbType.NVarChar, 50, sUserName) };
            SqlDataReader rec = null;
            try
            {
                sqlHelper.RunProc("Login_Admin", ParamList, out rec);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
            bool Bool = false;
            while (rec.Read())
            {
                if (sUserName == rec["UserName"].ToString())
                {
                    Bool = true;
                }
            }
            return Bool;
        }
    }
}
