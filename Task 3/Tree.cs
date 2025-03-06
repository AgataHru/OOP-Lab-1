using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumbers.Task_3
{
    internal class Tree
    {
        int level;
        int value;
        public List<Tree> children;

        public Tree(int NewValue)
        {
            level = 0;
            value = NewValue;
            children = new List<Tree>();
        }

        public void AddChild(Tree child) 
        { 
            children.Add(child);
            child.level = level + 1;
        }

        public void PrintTree()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < level; i++) { 
                sb.Append("  ");
            }
            sb.Append("|");

            Console.WriteLine($"{sb.ToString()}Tree level: {level}, value: {value}");

            if (children.Count > 0) {
                foreach (Tree child in children)
                {
                    child.PrintTree();
                }
            }
        }
    }
}
