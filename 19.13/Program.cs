namespace _19._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeri = new List<int> { 4, 2, 1, 45, 15, 28, 19, 3, 2, 5, 2 };
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("errore");  
            }
            int count = 0;
            foreach (int n in numeri)
            {
                if(n==x)
                    count++;
            }

            if (count == 1)
                Console.WriteLine($"il numero {x} è stato trovato {count} volta");
            else
                Console.WriteLine($" il numero {x} è stato trovato {count} volte ");
        }
    }
}
