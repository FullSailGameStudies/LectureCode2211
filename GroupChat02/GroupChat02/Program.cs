using PG2Input;
using System.Dynamic;

namespace GroupChat02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            Input.GetString("What is your name? ", ref name);

            string[] options = new string[] { "1. Hello World", "2. Exit" };
            int selection;
            do
            {
                Console.Clear();
                Console.WriteLine($"Hello, {name}!");
                Input.GetMenuChoice("Menu selection: ", options, out selection);
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Hello Gotham!!");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            } while (selection != options.Length);
        }
    }
}