using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.StackLinkedList
{
    /// <summary>
    /// Generic Class Node
    /// </summary>
    /// <typeparam name="Gtype"></typeparam>
    class Node<Gtype>
    {
        /// <summary>
        /// Declere Generic type Variable
        /// </summary>
        public Gtype data;
        public Node<Gtype> next;

        /// <summary>
        /// Constructor With Generic type Parameter
        /// </summary>
        /// <param name="data"></param>
        public Node(Gtype data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
