namespace Fun;

public class Program
{
    public static void Main(string[] args)
    {
        DisplayMessage();
        Information("Mohan",27);
        //Console.WriteLine(Calculator(10,7));
        Console.WriteLine("Please Enter a two numbers: ");
        string x = Console.ReadLine();
        string y = Console.ReadLine();

        int num1 = Int32.Parse(x);
        int num2 = Int32.Parse(y);

        Console.WriteLine(Calculator(num1, num2));
    }


    //<AccessModifier> <ReturnType> <MethodName> <Argument>
    //1.No Return type without argument
    public static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the party");
    }

    //2.No Return type with Argument

    public static void Information(string Name, int Age)
    {
        Console.WriteLine($"Welcome {Name} are your {Age} years old!");
    }

    //3.With return type without Argument

    public static int Calculator()
    {
        int a = 10;
        int b = 20;
        int total = a + b;
        return total;
    }

    //4.With return type with Argument

    public static int Calculator(int num1, int num2)
    {
        var total = 0;
        Console.WriteLine("Addition of two numbers: ");
        total = num1 + num2;
        return total;
    }
}