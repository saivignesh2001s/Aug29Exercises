using System.Globalization;

namespace Aug29Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Userstack<int> u = new Userstack<int>();
            u.AddorEdit(0, 22);
            u.AddorEdit(1, 24);
            int k=u.Returndata(1);
            Console.WriteLine(k);
            u.showdata(1);
            Console.ReadLine();
    

        }

    }
    class Userstack<T>
    {
        T[] data = new T[10];
        public void AddorEdit(int index,T str)
        {
            if(index>=0 && index <= 10)
            {
                data[index]=str;
            }
        }
        public T Returndata(int index)
        {
            if(index>=0 && index<=10)
            {
                return data[index];
            }
            else
            {
                return default(T);
            }
        }
        public void showdata(int index)
        {
            Console.WriteLine(data[index]);

        }
    }
}