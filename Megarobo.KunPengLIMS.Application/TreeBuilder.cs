using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Megarobo.KunPengLIMS.Application
{
    public class TreeBuilder<T> where T:TreeNode<T>
    {
        private static List<T> BuildTree(Guid parentId, IEnumerable<T> dtos)
        {
            var tree = dtos.Where(d => d.ParentId == parentId).ToList();
            foreach (var item in tree)
            {
                item.Children = BuildTree(item.Id, dtos);
            }
            return tree;
        }
    }
}
