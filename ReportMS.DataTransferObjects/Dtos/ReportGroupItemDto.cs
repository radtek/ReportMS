﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ReportMS.DataTransferObjects.Dtos
{
    /// <summary>
    /// 报表分组明细项 Dto
    /// </summary>
    [ServiceContract]
    public class ReportGroupItemDto
    {
        /// <summary>
        /// 获取或设置 Id
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// 获取或设置报表分组的 ID
        /// </summary>
        [DataMember]
        public Guid ReportGroupId { get; set; }

        /// <summary>
        /// 获取或设置报表 ID
        /// </summary>
        [DataMember]
        public Guid ReportId { get; set; }

        /// <summary>
        /// 获取或设置一个<see cref="System.Boolean"/>值,表示报表组是否可用
        /// </summary>
        [DataMember]
        public bool Enabled { get; set; }

        /// <summary>
        /// 获取或设置创建人
        /// </summary>
        [DataMember]
        public string CreatedBy { get; set; }

        /// <summary>
        /// 获取或设置创建时间
        /// </summary>
        [DataMember]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// 获取或设置更新人
        /// </summary>
        [DataMember]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// 获取或设置创建时间
        /// </summary>
        [DataMember]
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// 获取或设置报表组项字段集合
        /// </summary>
        [DataMember]
        public ICollection<ReportGroupItemFieldDto> ReportGroupItemFields { get; set; }
    }
}
