namespace DelegateExample01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Action carAction = Accelerate;
            carAction();

            carAction = Decelerate;
            carAction();
        }
        static void Accelerate()
        {
            Console.WriteLine("Gasar!");
        }
        static void Decelerate()
        {
            Console.WriteLine("Bromsar!");
        }
    }
}
