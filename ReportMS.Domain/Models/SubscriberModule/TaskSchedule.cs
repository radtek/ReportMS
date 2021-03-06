﻿namespace ReportMS.Domain.Models.SubscriberModule
{
    /// <summary>
    /// 任务执行计划
    /// </summary>
    public enum TaskSchedule
    {
        /// <summary>
        /// 执行频率为每分钟
        /// </summary>
        Minutely = 0,

        /// <summary>
        /// 执行频率为每小时
        /// </summary>
        Hourly = 1,

        /// <summary>
        /// 执行频率为每天
        /// </summary>
        Daily = 2,

        /// <summary>
        /// 执行频率为每周
        /// </summary>
        Weekly = 3,

        /// <summary>
        /// 执行频率为每月
        /// </summary>
        Monthly = 4,

        /// <summary>
        /// 执行频率为每年
        /// </summary>
        Yearly = 5
    }
}
