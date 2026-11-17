using System.Transactions;

namespace ConsoleMethods;

public class Program
{
    public static void Main(string[] args)
    {
        //Console Methods
        //Console.Write() - Same Line
        //Console.WriteLine() - New Line
        //Console.Read() - ASCII
        //Console.ReadLine() - Raw Input
        //Console.ReadKey() - Hold to Read

        //Console.Write("Hello");
        //Console.Write("World");

        Console.WriteLine("Hello");
        Console.WriteLine("World");

        //Read

        //Console.WriteLine("Please enter a Value");
        //int a = Console.Read();
        //Console.WriteLine(a);

        
        Console.WriteLine("Enter a two numbers");
        string x = Console.ReadLine();
        string y = Console.ReadLine();

        int num1 = Int32.Parse(x);
        int num2 = Int32.Parse(y);

        Console.WriteLine(num1 + num2);

        Console.ReadKey();

    }
}