using System.Globalization;

namespace Aug29Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            queue1 u = new queue1();
            Console.WriteLine("Enqueued elements");
            u.enqueue(20);
            u.enqueue(30);
            u.enqueue(40);
            u.enqueue(50);
            u.printallelemnts();
            Console.WriteLine("dequeued elemnts");
            u.dequeue();
            u.dequeue();
            u.dequeue();
            Console.WriteLine("elemnts enqueue again");
            u.enqueue(80);
            u.enqueue(90);
            u.printallelemnts();
            Console.WriteLine("Elements at front and back");
            u.frontal();
            u.back();
            Console.ReadLine();

            
        }
    }
    public class queue1
    {
        int[] queue = new int[1000];
        int rear=-1;
        int front=0;
        public void enqueue(int data)
        {
            if (queue.Length > 1000)
            {
                Console.WriteLine("queue is full");
            }
            else
            {
                queue[++rear] = data;
              
            }

        }
        public void dequeue()
        {
            if (front == rear+1)
            {
                Console.WriteLine("dequeue can't be possible");
            }
            else
            {
                int k = queue[front];
                    front++;
                Console.WriteLine(k);
            }
        }
        public void frontal()
        {
            if (front == -1)
            {
                Console.WriteLine("No elements");
            }
            int data = queue[front];
            Console.WriteLine(data);

        }
        public void back()
        {
            if (rear == -1)
            {
                Console.WriteLine("No elements found");
            }
            else
            {
                int data = queue[rear];
                Console.WriteLine(data);
            }

        }
        public void printallelemnts()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue empty");
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(queue[i]);
                }
            }
        }
    }
}