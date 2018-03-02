using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Text;
using System.Collections.Generic;
using DAL;
using Model;

/// <summary>
/// NewsSystem 的摘要说明
/// </summary>
namespace BLL
{
    public class NewsSystem
    {
        /// <summary>
        /// 添加新闻
        /// </summary>
        /// <param name="news"></param>
        /// <returns></returns>
        public int Add_News(News news)
        {
            NewsSQL newsSQL = new NewsSQL();
            return (newsSQL.Add_News(news));
        }
        /// <summary>
        /// 修改新闻
        /// </summary>
        /// <param name="news"></param>
        public void Update_News(News news)
        {
            NewsSQL newsSQL = new NewsSQL();
            newsSQL.Update_News(news);
        }
        /// <summary>
        /// 删除新闻
        /// </summary>
        /// <param name="nID"></param>
        public void Delete_News(int nID)
        {
            NewsSQL newsSQL = new NewsSQL();
            newsSQL.Delete_News(nID);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <param name="nstartIndex"></param>
        /// <param name="nendIndex"></param>
        /// <returns></returns>
        public List<News> Get_News(int nstartIndex, int nendIndex)
        {
            NewsSQL newsSQL = new NewsSQL();
            return (newsSQL.Get_News(nstartIndex, nendIndex));
        }
        /// <summary>
        /// 查看全部数量
        /// </summary>
        /// <returns></returns>
        public int Get_NewsNum()
        {
            NewsSQL newsSQL = new NewsSQL();
            return (newsSQL.Get_NewsNum());
        }
        /// <summary>
        /// 按分类查看
        /// </summary>
        /// <param name="nstartIndex"></param>
        /// <param name="nendIndex"></param>
        /// <param name="nClassID"></param>
        /// <returns></returns>
        public List<News> Get_News(int nstartIndex, int nendIndex, int nClassID)
        {
            NewsSQL newsSQL = new NewsSQL();
            return (newsSQL.Get_News(nstartIndex, nendIndex, nClassID));
        }
        /// <summary>
        /// 按分类查看总数
        /// </summary>
        /// <param name="nClassID"></param>
        /// <returns></returns>
        public int Get_NewsNum(int nClassID)
        {
            NewsSQL newsSQL = new NewsSQL();
            return (newsSQL.Get_NewsNum(nClassID));
        }
        /// <summary>
        /// 查看单条新闻
        /// </summary>
        /// <param name="nID"></param>
        /// <returns></returns>
        public News Get_SintNews(int nID)
        {
            NewsSQL newsSQL = new NewsSQL();
            return (newsSQL.Get_SintNews(nID));
        }
    }
}
