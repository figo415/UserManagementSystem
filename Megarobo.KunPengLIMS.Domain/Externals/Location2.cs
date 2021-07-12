using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Externals
{
    public class LocationRoot2 : ApiResponse
    {
        public LocationData2 data { get; set; }
    }

    public class LocationData2
    {
        public List<Location2> locationList { get; set; }
    }

    public class Location2
    {
        /// <summary>
        /// 库存id
        /// </summary>
        public int value { get; set; }

        public string label { get; set; }

        /// <summary>
        /// 盒子id
        /// </summary>
        public int? boxId { get; set; }

        /// <summary>
        /// 父id
        /// </summary>
        public int pid { get; set; }

        /// <summary>
        /// 实验室id
        /// </summary>
        public int? labId { get; set; }

        /// <summary>
        /// 位置名称
        /// </summary>
        public string name { get; set; }

        public List<Location> children { get; set; }

        /// <summary>
        /// 盒子列数
        /// </summary>
        public int? boxCols { get; set; }

        /// <summary>
        /// 盒子行数
        /// </summary>
        public int? boxRows { get; set; }

        /// <summary>
        /// 盒子类型
        /// </summary>
        public string boxType { get; set; }

        public List<string> selectedList { get; set; }

        public List<BoxStore> boxStore { get; set; }

        /// <summary>
        /// 存放信息
        /// </summary>
        public string localInfo { get; set; }
    }
}
