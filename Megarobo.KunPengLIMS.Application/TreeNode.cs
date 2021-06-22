using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application
{
    public abstract class TreeNode<T>
    {
        public Guid Id { get; set; }

        public Guid ParentId { get; set; }

        public List<T> Children { get; set; }
    }
}
