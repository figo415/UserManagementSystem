using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    /// <summary>
    /// 菜单
    /// 与Role多对多
    /// </summary>
    public class Menu:AuditableEntity
    {
        public string Name { get; set; }

        // 类型：0目录；1页面，2按钮
        public int Type { get; set; }

        public Guid ParentId { get; set; }

        public string Code { get; set; }

        public string Url { get; set; }

        public int OrdinalNumber { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<RoleMenu> Roles { get; set; }

        //路由路径
        public string Path { get; set; }

        //路由对应组件
        public string Component { get; set; }

        //重定向地址
        public string Redirect { get; set; }

        //是否侧边栏显示，默认False
        public bool Hidden { get; set; }

        //一直显示根路由，默认False
        public bool AlwaysShow { get; set; }

        //子路由，仅返回时出现，不存数据库
        public List<Menu> Children { get; set; }

        //路由元信息，仅返回时出现，不存数据库
        public object Meta { get; set; }

        //标题
        public string Title { get; set; }

        //图标，属于Meta
        public string Icon { get; set; }

        //是否缓存，默认False，属于Meta
        public bool NoCache { get; set; }

        //是否在面包屑中显示，默认True，属于Meta
        public bool BreadCrumb { get; set; }

        //是否固定在tagsView中，默认False，属于Meta
        public bool Affix { get; set; }

        //高亮路由，属于Meta
        public string ActiveMenu { get; set; }
    }
}
