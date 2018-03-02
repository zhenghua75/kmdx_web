using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Text;
using System.Collections.Generic;
using DAL;
using Model;
/// <summary>
/// NewClassSystem 的摘要说明
/// </summary>
namespace BLL
{
    public class NewClassSystem
    {
        /// <summary>
        /// 添加新闻类
        /// </summary>
        /// <param name="newClass"></param>
        /// <returns></returns>
        public int Add_NewClass(NewClass newClass)
        {
            NewClassSQL newClassSQL = new NewClassSQL();
            return (newClassSQL.Add_NewClass(newClass));
        }
        /// <summary>
        /// 修改新闻分类
        /// </summary>
        /// <param name="newClass"></param>
        public void Update_NewClass(NewClass newClass)
        {
            NewClassSQL newClassSQL = new NewClassSQL();
            newClassSQL.Update_NewClass(newClass);
        }
        /// <summary>
        /// 删除新闻分类
        /// </summary>
        /// <param name="nClassid"></param>
        public void Delete_NewClass(int nClassid)
        {
            NewClassSQL newClassSQL = new NewClassSQL();
            newClassSQL.Delete_NewClass(nClassid);
        }
        /// <summary>
        /// 查看全部分类
        /// </summary>
        /// <param name="nParentID"></param>
        /// <returns></returns>
        public List<NewClass> Get_NewClass(int nParentID)
        {
            NewClassSQL newClassSQL = new NewClassSQL();
            return (newClassSQL.Get_NewClass(nParentID));
        }
        /// <summary>
        /// 查看单个分类
        /// </summary>
        /// <param name="nClassid"></param>
        /// <returns></returns>
        public NewClass Get_SintNewClass(int nClassid)
        {
            NewClassSQL newClassSQL = new NewClassSQL();
            return (newClassSQL.Get_SintNewClass(nClassid));
        }
    }
}
