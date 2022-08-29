using System.Globalization;

namespace Aug29Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Userstack<string> u = new Userstack<string>();
            u.Push("America");
            u.Push("Russia");
            u.Push("India");
            Console.WriteLine("Popped element");
            u.Pop();
            Console.WriteLine("Elements at present");
            u.printData();
            Console.WriteLine("Top element at present");
            string k = u.Peek();
            Console.WriteLine(k);
            Console.ReadLine();
           

        }

    }
    class Userstack<T>
    {
        internal static int max = 1000;
        T[] stack=new T[max];
        int top=-1;
        public void Push(T str)
        {
            if (top >= 1000)
            {
                Console.WriteLine("can't push");
            }
            else
            {
                stack[++top] = str;
            }
        }
        public void Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("No elements there to pop");
            }
            else
            {
                T value=stack[top--];
                Console.WriteLine(value);
            }
        }
        public T Peek()
        {
            if (top < 0)
            {
                return default(T);
            }
            else
            {
                T value = stack[top];
                return value;
            }
        }
        public void printData()
        {
            for(int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
}