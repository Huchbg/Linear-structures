using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linear_structures
{
    internal class CoolLinkedList<Type>
    {
        private Node<Type> head;
        public void Add(Type value)
        {
            if (head == null) 
            {
                head = new Node<Type>(value);
            }
            else
            {
                Node<Type> newHead = new Node<Type>(value);
                newHead.Next= head;
                head = newHead;
            }
        }
        public Type Head { get
            {
                if (head==null)
                {
                   
                    return default;
                }
                return head.Value;
            }
        }
        public Type RemoveHead()
        {
            if (head == null)
            {
                throw new OutOfRangeException("Head doesn't exist");
            }
            Node<Type> oldHead= head;
            head = oldHead.Next;
            return oldHead.Value;
        }
        public CoolLinkedList()
        {
            head = null;
        }

    }
}
