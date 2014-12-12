using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using CommonTools.Common;
using Napoleon.Mvc.DAL.Helper;

namespace CommonTools.DAL.Helper
{
    public class SqLiteHelper
    {



        #region SQLite数据库方法

        /// <summary>
        ///  SQLite链接
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-01 20:09:21
        private static readonly string SqliteConnection = string.Format("Data Source={0}{1}", AppDomain.CurrentDomain.SetupInformation.ApplicationBase, PublicFields.DbName);

        /// <summary>
        ///  打开数据库
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-01 20:18:04
        private static SQLiteConnection OpenConnection()
        {
            SQLiteConnection conn = new SQLiteConnection(SqliteConnection);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        #endregion

        #region 公共操作部分

        /// <summary>
        ///  获取查询结果
        /// </summary>
        /// <param name="sql">SQL</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-01 20:18:16
        public static object GetDataObject(string sql)
        {
            using (IDbConnection conn = OpenConnection())
            {
                return conn.ExecuteScalar(sql);
            }
        }

        /// <summary>
        ///  获取DateTable
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-22 09:51:02
        public static DataTable GetDataTable(string sql)
        {
            try
            {
                return (DataTable)GetDataObject(sql);
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }

        /// <summary>
        ///  获取实体类集合
        /// </summary>
        /// <typeparam name="T">实体类</typeparam>
        /// <param name="sql">SQL</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-01 20:41:32
        public static List<T> GetEnumerables<T>(string sql) where T : new()
        {
            using (IDbConnection conn = OpenConnection())
            {
                return conn.Query<T>(sql).ToList();
            }
        }

        /// <summary>
        ///  获取单个实体类
        /// </summary>
        /// <param name="sql">SQL.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-22 16:04:50
        public static T GetEnumerable<T>(string sql) where T : new()
        {
            if (GetEnumerables<T>(sql).Count > 0)
            {
                return GetEnumerables<T>(sql)[0];
            }
            return default(T);
        }

        /// <summary>
        ///  增加、删除、修改操作
        /// </summary>
        /// <param name="sql">SQL</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-01 21:04:20
        public static int ExecuteSql(string sql)
        {
            using (IDbConnection conn = OpenConnection())
            {
                return conn.Execute(sql);
            }
        }

        /// <summary>
        ///  查询个数
        /// </summary>
        /// <param name="sql">SQL</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-01 21:09:47
        public static int QueryCount(string sql)
        {
            try
            {
                return (int)GetDataObject(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        #endregion



    }
}
