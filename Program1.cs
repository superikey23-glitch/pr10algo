namespace Pr10algo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a b c через пробел");
            string[] abc = Console.ReadLine().Split(" ");
            int a = int.Parse(abc[0]);
            int b = int.Parse(abc[1]);
            int c = int.Parse(abc[2]);
            if (a==0)
            {
                if (b == 0) 
                {
                    if (c == 0) 
                    {
                        Console.WriteLine("X - любое");
                    } else
                    {
                        Console.WriteLine("Нет решения");
                    }
                } else
                {
                    double x = -c / b;
                    Console.WriteLine(x);
                }
            } else
            {
                double D = b * b - 4 * a * c;
                if (D > 0)
                {
                    D = Math.Sqrt(D);
                    double x1 = (-b-D) / (2 * a);
                    double x2 = (-b+D) / (2 * a);
                    Console.WriteLine($"Ответ: x1={x1}, x2={x2}");
                }
                else 
                {
                    if (D == 0)
                    {
                        double x = -b / (2 * a);
                        Console.WriteLine(x);
                    }
                    else 
                    {
                        Console.WriteLine("Нет решения");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
