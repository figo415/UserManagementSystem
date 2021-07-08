using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Externals
{
    public class InventoryListItem
    {
        #region 基本信息

        /// <summary>
        /// 库存id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string itemName { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// 类型id
        /// </summary>
        public string typeId { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        public string typeName { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public string number { get; set; }

        /// <summary>
        /// 数量单位
        /// </summary>
        public string numUnit { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        public string spec { get; set; }

        /// <summary>
        /// 规格单位
        /// </summary>
        public string specUnit { get; set; }

        /// <summary>
        /// 货号
        /// </summary>
        public string articleNum { get; set; }

        /// <summary>
        /// 批号
        /// </summary>
        public string batchNum { get; set; }

        /// <summary>
        /// 告警数量
        /// </summary>
        public string warningNum { get; set; }

        public string inventoryNote { get; set; }

        #endregion

        #region 采购信息

        /// <summary>
        /// 订单号
        /// </summary>
        public string orderNumber { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public string price { get; set; }

        /// <summary>
        /// 价格单位
        /// </summary>
        public string priceUnit { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        public string brand { get; set; }

        /// <summary>
        /// 网址
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 供应商
        /// </summary>
        public string vendor { get; set; }

        /// <summary>
        /// 到达日期
        /// </summary>
        public string arrivalDate { get; set; }

        #endregion

        #region 物料信息

        /// <summary>
        /// 申请日期
        /// </summary>
        public string requestDate { get; set; }

        /// <summary>
        /// 物料代码
        /// </summary>
        public string materialCode { get; set; }

        /// <summary>
        /// 物料描述
        /// </summary>
        public string materialDesc { get; set; }

        /// <summary>
        /// 物料组名称
        /// </summary>
        public string materialGroupName { get; set; }

        /// <summary>
        /// 物料组代码
        /// </summary>
        public string materialGroupCode { get; set; }

        /// <summary>
        /// 物料组id
        /// </summary>
        public string materialGroupId { get; set; }

        /// <summary>
        /// 截止日期
        /// </summary>
        public string endDate { get; set; }

        /// <summary>
        /// 交货回复
        /// </summary>
        public string deliveryReply { get; set; }

        #endregion

        #region 位置信息

        public int locationId { get; set; }

        /// <summary>
        /// 已经存放的试剂和耗材地址
        /// </summary>
        public List<InventoryHasLocationsItem> inventoryHasLocations { get; set; }

        /// <summary>
        /// 存放位置信息
        /// </summary>
        public string locationString { get; set; }

        /// <summary>
        /// 存放位置
        /// </summary>
        public List<LocationItem> location { get; set; }

        #endregion

        #region 使用信息

        /// <summary>
        /// 实验室id
        /// </summary>
        public int labId { get; set; }

        /// <summary>
        /// 所属项目
        /// </summary>
        public string project { get; set; }

        #endregion

        #region 附加信息
        /// <summary>
        /// 排序
        /// </summary>
        public string sort { get; set; }

        /// <summary>
        /// 添加日期
        /// </summary>
        public string addDate { get; set; }

        public string addDates { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public string updateDate { get; set; }

        public string updateDates { get; set; }

        public string map { get; set; }

        /// <summary>
        /// 拥有者
        /// </summary>
        public string owner { get; set; }

        /// <summary>
        /// 拥有者名称
        /// </summary>
        public string ownerName { get; set; }

        #endregion
    }
}