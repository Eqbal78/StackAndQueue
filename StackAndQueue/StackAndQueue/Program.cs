using System;
using System.Collections;
using StackAndQueue.StackLinkedList;

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
                Stack<int> stack = new Stack<int>();
                Console.WriteLine("*********************************************");
                Console.WriteLine("\nChoose an Options.");
                Console.WriteLine("1. Stack push Element \n2. Stack Pop Element \n3. Exit");
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
