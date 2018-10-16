using System;
using System.Collections.Generic;
using System.Text;

namespace Tree2
{
    class DataTree
    {
        public List<INode> branches = new List<INode>();

        public void AddNewNodesForTrees(string newData)
        {
            string Random = newData + branches.Count;

            TreeNode newNode = new TreeNode(Random, newData, true, null);
            branches.Add(newNode);
        }

        public INode Get(string Id, bool shouldGetBranch) //Needs to Decide Should Get Branch
        {
            INode branchToReturn = null;

            foreach(INode branch in branches)
            {
                if(branch.ID == Id)
                {
                    branchToReturn = branch;
                }
            }

            if(shouldGetBranch)
            {
                return branchToReturn;
            }

            else
            {
                return branchToReturn;
            }
        }

        public void AddNode(string toAdd, string parentId) //Maybe Works
        {
            INode parent = null;
            foreach(INode branch in branches)
            {
                if(branch.ID == parentId)
                {
                    parent = branch;
                }
            }
            TreeNode newNode = new TreeNode("Random ID", toAdd, true, parent);

            branches.Add(newNode);
        }

        public void DeleteNode(string objectId) //Works
        {
            foreach (INode branch in branches)
            {
                if (branch.ID == objectId)
                {
                    branch.Children.Clear();
                    branches.Remove(branch);
                }
            }
        }

        public void MoveNode(string objectId, string parentId)
        {

        }

        public INode FindNodeID(string id) //Works
        {
            foreach(INode branch in branches)
            {
                if(branch.ID == id)
                {
                    return branch;
                }
                else
                {
                    return null;
                }
            }

            return null;
        }

        public INode FindNodeConent(string content) //Works
        {
            foreach (INode branch in branches)
            {
                if (branch.Content == content)
                {
                    return branch;
                }
                else
                {
                    return null;
                }
            }

            return null;
        }
    }
}
