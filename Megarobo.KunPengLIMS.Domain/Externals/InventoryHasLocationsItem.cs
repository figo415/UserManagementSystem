﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Externals
{
    public class InventoryHasLocationsItem
    {
        public int id { get; set; }

        public Location location { get; set; }

        /// <summary>
        /// 存放位置信息
        /// </summary>
        public string boxInfo { get; set; }

        public int boxCols { get; set; }

        /// <summary>
        public int boxRows { get; set; }

        public string boxType { get; set; }

        public string name { get; set; }

        /// <summary>
        /// 已经存放的位置信息 数组
        /// </summary>
        public string selectList { get; set; }

        /// <summary>
        /// 已经存放的位置信息显示 数组
        /// </summary>
        public string selected { get; set; }

        public string localInfo { get; set; }
    }
}