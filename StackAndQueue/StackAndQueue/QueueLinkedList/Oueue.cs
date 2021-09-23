using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.QueueLinkedList
{
    /// <summary>
    /// Create Generic type Queue LinkedList class
    /// </summary>
    /// <typeparam name="Gtype"></typeparam>
    public class Oueue<Gtype>
    {
        Node<Gtype> front;

        /// <summary>
        /// Append Value at rear
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(Gtype value)
        {
            Node<Gtype> newNode = new Node<Gtype>(value);
            Append(newNode);
            Console.WriteLine("Queue Enqueue element is: " + value);
        }

        /// <summary>
        /// Create a method to Append the value
        /// </summary>
        /// <param name="newNode"></param>
        internal void Append(Node<Gtype> newNode)
        {
            if (front == null)
            {
                front = newNode;
            }
            else
            {
                Node<Gtype> temp = GetLastNode();
                temp.next = newNode;

            }
        }
        internal Node<Gtype> GetLastNode()
        {
            Node<Gtype> temp = front;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        /// <summary>
        /// Display the Queue
        /// </summary>
        public void DisplayQueue()
        {
            Node<Gtype> temp = front;
            int count = 0;
            //treverse to last node
            while (temp != null)
            {
                count++;
                Console.WriteLine("Stack element at {0} is: {1}", count, temp.data);
                temp = temp.next;
            }
            
        }

    }
}
