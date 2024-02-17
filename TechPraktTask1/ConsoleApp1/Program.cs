internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть перше число:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть друге число:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double sum = num1 + num2;
        Console.WriteLine($"Сума чисел {num1} і {num2} дорівнює {sum}");
    }
}