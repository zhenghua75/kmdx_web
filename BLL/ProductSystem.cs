using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Text;
using System.Collections.Generic;
using DAL;
using Model;
/// <summary>
/// ProductSystem 的摘要说明
/// </summary>
namespace BLL
{
    public class ProductSystem
    {
        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public int Add_Product(Product product)
        {
            ProductSQL productSQL = new ProductSQL();
            return (productSQL.Add_Product(product));
        }
        /// <summary>
        /// 修改商品
        /// </summary>
        /// <param name="product"></param>
        public void Update_Product(Product product)
        {
            ProductSQL productSQL = new ProductSQL();
            productSQL.Update_Product(product);
        }
        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="nID"></param>
        public void Delete_Product(int nID)
        {
            ProductSQL productSQL = new ProductSQL();
            productSQL.Delete_Product(nID);
        }
        /// <summary>
        /// 查看全部商品
        /// </summary>
        /// <param name="nstartIndex"></param>
        /// <param name="nendIndex"></param>
        /// <returns></returns>
        public List<Product> Get_Product(int nstartIndex, int nendIndex)
        {
            ProductSQL productSQL = new ProductSQL();
            return (productSQL.Get_Product(nstartIndex, nendIndex));
        }
        /// <summary>
        /// 查看商品总数
        /// </summary>
        /// <param name="nstartIndex"></param>
        /// <param name="nendIndex"></param>
        /// <returns></returns>
        public int Get_ProductNum()
        {
            ProductSQL productSQL = new ProductSQL();
            return (productSQL.Get_ProductNum());
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
            ProductSQL productSQL = new ProductSQL();
            return (productSQL.Get_Product(nstartIndex, nendIndex, nClassID));
        }
        /// <summary>
        /// 按分类查看商品数量
        /// </summary>
        /// <param name="nstartIndex"></param>
        /// <param name="nendIndex"></param>
        /// <param name="nClassID"></param>
        /// <returns></returns>
        public int Get_ProductNum(int nClassID)
        {
            ProductSQL productSQL = new ProductSQL();
            return (productSQL.Get_ProductNum(nClassID));
        }
        /// <summary>
        /// 查看单个商品
        /// </summary>
        /// <param name="nID"></param>
        /// <returns></returns>
        public Product Get_SingProduct(int nID)
        {
            ProductSQL productSQL = new ProductSQL();
            return (productSQL.Get_SingProduct(nID));
        }
    }
}
