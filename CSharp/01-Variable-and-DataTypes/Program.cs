namespace VariableandDataTypes;

public class Program
{
    public static void Main(string[] args)
    {
        //Variable initialization:
        int a = 10;
        //Variable declaration:
        int b;
        b = 20;
        int total = (a + b);

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(total);

        //Datatypes:
        //Integer 4 bytes / int a = 10;
        //Long 8 bytes / Long b  = 99999999999999999;
        //Char 2 bytes / Char at = '@';
        //String 2 bytes per character / String Name = '@Username'
        //Boolean 1 bit / Bool isActive = true;
        //Floating point 4 bytes / Float pi = 3.1415F;
        //Double 8 bytes / Double x = 1.56;

        //int 4 bytes
        int ai = 10;
        Console.WriteLine($"Integer Datatype: {ai}");

        //long 8 bytes
        long al = 999999999999999999;
        Console.WriteLine($"Long Datatype: {al}");

        //Float 4 bytes
        float pi = 3.145f;
        Console.WriteLine($"Float Datatype: {pi}");

        //Double 8 bytes
        double ad = 32.4598748358575454;
        Console.WriteLine($"Double Datatype: {ad}");

        //Char 2 bytes
        char ac = 'm';
        Console.WriteLine($"Char Datatype: {ac}");

        //String 2 bytes per character
        string ast = "Murugan";
        Console.WriteLine($"String Datatype: {ast}");

        //bool 1 byte
        bool xb = true;
        Console.WriteLine($"Bool datatype: {xb}");


    }
}
