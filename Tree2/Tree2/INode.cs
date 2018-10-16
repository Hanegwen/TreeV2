using System;
using System.Collections.Generic;
using System.Text;

namespace Tree2
{
    interface INode
    {
        
        string ID { get; set; }

        string Content { get; set; }

        bool IsReady { get; set; }
        TreeNode Parent { get; set; }
        List<TreeNode> Children { get; set; }

        
    }
}
