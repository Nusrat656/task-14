
using System.Collections;

internal class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>(5);

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        stack.Pop();

        stack.Push(40);
        stack.Push(50);

        stack.Pop();
        
        foreach (var element in stack)
        {
            Console.WriteLine(element);
        }
    }
    public class MyStack<T> : IEnumerable
    {
        public int[] array;

        public int Count { get; set; }
        public int Capacity { get; set; }


        public MyStack(int capacity)
        {
            Count = -1;
            array = new int[capacity];

        }

        public void push(int element)
        {
            if (Count == Array.MaxLength - 1)
            {
                Console.Write("Stack is full. Cannot push element.");
            }
            else
            {
                Count++;
                array[Count] = element;
                Console.Write("Pushed element: " + element);
            }
        }

        public int pop()
        {
            if (Count == -1)
            {
                Console.Write("Stack is empty. Cannot pop element.");
                return -1;
            }
            else
            {
                int poppedElement = array[Count];
                Count--;
                Console.Write("Popped element: " + poppedElement);
                return poppedElement;
            }
        }

        public int peek()
        {
            if (Count == -1)
            {
                Console.Write("Stack is empty. No element to peek.");
                return -1;
            }
            else
            {
                Console.Write("Peeked element: " + array[Count]);
                return array[Count];
            }
        }

        public bool isEmpty()
        {
            return (Count == -1);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in array)
            {
                yield return item;
            }
        }
    }
}

 