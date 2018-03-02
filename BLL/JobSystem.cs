using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Text;
using System.Collections.Generic;
using DAL;
using Model;
/// <summary>
/// JobSystem 的摘要说明
/// </summary>
namespace BLL
{
    public class JobSystem
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="job"></param>
        /// <returns></returns>
        public int Add_Job(Job job)
        {
            JobSQL jobSQL = new JobSQL();
            return (jobSQL.Add_Job(job));
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="job"></param>
        public void Update_Job(Job job)
        {
            JobSQL jobSQL = new JobSQL();
            jobSQL.Update_Job(job);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="nID"></param>
        public void Delete_Job(int nID)
        {
            JobSQL jobSQL = new JobSQL();
            jobSQL.Delete_Job(nID);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <param name="nstartIndex"></param>
        /// <param name="nendIndex"></param>
        /// <returns></returns>
        public List<Job> Get_Job(int nstartIndex, int nendIndex)
        {
            JobSQL jobSQL = new JobSQL();
            return (jobSQL.Get_Job(nstartIndex, nendIndex));
        }
        /// <summary>
        /// 查看总数
        /// </summary>
        /// <returns></returns>
        public int Get_JobNum()
        {
            JobSQL jobSQL = new JobSQL();
            return (jobSQL.Get_JobNum());
        }
        /// <summary>
        /// 查看单个
        /// </summary>
        /// <param name="nID"></param>
        /// <returns></returns>
        public Job Get_SingJob(int nID)
        {
            JobSQL jobSQL = new JobSQL();
            return (jobSQL.Get_SingJob(nID));            
        }
    }
}
