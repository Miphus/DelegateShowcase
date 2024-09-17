namespace DelegatesExample03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> twoNumbers = IsLessThan;
            Console.WriteLine(twoNumbers(1, 100));
            Console.WriteLine(twoNumbers(100, 50));
        }
        static bool IsLessThan(int a, int b)
        {
            return a < b;
        }
    }
}
