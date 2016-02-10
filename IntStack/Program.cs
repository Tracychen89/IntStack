using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntStack
{
    class Program
    {

        static void Main(string[] args)
        {
            IntStack myStack = new IntStack();
            int j;
            for (j = 0; j < 50; j++)
            {
                myStack.Push(j);
            }

            myStack.Display();
            //int num = myStack.Pop();
            //num = myStack.Pop();
            //num = myStack.Pop();
            //num = myStack.Pop();
            //Console.WriteLine(num);
            Console.ReadLine();
        }
    }
    class IntStack
    {
        private int _capacity;
        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }
        private int top = -1;
        private int[] _items;
        public int[] Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public IntStack()
        {
            Capacity = 10;
            Items = new int[Capacity];
        }
        public IntStack(int capacity)
        {
            Capacity = capacity;
            Items = new int[Capacity];
        }

        protected void IncreaseCapacity()
        {
            this.Capacity++;
            this.Capacity *= 2;
            int[] tempItems = new int[Capacity];
            int i;
            for (i = 0; i <= top; i++)
            {
                tempItems[i] = Items[i];
            }
            this.Items = tempItems;

        }

        public void Push(int element)
        {
            if (top == (Capacity - 1))
            {
                IncreaseCapacity();
                //Console.WriteLine("Stack is full!");


            }

            Items[++top] = element;
            Console.WriteLine("Item pushed successfully!");



        }

        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return 0;

            }
            else
            {
                return Items[top--];
            }
        }

        public int Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty!");
                return 0;
            }
            else
            {
                return Items[top];
            }
        }
        public void Display()
        {
            for (int i = top; i > -1; i--)
            {
                Console.WriteLine(Items[i]);
            }

        }
    }


}
