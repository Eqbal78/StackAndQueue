using System;
using System.Collections;
using StackAndQueue.StackLinkedList;
using StackAndQueue.QueueLinkedList;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Stack and Queue Operations!");

            while (true)
            {
                //Creating object for stack operations
                Oueue<int> queue = new Oueue<int>();
                Stack<int> stack = new Stack<int>();
                Console.WriteLine("*********************************************");
                Console.WriteLine("\nChoose an Options.");
                Console.WriteLine("1. Stack push Element \n2. Stack Pop Element \n3. Queue Enqueue Element \n4. Queue Dequeue Element \n5. Exit");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        //Push operations
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        //Display operation
                        Console.Write("\n-----DISPLAYING STACK ELEMENTS-----\n\n");
                        stack.Display();
                        break;

                    case 2:
                        //Push operations
                        int count = 0;
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        //Display operation
                        Console.Write("\n-----DISPLAYING STACK ELEMENTS-----\n\n");
                        count = stack.Display();
                        Console.WriteLine("\n---------------------------------");
                        stack.Peek();
                        //Pop operation
                        for (int i = 0; i <= count; i++)
                        {
                            stack.Pop();

                        }
                        break;

                    case 3:
                        
                        //Add operation
                        queue.Enqueue(56);
                        queue.Enqueue(30);
                        queue.Enqueue(70);

                        //Display operation
                        Console.Write("\n-----DISPLAYING QUEUE ELEMENTS-----\n\n");
                        queue.DisplayQueue();
                        
                        break;

                    case 4:
                        ///Oueue<int> dequeue = new Oueue<int>();
                        int total = 0;
                        queue.Enqueue(56);
                        queue.Enqueue(30);
                        queue.Enqueue(70);

                        //Display operation
                        Console.Write("\n-----DISPLAYING QUEUE ELEMENTS-----\n\n");
                        total = queue.DisplayQueue();
                        for (int i = 0; i <= total; i++)
                        {
                            queue.Dequeue();
                        }
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invailed Number");
                        break;
                }
                
            }

        }

       
    }    
}
