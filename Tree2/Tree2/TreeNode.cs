using System;
using System.Collections.Generic;
using System.Text;

namespace Tree2
{
    class TreeNode : INode
    {
        public string ID { get => ID; set => ID = value; }
        public string Content { get => Content; set => Content = value; }
        public bool IsReady { get => IsReady; set => IsReady = value; }
        public INode Parent { get => Parent; set => Parent = value; }
        List<TreeNode> INode.Children { get => children; set => children = value; }

        List<TreeNode> children = new List<TreeNode>();
 

        public TreeNode(string ID, string Content, bool IsReady, INode Parent)
        {
            this.ID = ID;
            this.Content = Content;
            this.IsReady = IsReady;
            this.Parent = Parent;
        }
    }
}
