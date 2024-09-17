namespace DelegateExample04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Stora eller små bokstäver?";

            SomeMethod(message, TrueOrFalse);

        }
        static bool TrueOrFalse()
        {
            Console.Write("Vill du har stora bokstäver?");
            string reply = Console.ReadLine();
            bool trueOrFalse = reply.ToUpper() == "JA";
            return trueOrFalse;
        }
        static void SomeMethod(string s, Func<bool> method)
        {
            if (method())
                Console.WriteLine(s.ToUpper());
            else
                Console.WriteLine(s.ToLower());
        }
    }
}
