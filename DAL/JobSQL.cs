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
/// JobSQL 的摘要说明
/// </summary>
namespace DAL
{
    public class JobSQL
    {
       /// <summary>
       /// 添加
       /// </summary>
       /// <param name="job"></param>
       /// <returns></returns>
        public int Add_Job(Job job)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ 
                sqlHelper.CreateInParam("@Title",SqlDbType.NVarChar,50,job.Title),
                sqlHelper.CreateInParam("@Content",SqlDbType.NText,0,job.Content),
                sqlHelper.CreateInParam("@Click",SqlDbType.Int,4,job.Click)
            };
            try
            {
                return (sqlHelper.RunProc("Add_Job", ParamList));
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
        /// <param name="job"></param>
        public void Update_Job(Job job)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={
                sqlHelper.CreateInParam("@ID",SqlDbType.Int,4,job.ID),
                sqlHelper.CreateInParam("@Title",SqlDbType.NVarChar,50,job.Title),
                sqlHelper.CreateInParam("@Content",SqlDbType.NText,0,job.Content),
                sqlHelper.CreateInParam("@Click",SqlDbType.Int,4,job.Click)
            };
            try
            {
                sqlHelper.RunProc("Update_Job", ParamList);
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
        public void Delete_Job(int nID)
        {
             SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
             SqlParameter[] ParamList ={
                sqlHelper.CreateInParam("@ID",SqlDbType.Int,4,nID),
            };
             try
             {
                 sqlHelper.RunProc("Delete_Job", ParamList);
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
        public List<Job> Get_Job(int nstartIndex, int nendIndex)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList = { 
                sqlHelper.CreateInParam("@startIndex",SqlDbType.Int,4,nstartIndex),
                sqlHelper.CreateInParam("@endIndex",SqlDbType.Int,4,nendIndex),
                sqlHelper.CreateInParam("@docount",SqlDbType.Bit,1,0)
            };
            SqlDataReader rec = null;
            try
            {
                sqlHelper.RunProc("Get_Job", ParamList, out rec);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
            List<Job> List_Job = new List<Job>();
            while (rec.Read())
            {
                Job job = new Job();
                job.ID = Int32.Parse(rec["ID"].ToString());
                job.Title = rec["Title"].ToString();
                job.Content = rec["Content"].ToString();
                job.Updatatime = DateTime.Parse(rec["Updatatime"].ToString());
                job.Click = Int32.Parse(rec["Click"].ToString());
                List_Job.Add(job);
                job = null;
            }
            return (List_Job);
        }
        /// <summary>
        /// 查看总数
        /// </summary>
        /// <returns></returns>
        public int Get_JobNum()
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList = { 
                sqlHelper.CreateInParam("@startIndex",SqlDbType.Int,4,1),
                sqlHelper.CreateInParam("@endIndex",SqlDbType.Int,4,1),
                sqlHelper.CreateInParam("@docount",SqlDbType.Bit,1,1)
            };
            SqlDataReader rec = null;
            try
            {
                sqlHelper.RunProc("Get_Job", ParamList, out rec);
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
        /// 查看单个
        /// </summary>
        /// <param name="nID"></param>
        /// <returns></returns>
        public Job Get_SingJob(int nID)
        {
             SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
             SqlParameter[] ParamList = { sqlHelper.CreateInParam("@ID", SqlDbType.Int, 4, nID) };
             SqlDataReader rec = null;
             try
             {
                 sqlHelper.RunProc("Get_SingJob", ParamList, out rec);
             }
             catch (Exception ex)
             {
                 SystemError.CreateErrorLog(ex.Message);
                 throw new Exception(ex.Message, ex);
             }
             Job job = new Job();
             while (rec.Read())
             {
                 job.ID = Int32.Parse(rec["ID"].ToString());
                 job.Title = rec["Title"].ToString();
                 job.Content = rec["Content"].ToString();
                 job.Updatatime = DateTime.Parse(rec["Updatatime"].ToString());
                 job.Click = Int32.Parse(rec["Click"].ToString());
             }
             return job;
        }
    }
}
