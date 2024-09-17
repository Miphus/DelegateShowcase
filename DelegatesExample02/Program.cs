namespace DelegatesExample02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = ("Kommer det bli stora eller små bokstäver?");
            
            Action<string, bool> print = PrintIt;
            print(message, true);
            print(message, false);
        }
        static void PrintIt(string s, bool b)
        {
            if (b)
                Console.WriteLine(s.ToUpper());
            else
                Console.WriteLine(s.ToLower());
        }
    }
}
