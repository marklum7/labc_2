internal static class MainHelpers
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите N:");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите x:");
        int x = int.Parse(Console.ReadLine());
        double result = 0.0;
        if (x < 1)
        {
            for (int i = 0; i <= N; ++i)
            {
                result = result + Math.Pow((double)x, (double)(2 * x + 1)) / 2.0 * (double)i + 1.0;
            }

            Console.WriteLine(2.0 * result);
        }
        else
        {
            Console.WriteLine("ОШИБКА");
        }

    }
}