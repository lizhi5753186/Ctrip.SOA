//业务实体
//******************************************************************
//功能:
//
//历史: 2014/1/10 
//说明: 这是由一个工具自动生成的代码
//******************************************************************/
using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
namespace HHInfratructure.Memcached.Cfg
{
    /// <summary>
    /// MemcachedUpdateRule实体类
    /// </summary>
    [Serializable]
    public class MemcachedUpdateRuleEntity
    {
		/// <summary>
		/// 自动增长列
		/// </summary>
		public int MemcachedUpdateRuleId { get; set; }
		
		/// <summary>
		/// 缓存主键
		/// </summary>
		public string CacheKey { get; set; }
		
		/// <summary>
		/// 最后一次更新时间
		/// </summary>
		public DateTime LastUpdateTime { get; set; }
		
		/// <summary>
		/// 缓存刷新小时合计
		/// </summary>
		public int UpdateHourSpan { get; set; }
		
		/// <summary>
		/// 缓存KEY前缀
		/// </summary>
		public string CacheKeyPrefix { get; set; }
		
		/// <summary>
		/// 是否按照分钟触发Job服务
		/// </summary>
		public int IsJobActByMin { get; set; }
		
		/// <summary>
		/// 条件实体Json 为缓存刷新而用
		/// </summary>
		public string ConditionEntityJson { get; set; }		
		
		/// <summary>
		/// 是否主条件
		/// </summary>
		public int IsMainKey { get; set; }
		
		/// <summary>
		/// 最后一次锁住该记录的服务器IP
		/// </summary>
		public string ProcessIP { get; set; }		
		
		/// <summary>
		/// 最后一次被锁住的时间
		/// </summary>
		public DateTime UpdateLockTime { get; set; }
		
		/// <summary>
		/// 数据改变最后时间
		/// </summary>
		public DateTime DataChange_LastTime { get; set; }		
		
        /// <summary>
        /// 根据一条数据记录创建实体对象
        /// </summary>
        public static MemcachedUpdateRuleEntity CreateEntity(DataRow dr)
        {
            MemcachedUpdateRuleEntity ent = new MemcachedUpdateRuleEntity();
            if(dr["MemcachedUpdateRuleId"] != DBNull.Value)ent.MemcachedUpdateRuleId = int.Parse(dr["MemcachedUpdateRuleId"].ToString());            
            if(dr["CacheKey"] != DBNull.Value)ent.CacheKey = (string)dr["CacheKey"];
            if(dr["LastUpdateTime"] != DBNull.Value)ent.LastUpdateTime = DateTime.Parse(dr["LastUpdateTime"].ToString());            
            if(dr["UpdateHourSpan"] != DBNull.Value)ent.UpdateHourSpan = int.Parse(dr["UpdateHourSpan"].ToString());
            if(dr["CacheKeyPrefix"] != DBNull.Value)ent.CacheKeyPrefix = (string)dr["CacheKeyPrefix"];            
            if(dr["IsJobActByMin"] != DBNull.Value)ent.IsJobActByMin = int.Parse(dr["IsJobActByMin"].ToString());
            if(dr["ConditionEntityJson"] != DBNull.Value)ent.ConditionEntityJson = (string)dr["ConditionEntityJson"];            
            if(dr["IsMainKey"] != DBNull.Value)ent.IsMainKey = int.Parse(dr["IsMainKey"].ToString());
            if(dr["ProcessIP"] != DBNull.Value)ent.ProcessIP = (string)dr["ProcessIP"];            
            if(dr["UpdateLockTime"] != DBNull.Value)ent.UpdateLockTime = DateTime.Parse(dr["UpdateLockTime"].ToString());            
            if(dr["DataChange_LastTime"] != DBNull.Value)ent.DataChange_LastTime = DateTime.Parse(dr["DataChange_LastTime"].ToString());
            return ent;
        }
       
        /// <summary>
        /// 根据数据集合创建实体对象集合
        /// </summary>
        public static List<MemcachedUpdateRuleEntity> CreateEntity(DataRow[] drs)
        {
            List<MemcachedUpdateRuleEntity> ents = new List<MemcachedUpdateRuleEntity>();
            foreach (DataRow dr in drs)
            {
                ents.Add(CreateEntity(dr));
            }
            return ents;
        }
       
        /// <summary>
        /// 将当前实体转化成日志记录
        /// </summary>
        public string ConvertEntityToLogString()
        {
            StringBuilder LogDetail = new StringBuilder();
            LogDetail.AppendLine("MemcachedUpdateRuleId=" + this.MemcachedUpdateRuleId.ToString());            
            if (this.CacheKey != null)LogDetail.AppendLine("CacheKey=" + this.CacheKey.ToString());
            LogDetail.AppendLine("LastUpdateTime=" + this.LastUpdateTime.ToString());            
            LogDetail.AppendLine("UpdateHourSpan=" + this.UpdateHourSpan.ToString());
            if (this.CacheKeyPrefix != null)LogDetail.AppendLine("CacheKeyPrefix=" + this.CacheKeyPrefix.ToString());            
            LogDetail.AppendLine("IsJobActByMin=" + this.IsJobActByMin.ToString());
            if (this.ConditionEntityJson != null)LogDetail.AppendLine("ConditionEntityJson=" + this.ConditionEntityJson.ToString());            
            LogDetail.AppendLine("IsMainKey=" + this.IsMainKey.ToString());
            if (this.ProcessIP != null)LogDetail.AppendLine("ProcessIP=" + this.ProcessIP.ToString());            
            LogDetail.AppendLine("UpdateLockTime=" + this.UpdateLockTime.ToString());            
            LogDetail.AppendLine("DataChange_LastTime=" + this.DataChange_LastTime.ToString());
            return LogDetail.ToString();
        }
       
       
	}
}
