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
/// NewClassSQL 的摘要说明
/// </summary>
namespace DAL
{
    public class NewClassSQL
    {
        /// <summary>
        /// 添加新闻分类
        /// </summary>
        /// <param name="newClass"></param>
        /// <returns></returns>
        public int Add_NewClass(NewClass newClass)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ 
                sqlHelper.CreateInParam("@ParentID",SqlDbType.Int,4,newClass.ParentID),
                sqlHelper.CreateInParam("@ClassName",SqlDbType.NVarChar,50,newClass.ClassName)                
            };
            try
            {
                return(sqlHelper.RunProc("Add_NewClass",ParamList));
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>
        /// 修改新闻分类
        /// </summary>
        /// <param name="newClass"></param>
        public void Update_NewClass(NewClass newClass)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ 
                sqlHelper.CreateInParam("@Classid",SqlDbType.Int,4,newClass.ClassID),
                sqlHelper.CreateInParam("@ParentID",SqlDbType.Int,4,newClass.ParentID),
                sqlHelper.CreateInParam("@ClassName",SqlDbType.NVarChar,50,newClass.ClassName)  
            };
            try
            {
                sqlHelper.RunProc("Update_NewClass", ParamList);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>
        /// 删除新闻分类
        /// </summary>
        /// <param name="nClassid"></param>
        public void Delete_NewClass(int nClassid)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ 
                sqlHelper.CreateInParam("@Classid",SqlDbType.Int,4,nClassid)
            };
            try
            {
                sqlHelper.RunProc("Delete_NewClass", ParamList);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>
        /// 查看全部分类
        /// </summary>
        /// <param name="nClassID"></param>
        /// <returns></returns>
        public List<NewClass> Get_NewClass(int nParentID)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ 
                sqlHelper.CreateInParam("@ParentID",SqlDbType.Int,4,nParentID)
            };
            SqlDataReader rec = null;
            try
            {
                sqlHelper.RunProc("Get_NewClass", ParamList, out rec);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
            List<NewClass> List_NewClass = new List<NewClass>();
            while (rec.Read())
            {
                NewClass newClass = new NewClass();
                newClass.ClassID = Int32.Parse(rec["ClassID"].ToString());
                newClass.ClassName = rec["ClassName"].ToString();
                newClass.ParentID = Int32.Parse(rec["ParentID"].ToString());
                newClass.ParentOrder = Int32.Parse(rec["ParentOrder"].ToString());
                List_NewClass.Add(newClass);
                newClass = null;
            }
            return List_NewClass;
        }
        /// <summary>
        /// 查看单个
        /// </summary>
        /// <param name="nClassid"></param>
        /// <returns></returns>
        public NewClass Get_SintNewClass(int nClassid)
        {
             SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
             SqlParameter[] ParamList ={ 
                sqlHelper.CreateInParam("@Classid",SqlDbType.Int,4,nClassid)
             };
             SqlDataReader rec =null;
             try
             {
                 sqlHelper.RunProc("Get_SintNewClass", ParamList, out rec);
             }
             catch (Exception ex)
             {
                 SystemError.CreateErrorLog(ex.Message);
                 throw new Exception(ex.Message, ex);
             }
             NewClass newClass = new NewClass();
             while (rec.Read())
             {
                 newClass.ClassID = Int32.Parse(rec["ClassID"].ToString());
                 newClass.ClassName = rec["ClassName"].ToString();
                 newClass.ParentID = Int32.Parse(rec["ParentID"].ToString());
                 newClass.ParentOrder = Int32.Parse(rec["ParentOrder"].ToString());
             }
             return newClass;
        }
    }
}
