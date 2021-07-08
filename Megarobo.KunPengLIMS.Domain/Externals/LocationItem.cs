using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Externals
{
    public class LocationItem
    {
        /// <summary>
        /// 库存id
        /// </summary>
        public int value { get; set; }

        public string label { get; set; }

        /// <summary>
        /// 盒子id
        /// </summary>
        public int boxId { get; set; }

        /// <summary>
        /// 父id
        /// </summary>
        public int pid { get; set; }

        /// <summary>
        /// 实验室id
        /// </summary>
        public string labId { get; set; }

        /// <summary>
        /// 位置名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 盒子列数
        /// </summary>
        public string boxCols { get; set; }

        /// <summary>
        /// 盒子行数
        /// </summary>
        public string boxRows { get; set; }

        /// <summary>
        /// 盒子类型
        /// </summary>
        public string boxType { get; set; }

        public string selectedList { get; set; }

        public List<BoxStoreItem> boxStore { get; set; }

        /// <summary>
        /// 存放信息
        /// </summary>
        public string localInfo { get; set; }
    }
}
