using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bash
{
    public class Node
    {
        public ICommand Command { get; init; }
        public Node Left { get; private set; }
        public Node Right { get; private set; }
        public Node Previous { get; private set; }
        public bool IsChecked { get; private set; }
        public Node(ICommand command)
        {
            Command = command;
        }
        public void AddRight(Node node)
        {
            Right = node;
            node.Previous = this;
        }
        public void AddLeft(Node node)
        {
            Left = node;
            node.Previous = this;
        }
    }
}
