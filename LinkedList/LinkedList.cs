﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    //Non-Generic LinkedList
    public class LinkedList
    {
        public LinkedList()
        {
            Head = new Node();
            Current = Head;
        }

        public Node Head;
        public Node Current;
        public int Count = 0;

        public void AddAtStart(object value)
        {
            var newNode = new Node()
            {
                Value = value
            };
            newNode.Next = Head.Next;
            Head.Next = newNode;
            ++Count;
        }

        public void RemoveFromStart()
        {
            if (Count <= 0)
            {
                //throw new Exception("There are no elements to remove");
                return;
            }
            

            Head.Next = Head.Next.Next;
            --Count;
        }

        public void PrintAllNodes()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("Head -> ");
            Node curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                stringBuilder.Append(curr.Value); //If using a reference type (any class/interface), you will need to override ToString for this to work.
                stringBuilder.Append(" -> ");
            }
            stringBuilder.Append("NULL");
            //stringBuilder.AppendLine();
            return stringBuilder.ToString();
        }
    }

    //Linked List using Generics
    public class LinkedList<T> where T : class
    {
        public LinkedList()
        {
            Head = new Node<T>();
            Current = Head;
        }
        public Node<T> Head;
        public Node<T> Current;
        public int Count = 0;

        public void AddAtStart(T value)
        {
            var newNode = new Node<T>()
            {
                Value = value
            };
            newNode.Next = Head.Next;
            Head.Next = newNode;
            ++Count;
        }

        public void RemoveFromStart()
        {
            if (Count <= 0)
            {
                throw new Exception("There are no elements to remove");
            }

            Head.Next = Head.Next.Next;
            --Count;
        }

        public void PrintAllNodes()
        {
            Console.Write("Head -> ");
            Node<T> curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write(" -> ");
            }
            Console.Write("NULL");
            Console.WriteLine();
        }
    }

    
    
}
