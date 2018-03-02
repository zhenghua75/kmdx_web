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
/// ConfigSQL 的摘要说明
/// </summary>
//该源码下载自www.51aspx.com(５１aｓｐｘ．ｃｏｍ)

namespace DAL
{
    public class ConfigSQL
    {
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="config"></param>
        public void Update_Config(Config config)
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlParameter[] ParamList ={ 
                sqlHelper.CreateInParam("@About",SqlDbType.NText,0,config.About),
                sqlHelper.CreateInParam("@Contact",SqlDbType.NText,0,config.Contact)
            };
            try
            {
                sqlHelper.RunProc("Update_Config", ParamList);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>
        /// 查看
        /// </summary>
        /// <returns></returns>
        public Config Get_Config()
        {
            SQLHelper.SQLHelper sqlHelper = new SQLHelper.SQLHelper();
            SqlDataReader rec=null;
            try
            {
                sqlHelper.RunProc("Get_Config", out rec);
            }
            catch (Exception ex)
            {
                SystemError.CreateErrorLog(ex.Message);
                throw new Exception(ex.Message, ex);
            }
            Config config = new Config();
            while (rec.Read())
            {
                config.About = rec["About"].ToString();
                config.Contact = rec["Contact"].ToString();
            }
            return config;
        }
    }
}
