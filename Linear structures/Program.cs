using Linear_structures;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //Standart List
        Console.WriteLine("Standart List");
        ListIM<int> myList = new ListIM<int>();

        myList.Add(1);

        Console.WriteLine(myList.Count);
        Console.WriteLine();
        Console.WriteLine();
        //Linked List
        Console.WriteLine("Linked List");
        CoolLinkedList < int > myLinkedList= new CoolLinkedList<int>();
        for (int i = 0; i < 10; i++)
        {
            myLinkedList.Add(i);
        }

        Console.WriteLine(myLinkedList.Head);

        for (int i = 0; i < 10; i++)
        {
            myLinkedList.RemoveHead();
        }

        Console.WriteLine(myLinkedList.Head);
        Console.WriteLine();
        Console.WriteLine();
        //Stack
        Console.WriteLine("Stack");
        CoolStack<int> myStack=new CoolStack<int>();
        myStack.StackPush(10);
        myStack.StackPush(11);
        myStack.StackPush(12);
        myStack.StackPush(13);
        myStack.StackPush(14);
        Console.WriteLine("this is the Last added element of the stack");
        Console.WriteLine(myStack.Peek());
        Console.WriteLine("this is the Last added element of the stack ,but now the element has been removed");
        Console.WriteLine(myStack.Pop());
        Console.WriteLine("this is the elemet that came before the last top , but is now the top because we poped the last");
        Console.WriteLine(myStack.Peek());



        Console.ReadLine();
    }
}