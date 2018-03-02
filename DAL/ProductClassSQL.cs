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
/// ProductClassSQL 的摘要说明
/// </summary>
namespace DAL
{
    public class ProductClassSQL
    {
        /// <summary>
        /// 添加产品分类
        /// </summary>
        /// <param name="productClass"></param>
        /// <returns></returns>
        public int Add_ProductClass(ProductClass productClass)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ 
            sqlHelper.CreateInParam("@ParentID",SqlDbType.Int,4,productClass.ParentID),
            sqlHelper.CreateInParam("@ClassName",SqlDbType.NVarChar,50,productClass.ClassName)
        };
            try
            {
                return (sqlHelper.RunProc("Add_ProductClass", ParamList));
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>
        /// 修改分类
        /// </summary>
        /// <param name="productClass"></param>
        public void Update_ProductClass(ProductClass productClass)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ 
            sqlHelper.CreateInParam("@ClassID",SqlDbType.Int,4,productClass.ClassID),
            sqlHelper.CreateInParam("@ParentID",SqlDbType.Int,4,productClass.ParentID),
            sqlHelper.CreateInParam("@ClassName",SqlDbType.NVarChar,50,productClass.ClassName)
        };
            try
            {
                sqlHelper.RunProc("Update_ProductClass", ParamList);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>
        /// 删除商品分类
        /// </summary>
        /// <param name="nClassID"></param>
        public void Delete_ProductClass(int nClassID)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ 
            sqlHelper.CreateInParam("@Classid",SqlDbType.Int,4,nClassID)
        };
            try
            {
                sqlHelper.RunProc("Delete_ProductClass", ParamList);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>
        /// 查看分类
        /// </summary>
        /// <param name="nParentID"></param>
        /// <returns></returns>
        public List<ProductClass> Get_ProductClass(int nParentID)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ 
            sqlHelper.CreateInParam("@ParentID",SqlDbType.Int,4,nParentID)
        };
            SqlDataReader rec = null;
            try
            {
                sqlHelper.RunProc("Get_ProductClass", ParamList, out rec);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
            List<ProductClass> List_ProductClass = new List<ProductClass>();

            while(rec.Read())
            {
                Model.ProductClass productClass = new ProductClass();
                productClass.ClassID = Int32.Parse(rec["ClassID"].ToString());
                productClass.ClassName = rec["ClassName"].ToString();
                productClass.ParentID = Int32.Parse(rec["ParentID"].ToString());
                productClass.ParentOrder = Int32.Parse(rec["ParentOrder"].ToString());
                List_ProductClass.Add(productClass);
                productClass = null;
            }
            return List_ProductClass;
        }
        /// <summary>
        /// 查看单个分类
        /// </summary>
        /// <param name="nClassID"></param>
        /// <returns></returns>
        public ProductClass Get_SingProductClass(int nClassID)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ 
            sqlHelper.CreateInParam("@Classid",SqlDbType.Int,4,nClassID)
        };
            SqlDataReader rec = null;
            try
            {
                sqlHelper.RunProc("Get_SingProductClass", ParamList, out rec);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
            ProductClass productClass = new ProductClass();
            while (rec.Read())
            {
                productClass.ClassID = Int32.Parse(rec["ClassID"].ToString());
                productClass.ClassName = rec["ClassName"].ToString();
                productClass.ParentID = Int32.Parse(rec["ParentID"].ToString());
                productClass.ParentOrder = Int32.Parse(rec["ParentOrder"].ToString());
            }
            return productClass;
        }
    }
}
