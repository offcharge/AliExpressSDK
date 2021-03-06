﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace SDK.Platform.AliExpressApi.RModel
{
    /// <summary>
    /// 商品业务状态
    /// </summary>
    public enum ProductStatusType
    {
        /// <summary>
        /// 上架
        /// </summary>
        onSelling,
        /// <summary>
        /// 下架
        /// </summary>
        offline,
        /// <summary>
        /// 审核中
        /// </summary>
        auditing,
        /// <summary>
        /// 审核不通过
        /// </summary>
        editingRequired
    }
    /// <summary>
    /// 商品下架原因
    /// </summary>
    public enum WsDisplay
    {
        /// <summary>
        /// 过期下架
        /// </summary>
        expire_offline,
        /// <summary>
        /// 用户下架
        /// </summary>
        user_offline,
        /// <summary>
        /// 违规下架
        /// </summary>
        violate_offline,
        /// <summary>
        /// 交易违规下架
        /// </summary>
        punish_offline,
        /// <summary>
        /// 降级下架
        /// </summary>
        degrade_offline
    }

    //public class AeopAEProductDisplayDTOList
    //{
    //    /// <summary>
    //    /// 修改时间
    //    /// </summary>
    //    [JsonProperty("gmtModified")]
    //    public System.DateTimeOffset GmtModified { get; set; }
    //    /// <summary>
    //    /// 创建时间
    //    /// </summary>
    //    [JsonProperty("gmtCreate")]
    //    public System.DateTimeOffset GmtCreate { get; set; }
    //    /// <summary>
    //    /// 运费模板
    //    /// </summary>
    //    [JsonProperty("freightTemplateId")]
    //    public string FreightTemplateId { get; set; }

    //    [JsonProperty("ownerMemberSeq")]
    //    public int OwnerMemberSeq { get; set; }
    //    /// <summary>
    //    /// 标题
    //    /// </summary>
    //    [JsonProperty("subject")]
    //    public string Subject { get; set; }
    //    /// <summary>
    //    /// 图片链接
    //    /// </summary>
    //    [JsonProperty("imageURLs")]
    //    public string ImageURLs { get; set; }

    //    [JsonProperty("ownerMemberId")]
    //    public string OwnerMemberId { get; set; }

    //    [JsonProperty("wsOfflineDate")]
    //    public string WsOfflineDate { get; set; }
    //    /// <summary>
    //    /// 产品编号
    //    /// </summary>
    //    [JsonProperty("productId")]
    //    public string ProductId { get; set; }
    //    /// <summary>
    //    /// 最小价格
    //    /// </summary>
    //    [JsonProperty("productMinPrice")]
    //    public decimal ProductMinPrice { get; set; }
    //    /// <summary>
    //    /// 最大价格
    //    /// </summary>
    //    [JsonProperty("productMaxPrice")]
    //    public decimal ProductMaxPrice { get; set; }

    //    [JsonProperty("wsDisplay")]
    //    public WsDisplay WsDisplay { get; set; }
    //}
    //public class AliProductListResultType : AliSuccessType
    //{
    //    /// <summary>
    //    /// 当前页记录
    //    /// </summary>
    //    [JsonProperty("aeopAEProductDisplayDTOList")]
    //    public AeopAEProductDisplayDTOList[] List;
    //    /// <summary>
    //    /// 总记录数
    //    /// </summary>
    //    [JsonProperty("productCount")]
    //    public int ProductCount;
    //    /// <summary>
    //    /// 当前页
    //    /// </summary>
    //    [JsonProperty("currentPage")]
    //    public int CurrentPage;
    //    /// <summary>
    //    /// 产品页数
    //    /// </summary>
    //    [JsonProperty("totalPage")]
    //    public int TotalPage;
    //}
    //public class AliGroupListResultType : AliErrorType
    //{
    //    [JsonProperty("timeStamp")]
    //    public string TimeStamp;
    //    [JsonProperty("target")]
    //    public AliGroupType[] GroupList;
    //    [JsonProperty("success")]
    //    public bool Success;

    //}
}
