using System;

namespace Tree2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTree tree = new DataTree();
            bool KeepRunningInput = true;
            do
            {
                Console.WriteLine("Type In What You Would Like To Do and Press Enter");

                Console.WriteLine("1: NOT DONE ADD To Tree via Console");
                Console.WriteLine("2: NOT DONE ADD To Tree via Document");
                Console.WriteLine("3: Get a Node");
                Console.WriteLine("4: Add a Node");
                Console.WriteLine("5: Delete a Node");
                Console.WriteLine("6: Move a Node");
                Console.WriteLine("7: Find Node based on ID");
                Console.WriteLine("8: Find Node based on Contents");

                string Input = Console.ReadLine();

                switch (Input)
                {
                    case "1":
                        Console.WriteLine("What will the new data be");
                        string newData = Console.ReadLine();

                        tree.AddNewNodesForTrees(newData);
                        break;
                    case "2":
                        break;
                    case "3":
                        string inputID = Console.ReadLine();

                        tree.Get(inputID, true);
                        break;
                    case "4":
                        string dataToAdd = Console.ReadLine();
                        string parentID = Console.ReadLine();

                        tree.AddNode(dataToAdd, parentID);
                        break;
                    case "5":
                        string NodeToDelete = Console.ReadLine();

                        tree.DeleteNode(NodeToDelete);
                        break;
                    case "6":
                        string NodeToMove = Console.ReadLine();
                        string NewParent = Console.ReadLine();

                        tree.MoveNode(NodeToMove, NewParent);
                        break;
                    case "7":
                        string IDOfNode = Console.ReadLine();

                        tree.FindNodeID(IDOfNode);
                        break;
                    case "8":
                        string FindNodeContent = Console.ReadLine();

                        tree.FindNodeConent(FindNodeContent);
                        break;
                    default:
                        KeepRunningInput = false;
                        break;
                }

                //Need To Add via Console
                //Need to Add via Text File
            } while (KeepRunningInput);

            foreach(TreeNode node in DataTree)
            {
                Console.WriteLine(node.Content);
            }
        }

        
    }
}
