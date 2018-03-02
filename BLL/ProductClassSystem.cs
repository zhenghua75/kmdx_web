using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Text;
using System.Collections.Generic;
using DAL;
using Model;

/// <summary>
/// ProductClassSystem 的摘要说明
/// </summary>
namespace BLL
{
    public class ProductClassSystem
    {
        /// <summary>
	    /// 添加产品分类
	    /// </summary>
	    /// <param name="productClass"></param>
	    /// <returns></returns>
        public int Add_ProductClass(ProductClass productClass)
        {
            ProductClassSQL productClassSQL = new ProductClassSQL();
            return (productClassSQL.Add_ProductClass(productClass));
        }
        /// <summary>
        /// 修改分类
        /// </summary>
        /// <param name="productClass"></param>
        public void Update_ProductClass(ProductClass productClass)
        {
            ProductClassSQL productClassSQL = new ProductClassSQL();
            productClassSQL.Update_ProductClass(productClass);
        }
        /// <summary>
        /// 删除分类
        /// </summary>
        /// <param name="nClassID"></param>
        public void Delete_ProductClass(int nClassID)
        {
            ProductClassSQL productClassSQL = new ProductClassSQL();
            productClassSQL.Delete_ProductClass(nClassID);
        }
        /// <summary>
        /// 查看分类
        /// </summary>
        /// <param name="nParentID"></param>
        /// <returns></returns>
        public List<ProductClass> Get_ProductClass(int nParentID)
        {
            ProductClassSQL productClassSQL = new ProductClassSQL();
            return (productClassSQL.Get_ProductClass(nParentID));
        }
        /// <summary>
        /// 查看单个分类
        /// </summary>
        /// <param name="nClassID"></param>
        /// <returns></returns>
        public ProductClass Get_SingProductClass(int nClassID)
        {
            ProductClassSQL productClassSQL = new ProductClassSQL();
            return (productClassSQL.Get_SingProductClass(nClassID));
        }
    }
}
