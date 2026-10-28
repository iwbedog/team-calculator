namespace TeamCalculator
{
    partial class Program
    {
        static void Divide()
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль.");
                return;
            }
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
    }
}
