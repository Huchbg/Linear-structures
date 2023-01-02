using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_structures
{
    internal class CoolStack<Type>
    {
        //The stack is implemented using our own linked list instead of creating everything from scrach
        private CoolLinkedList<Type> myLinkedList;

        public void StackPush(Type Value)
        {
            myLinkedList.Add(Value);
        }
        public Type Pop()
        {
            return myLinkedList.RemoveHead();
        }
        public Type Peek()
        {
            return myLinkedList.Head;
        }
        public CoolStack()
        {
            myLinkedList = new CoolLinkedList<Type>();
        }
    }
}
