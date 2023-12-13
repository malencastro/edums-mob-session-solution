namespace EduMSMobSession
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Type 1 for fibonacci, type 2 for santa claus: ");
            var choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                var position = 0;
                Console.WriteLine("Enter position in fibonacci sequence: ");
                try
                {
                    position = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Input value is not a number.");
                    Environment.Exit(0);
                }
                var number = Fibonacci.GetFibonaccPosition(position);
                Console.Write("{0} ", number);
            }
            if (choice == 2)
            {
                Console.WriteLine("Input for santa: ");
                var input = Console.ReadLine();
                var level = Santa.WhereIsSanta(input);
                Console.WriteLine("Santa is at level {0}", level);
            }

            Console.ReadLine();
        }
    }
}
