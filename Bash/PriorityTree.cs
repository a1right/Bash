using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bash
{
    public class PriorityTree
    {
        public Node Root { get; private set; }
        public void AddRight(Command command)
        {
            var node = new Node(command);
            if (Root == null)
                Root = new Node(command);
            var currentNode = Root;
            while(currentNode.Right != null)
            {
                currentNode = currentNode.Right;
            }
            currentNode.AddRight(node);
        }
        public void AddLeft(Command command)
        {
            var node = new Node(command);
            if (Root == null)
                Root = new Node(command);
            var currentNode = Root;
            while (currentNode.Left != null)
            {
                currentNode = currentNode.Left;
            }
            currentNode.AddRight(node);
        }
    }
}
