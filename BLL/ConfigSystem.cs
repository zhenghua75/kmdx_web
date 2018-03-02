using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Text;
using System.Collections.Generic;
using DAL;
using Model;
/// <summary>
/// ConfigSystem 的摘要说明
/// </summary>
namespace BLL
{
    public class ConfigSystem
    {
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="config"></param>
        public void Update_Config(Config config)
        {
            ConfigSQL configSQL = new ConfigSQL();
            configSQL.Update_Config(config);
        }
        /// <summary>
        /// 查看
        /// </summary>
        /// <returns></returns>
        public Config Get_Config()
        {
            ConfigSQL configSQL = new ConfigSQL();
            return (configSQL.Get_Config());
        }
    }
}
