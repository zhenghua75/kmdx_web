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
/// NewsSQL 的摘要说明
/// </summary>
//该源码下载自www.51aspx.com(５１ａsｐｘ．ｃｏｍ)

namespace DAL
{
    public class NewsSQL
    {
        /// <summary>
        /// 添加新闻
        /// </summary>
        /// <param name="news"></param>
        /// <returns></returns>
        public int Add_News(News news)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ 
                sqlHelper.CreateInParam("@ClassID",SqlDbType.Int,4,news.NewClass.ClassID),
                sqlHelper.CreateInParam("@Title",SqlDbType.NVarChar,50,news.Title),
                sqlHelper.CreateInParam("@Source",SqlDbType.NVarChar,50,news.Source),
                sqlHelper.CreateInParam("@Author",SqlDbType.NVarChar,50,news.Author),
                sqlHelper.CreateInParam("@Content",SqlDbType.NText,0,news.Content),
                sqlHelper.CreateInParam("@Updatatime",SqlDbType.DateTime,8,news.Updatatime),
                sqlHelper.CreateInParam("@Click",SqlDbType.Int,4,news.Click)
            };
            try
            {
                return (sqlHelper.RunProc("Add_News", ParamList));
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>
        /// 修改新闻
        /// </summary>
        /// <param name="news"></param>
        public void Update_News(News news)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ 
                sqlHelper.CreateInParam("@ID",SqlDbType.Int,4,news.ID),
                sqlHelper.CreateInParam("@ClassID",SqlDbType.Int,4,news.NewClass.ClassID),
                sqlHelper.CreateInParam("@Title",SqlDbType.NVarChar,50,news.Title),
                sqlHelper.CreateInParam("@Source",SqlDbType.NVarChar,50,news.Source),
                sqlHelper.CreateInParam("@Author",SqlDbType.NVarChar,50,news.Author),
                sqlHelper.CreateInParam("@Content",SqlDbType.NText,0,news.Content),
                sqlHelper.CreateInParam("@Updatatime",SqlDbType.DateTime,8,news.Updatatime),
                sqlHelper.CreateInParam("@Click",SqlDbType.Int,4,news.Click)
            };
            try
            {
                sqlHelper.RunProc("Update_News", ParamList);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>
        /// 删除新闻
        /// </summary>
        /// <param name="nID"></param>
        public void Delete_News(int nID)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ 
                sqlHelper.CreateInParam("@ID",SqlDbType.Int,4,nID)
            };
            try
            {
                sqlHelper.RunProc("Delete_News", ParamList);
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
        /// <param name="nstartIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public List<News> Get_News(int nstartIndex, int nendIndex)
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
                sqlHelper.RunProc("Get_News", ParamList, out rec);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
            List<News> List_News = new List<News>();
            while (rec.Read())
            {
                News news = new News();
                NewClass newClass = new NewClass();
                NewClassSQL newClassSQl = new NewClassSQL();
                newClass = newClassSQl.Get_SintNewClass(Int32.Parse(rec["ClassID"].ToString()));
                news.NewClass = newClass;
                news.ID = Int32.Parse(rec["ID"].ToString());
                news.Title = rec["Title"].ToString();
                news.Source = rec["Source"].ToString();
                news.Author = rec["Author"].ToString();
                news.Content = rec["Content"].ToString();
                news.Updatatime = DateTime.Parse(rec["Updatatime"].ToString());
                news.Click = Int32.Parse(rec["Click"].ToString());
                List_News.Add(news);
                news = null;
                newClass = null;
            }
            return List_News;
        }
        /// <summary>
        /// 查看全部数量
        /// </summary>
        /// <returns></returns>
        public int Get_NewsNum()
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
                sqlHelper.RunProc("Get_News", ParamList, out rec);
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
        /// 按分类查看
        /// </summary>
        /// <param name="nstartIndex"></param>
        /// <param name="nendIndex"></param>
        /// <param name="nClassID"></param>
        /// <returns></returns>
        public List<News> Get_News(int nstartIndex, int nendIndex, int nClassID)
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
                sqlHelper.RunProc("Get_ClassNews", ParamList, out rec);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
            List<News> List_News = new List<News>();
            while (rec.Read())
            {
                News news = new News();
                NewClass newClass = new NewClass();
                NewClassSQL newClassSQl = new NewClassSQL();
                newClass = newClassSQl.Get_SintNewClass(Int32.Parse(rec["ClassID"].ToString()));
                news.NewClass = newClass;
                news.ID = Int32.Parse(rec["ID"].ToString());
                news.Title = rec["Title"].ToString();
                news.Source = rec["Source"].ToString();
                news.Author = rec["Author"].ToString();
                news.Content = rec["Content"].ToString();
                news.Updatatime = DateTime.Parse(rec["Updatatime"].ToString());
                news.Click = Int32.Parse(rec["Click"].ToString());
                List_News.Add(news);
                news = null;
                newClass = null;
            }
            return List_News;
        }
        /// <summary>
        /// 按分类查看总数
        /// </summary>
        /// <param name="nClassID"></param>
        /// <returns></returns>
        public int Get_NewsNum(int nClassID)
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
                sqlHelper.RunProc("Get_ClassNews", ParamList, out rec);
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
        /// 查看单条新闻
        /// </summary>
        /// <param name="nID"></param>
        /// <returns></returns>
        public News Get_SintNews(int nID)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ 
                sqlHelper.CreateInParam("@ID",SqlDbType.Int,4,nID)    
            };
            SqlDataReader rec = null;
            try
            {
                sqlHelper.RunProc("Get_SintNews", ParamList, out rec);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
            News news = new News();
            while (rec.Read())
            {
                NewClass newClass = new NewClass();
                NewClassSQL newClassSQl = new NewClassSQL();
                newClass = newClassSQl.Get_SintNewClass(Int32.Parse(rec["ClassID"].ToString()));
                news.NewClass = newClass;
                news.ID = Int32.Parse(rec["ID"].ToString());
                news.Title = rec["Title"].ToString();
                news.Source = rec["Source"].ToString();
                news.Author = rec["Author"].ToString();
                news.Content = rec["Content"].ToString();
                news.Updatatime = DateTime.Parse(rec["Updatatime"].ToString());
                news.Click = Int32.Parse(rec["Click"].ToString());
            }
            return news;
        }
    }
}
