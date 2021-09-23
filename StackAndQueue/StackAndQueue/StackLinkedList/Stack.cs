using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.StackLinkedList
{
    /// <summary>
    /// Create Generic type Stack LinkedList class
    /// </summary>
    /// <typeparam name="Gtype"></typeparam>
    public class Stack<Gtype>
    {
        Node<Gtype> top;
        /// <summary>
        /// Constructor
        /// </summary>
        public Stack()
        {
            this.top = null;
        }

        /// <summary>
        /// Method to Push data at Top
        /// </summary>
        /// <param name="value"></param>
      
        public void Push(Gtype value)
        {
            //Create Empty Node
            Node<Gtype> newNode = new Node<Gtype>(value);

            //Top Node Empty then New Node is Equal to Top
            if (this.top == null)
            {
                this.top = newNode;
            }
            else
            {
                newNode.next = top;
                this.top = newNode;
            }
            
            Console.WriteLine("Stack Push element is: "+ value);
        }

   
        /// <summary>
        /// Display stack data
        /// </summary>
        public void Display()
        {
            Node<Gtype> temp = top;
            int count = 0;
            //
            while (temp != null)
            {
                count++;
                Console.WriteLine("Stack element at {0} is: {1}", count, temp.data);
                temp = temp.next;
            }
        }
    }
}
