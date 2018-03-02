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
/// ProductSQL 的摘要说明
/// </summary>
namespace DAL
{
    public class ProductSQL
    {
        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public int Add_Product(Product product)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ 
                sqlHelper.CreateInParam("@ClassID",SqlDbType.Int,4,product.productClass.ClassID),
                sqlHelper.CreateInParam("@Pro_Name",SqlDbType.NVarChar,50,product.Pro_Name),
                sqlHelper.CreateInParam("@Pic",SqlDbType.NVarChar,255,product.Pic),
                sqlHelper.CreateInParam("@Content",SqlDbType.NText,0,product.Content),
                sqlHelper.CreateInParam("@Updatatime",SqlDbType.DateTime,8,product.Updatatime),
                sqlHelper.CreateInParam("@Click",SqlDbType.Int,4,product.Click)
            };
            try
            {
                return (sqlHelper.RunProc("Add_Product", ParamList));
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>
        /// 修改商品
        /// </summary>
        /// <param name="product"></param>
        public void Update_Product(Product product)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ 
                sqlHelper.CreateInParam("@ID",SqlDbType.Int,4,product.ID),
                sqlHelper.CreateInParam("@ClassID",SqlDbType.Int,4,product.productClass.ClassID),
                sqlHelper.CreateInParam("@Pro_Name",SqlDbType.NVarChar,50,product.Pro_Name),
                sqlHelper.CreateInParam("@Pic",SqlDbType.NVarChar,255,product.Pic),
                sqlHelper.CreateInParam("@Content",SqlDbType.NText,0,product.Content),
                sqlHelper.CreateInParam("@Updatatime",SqlDbType.DateTime,8,product.Updatatime),
                sqlHelper.CreateInParam("@Click",SqlDbType.Int,4,product.Click)
            };
            try
            {
                sqlHelper.RunProc("Update_Product", ParamList);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="nID"></param>
        public void Delete_Product(int nID)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ 
                sqlHelper.CreateInParam("@ID",SqlDbType.Int,4,nID)
            };
            try
            {
                sqlHelper.RunProc("Delete_Product", ParamList);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>
        /// 查看全部商品
        /// </summary>
        /// <param name="nstartIndex"></param>
        /// <param name="nendIndex"></param>
        /// <returns></returns>
        public List<Product> Get_Product(int nstartIndex, int nendIndex)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={
                sqlHelper.CreateInParam("@startIndex",SqlDbType.Int,4,nstartIndex),
                sqlHelper.CreateInParam("@endIndex",SqlDbType.Int,4,nendIndex),
                sqlHelper.CreateInParam("@docount",SqlDbType.Bit,1,0)
            };
            SqlDataReader rec = null;
            try
            {
                sqlHelper.RunProc("Get_Product", ParamList, out rec);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
            List<Product> List_product = new List<Product>();
            while (rec.Read())
            {
                Product product = new Product();
                ProductClass productClass = new ProductClass();
                ProductClassSQL productClassSQL = new ProductClassSQL();
                productClass = productClassSQL.Get_SingProductClass(Int32.Parse(rec["ClassID"].ToString()));
                product.productClass = productClass;
                product.ID = Int32.Parse(rec["ID"].ToString());
                product.Pro_Name = rec["Pro_Name"].ToString();
                product.Pic = rec["Pic"].ToString();
                product.Content = rec["Content"].ToString();
                product.Updatatime = DateTime.Parse(rec["Updatatime"].ToString());
                product.Click = Int32.Parse(rec["Click"].ToString());
                List_product.Add(product);
                product = null;
                productClass = null;
            }
            return List_product;
        }
        /// <summary>
        /// 查看全部商品总数
        /// </summary>
        /// <param name="nstartIndex"></param>
        /// <param name="nendIndex"></param>
        /// <returns></returns>
        public int Get_ProductNum()
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={
                sqlHelper.CreateInParam("@startIndex",SqlDbType.Int,4,1),
                sqlHelper.CreateInParam("@endIndex",SqlDbType.Int,4,1),
                sqlHelper.CreateInParam("@docount",SqlDbType.Bit,1,1)
            };
            SqlDataReader rec = null;
            try
            {
                sqlHelper.RunProc("Get_Product", ParamList, out rec);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
            int Num = 0;
            while(rec.Read())
            {
                Num = Int32.Parse(rec["Counts"].ToString());
            }
            return Num;
        }
        /// <summary>
        /// 按分类查看商品
        /// </summary>
        /// <param name="nstartIndex"></param>
        /// <param name="nendIndex"></param>
        /// <param name="nClassID"></param>
        /// <returns></returns>
        public List<Product> Get_Product(int nstartIndex, int nendIndex, int nClassID)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={
                sqlHelper.CreateInParam("@startIndex",SqlDbType.Int,4,nstartIndex),
                sqlHelper.CreateInParam("@endIndex",SqlDbType.Int,4,nendIndex),
                sqlHelper.CreateInParam("@Classid",SqlDbType.Int,4,nClassID),
                sqlHelper.CreateInParam("@docount",SqlDbType.Bit,1,0)
            };
            SqlDataReader rec = null;
            try
            {
                sqlHelper.RunProc("Get_ClassProduct", ParamList, out rec);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
            List<Product> List_product = new List<Product>();
            while (rec.Read())
            {
                Product product = new Product();
                ProductClass productClass = new ProductClass();
                ProductClassSQL productClassSQL = new ProductClassSQL();
                productClass = productClassSQL.Get_SingProductClass(Int32.Parse(rec["ClassID"].ToString()));
                product.productClass = productClass;
                product.ID = Int32.Parse(rec["ID"].ToString());
                product.Pro_Name = rec["Pro_Name"].ToString();
                product.Pic = rec["Pic"].ToString();
                product.Content = rec["Content"].ToString();
                product.Updatatime = DateTime.Parse(rec["Updatatime"].ToString());
                product.Click = Int32.Parse(rec["Click"].ToString());
                List_product.Add(product);
                product = null;
                productClass = null;
            }
            return List_product;
        }
        /// <summary>
        /// 按分类查看商品总数
        /// </summary>
        /// <param name="nstartIndex"></param>
        /// <param name="nendIndex"></param>
        /// <param name="nClassID"></param>
        /// <returns></returns>
        public int Get_ProductNum(int nClassID)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={
                sqlHelper.CreateInParam("@startIndex",SqlDbType.Int,4,1),
                sqlHelper.CreateInParam("@endIndex",SqlDbType.Int,4,1),
                sqlHelper.CreateInParam("@Classid",SqlDbType.Int,4,nClassID),
                sqlHelper.CreateInParam("@docount",SqlDbType.Bit,1,1)
            };
            SqlDataReader rec = null;
            try
            {
                sqlHelper.RunProc("Get_ClassProduct", ParamList, out rec);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
            int Num = 0;
            while (rec.Read())
            {
                Num = Int32.Parse(rec["Counts"].ToString());
            }
            return Num;
        }
        /// <summary>
        /// 查看单个商品
        /// </summary>
        /// <param name="nID"></param>
        /// <returns></returns>
        public Product Get_SingProduct(int nID)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ 
                sqlHelper.CreateInParam("@ID",SqlDbType.Int,4,nID)
            };
            SqlDataReader rec = null;
            try
            {
                sqlHelper.RunProc("Get_SingProduct", ParamList, out rec);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
            Product product = new Product();
            while (rec.Read())
            {
                ProductClass productClass = new ProductClass();
                ProductClassSQL productClassSQL = new ProductClassSQL();
                productClass = productClassSQL.Get_SingProductClass(Int32.Parse(rec["ClassID"].ToString()));
                product.productClass = productClass;
                product.ID = Int32.Parse(rec["ID"].ToString());
                product.Pro_Name = rec["Pro_Name"].ToString();
                product.Pic = rec["Pic"].ToString();
                product.Content = rec["Content"].ToString();
                product.Updatatime = DateTime.Parse(rec["Updatatime"].ToString());
                product.Click = Int32.Parse(rec["Click"].ToString());
            }
            return product;
        }

    }
}
