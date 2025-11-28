namespace Queue_Data_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new(3);
            Console.WriteLine("Empty: " + queue.IsEmpty());
            queue.EnQueue("hi");
            Console.WriteLine("Empty: " + queue.IsEmpty());
            queue.EnQueue("hello");
            Console.WriteLine("Full: " + queue.IsFull());
            Console.WriteLine(queue.DeQueue());
            Console.WriteLine("Full: " + queue.IsFull());
            queue.EnQueue("what's up");
            queue.EnQueue("yooo");
            Console.WriteLine("Full: " + queue.IsFull());
            Console.WriteLine(queue.DeQueue());
            Console.WriteLine("Full: " + queue.IsFull());
            Console.WriteLine(queue.DeQueue());
            Console.WriteLine(queue.DeQueue());
        }
    }
}
