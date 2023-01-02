using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_structures
{
    internal class Node<Type>
    {
        public Type Value { get; set; }
        public Node<Type> Next { get; set; }

        public Node(Type data)
        {
            Value = data;
            Next = null;
        }
    }
}
