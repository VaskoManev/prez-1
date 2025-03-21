namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            Stack<int> stack = new Stack<int>();

            Console.WriteLine("Въведете 10 числа:");

           
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Число {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    queue.Enqueue(number);
                }
                else
                {
                    Console.WriteLine("Невалиден вход! Въведете цяло число.");
                    i--; 
                }
            }

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            Console.WriteLine("Числата в обратен ред:");
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + " ");
            }

            Console.WriteLine(); 
        }
    }
}
