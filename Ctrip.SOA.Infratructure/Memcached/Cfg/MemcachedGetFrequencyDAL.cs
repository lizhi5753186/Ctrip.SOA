/******************************************************************
** 数据库HHCfgDB中表MemcachedGetFrequency数据访问层操作类
** 此代码由工具自动生成
******************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using HHInfratructure.Data;

namespace HHInfratructure.Memcached.Cfg
{
    /// <summary>
    /// 缓存频次更新数据访问类
    /// </summary>
    public class MemcachedGetFrequencyDAL : DALContext
    {
        public MemcachedGetFrequencyDAL() : base(DBConsts.HHCfgDB_SELECT) { }

        /// <summary>
        /// 根据主键获取一个实体对象
        /// </summary>
        public MemcachedGetFrequencyEntity Select(int MemcachedGetFrequencyId)
        {
            DbCommand cmd = DB.DbProviderFactory.CreateCommand();
            cmd.CommandText = "select * from MemcachedGetFrequency with(nolock) where MemcachedGetFrequencyId=@MemcachedGetFrequencyId";
            cmd.CommandType = System.Data.CommandType.Text;

            DB.AddInParameter(cmd, "MemcachedGetFrequencyId", DbType.Int32, MemcachedGetFrequencyId);
            DataSet ds = DB.ExecuteDataSet(cmd);
            if (ds.Tables[0].Rows.Count == 0) return null;

            DataRow dr = ds.Tables[0].Rows[0];
            return MemcachedGetFrequencyEntity.CreateEntity(dr);
        }

        /// <summary>
        /// 根据条件获取一个实体对象
        /// </summary>
        public MemcachedGetFrequencyEntity Select(string where)
        {
            DbCommand cmd = DB.DbProviderFactory.CreateCommand();
            cmd.CommandText = "select * from MemcachedGetFrequency with(nolock) where " + where;
            cmd.CommandType = System.Data.CommandType.Text;

            DataSet ds = DB.ExecuteDataSet(cmd);
            if (ds.Tables[0].Rows.Count == 0) return null;

            DataRow dr = ds.Tables[0].Rows[0];
            return MemcachedGetFrequencyEntity.CreateEntity(dr);
        }

        /// <summary>
        /// 根据条件获取对应的记录集
        /// </summary>
        public DataTable SelectTable(string where)
        {
            DbCommand cmd = DB.DbProviderFactory.CreateCommand();
            cmd.CommandText = "select * from MemcachedGetFrequency with(nolock) where " + where;
            cmd.CommandType = System.Data.CommandType.Text;

            DataSet ds = DB.ExecuteDataSet(cmd);
            if (ds.Tables[0].Rows.Count == 0) return null;

            return ds.Tables[0];
        }

        /// <summary>
        /// 根据条件获取对应的记录集
        /// </summary>
        public DataTable SelectTableId()
        {
            DbCommand cmd = DB.DbProviderFactory.CreateCommand();
            cmd.CommandText = "select MemcachedGetFrequencyId from MemcachedGetFrequency with(nolock)";
            cmd.CommandType = System.Data.CommandType.Text;

            DataSet ds = DB.ExecuteDataSet(cmd);
            return ds.Tables[0];
        }

        /// <summary>
        /// 根据指定字段、字段值、表达式，查询出符合条件的记录，并按照指定的排序方式返回记录集
        /// </summary>
        /// <param name="fields">字段集</param>
        /// <param name="values">字段对应的值</param>
        /// <param name="expressions">字段与值的表达式</param>
        /// <param name="orderby">排序字段，默认asc，需要desc直接含在排序字段中</param>
        /// <returns>符合条件的记录集</returns>
        public DataTable Select(List<string> fields, List<string> values, List<string> expressions, List<string> orderby)
        {
            DbCommand cmd = DB.DbProviderFactory.CreateCommand();
            cmd.CommandText = "select * from MemcachedGetFrequency with(nolock) where ";
            cmd.CommandType = System.Data.CommandType.Text;

            for (int i = 0; i < fields.Count; i++)
            {
                cmd.CommandText += fields[i] + " " + expressions[i] + " @" + fields[i] + " & ";
                if (expressions[i].ToLower() != "like")
                    DB.AddInParameter(cmd, "@" + fields[i], DbType.Object, values[i]);
                else
                    DB.AddInParameter(cmd, "@" + fields[i], DbType.String, " % " + values[i] + " % ");
            }
            cmd.CommandText = cmd.CommandText.TrimEnd().TrimEnd('&').Replace("&", " and ");

            if (orderby != null && orderby.Count > 0)
            {
                cmd.CommandText += " order by ";
                for (int i = 0; i < orderby.Count; i++)
                {
                    cmd.CommandText += orderby[i] + ",";
                }
            }
            cmd.CommandText = cmd.CommandText.TrimEnd(',');

            return DB.ExecuteDataSet(cmd).Tables[0];
        }

        public bool Insert(MemcachedGetFrequencyEntity entity)
        {
            DbCommand cmd = DB.DbProviderFactory.CreateCommand();
            cmd.CommandText = "spA_MemcachedGetFrequency_i";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            DB.AddOutParameter(cmd, "@MemcachedGetFrequencyId", DbType.Int32, entity.MemcachedGetFrequencyId);
            if (entity.CacheKey != null) DB.AddInParameter(cmd, "@CacheKey", DbType.AnsiString, entity.CacheKey);
            DB.AddInParameter(cmd, "@FreCount", DbType.Int32, entity.FreCount);
            if (entity.LastGetDateTime.Year != 1) DB.AddInParameter(cmd, "@LastGetDateTime", DbType.DateTime, entity.LastGetDateTime);
            DB.AddInParameter(cmd, "@FreMin", DbType.Int32, entity.FreMin);
            if (entity.CacheKeyPrefix != null) DB.AddInParameter(cmd, "@CacheKeyPrefix", DbType.AnsiString, entity.CacheKeyPrefix);
            if (entity.DataChange_LastTime.Year != 1) DB.AddInParameter(cmd, "@DataChange_LastTime", DbType.DateTime, entity.DataChange_LastTime);
            bool b = (int)DB.ExecuteNonQuery(cmd) == 0 ? true : false;
            entity.MemcachedGetFrequencyId = int.Parse(DB.GetParameterValue(cmd, "@MemcachedGetFrequencyId").ToString());
            return b;
        }

        public bool Update(MemcachedGetFrequencyEntity entity)
        {
            DbCommand cmd = DB.DbProviderFactory.CreateCommand();
            cmd.CommandText = "spA_MemcachedGetFrequency_u";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            DB.AddInParameter(cmd, "@MemcachedGetFrequencyId", DbType.AnsiString, entity.MemcachedGetFrequencyId);
            if (entity.CacheKey != null) DB.AddInParameter(cmd, "@CacheKey", DbType.AnsiString, entity.CacheKey);
            DB.AddInParameter(cmd, "@FreCount", DbType.Int32, entity.FreCount);
            if (entity.LastGetDateTime.Year != 1) DB.AddInParameter(cmd, "@LastGetDateTime", DbType.DateTime, entity.LastGetDateTime);
            DB.AddInParameter(cmd, "@FreMin", DbType.Int32, entity.FreMin);
            if (entity.CacheKeyPrefix != null) DB.AddInParameter(cmd, "@CacheKeyPrefix", DbType.AnsiString, entity.CacheKeyPrefix);
            if (entity.DataChange_LastTime.Year != 1) DB.AddInParameter(cmd, "@DataChange_LastTime", DbType.DateTime, entity.DataChange_LastTime);
            return DB.ExecuteNonQuery(cmd) == 0 ? true : false;
        }

        public bool Delete(int CacheKey)
        {
            DbCommand cmd = DB.DbProviderFactory.CreateCommand();
            cmd.CommandText = "spA_MemcachedGetFrequency_d";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            DB.AddInParameter(cmd, "@MemcachedGetFrequencyId", DbType.Int32, CacheKey);
            return DB.ExecuteNonQuery(cmd) == 0 ? true : false;
        }
    }
}
