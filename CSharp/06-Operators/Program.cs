namespace Operators;

public class Program
{
    public static void Main(string[] args)
    {
        //Assignment Operator
        //int x = 10;
        //Console.WriteLine(x);

        //Arithmetic operator
        //Console.WriteLine("Enter a two numbers: ");
        //string fNum = Console.ReadLine();
        //string sNum = Console.ReadLine();

        //int f = Int32.Parse(fNum);
        //int s = Int32.Parse(sNum);

        //int total = f + s;
        //Console.WriteLine("Addition of two numbers: " + total);
        //Console.ReadKey();

        //total = f - s;
        //Console.WriteLine("Subtraction of two numbers: " + total);
        //Console.ReadKey();

        //total = f * s;
        //Console.WriteLine("Multiplication of two numbers: " + total);
        //Console.ReadKey();

        //total = f / s;
        //Console.WriteLine("Division of two numbers: " + total);
        //Console.ReadKey();

        //Relational Operator:
        //int x = 15;
        //int y = 10;

        //bool z = x == y; //equal to
        //Console.WriteLine(z); //False

        //bool z1 = x < y; // less than
        //Console.WriteLine(z1);

        //bool z2 = x > y; //greater than
        //Console.WriteLine(z2);

        //bool z3 = x <= y; //less than or equal to
        //Console.WriteLine(z3);

        //bool z4 = x >= y;
        //Console.WriteLine(z4); // greater than or equal to

        //bool z5 = x != y;
        //Console.WriteLine(z5); //Not equal to

        //Logical Operator:

        //int x = 20;
        //int y = 20;

        //int a = 20;
        //int b = 15;

        //bool z1 = (x == y) && (a < b);
        //Console.WriteLine(z1);

        //bool z2 = (x == y) || (a < b);
        //Console.WriteLine(z2);

        //Unary Operator:

        //int x = 25;
        //Console.WriteLine(-x);
        //Console.WriteLine("Post Increment: ");
        //Console.WriteLine(x++);
        //Console.WriteLine(x);
        //Console.WriteLine("Pre Increment: ");
        //Console.WriteLine(++x);
        //Console.WriteLine("Post Decrement: ");
        //Console.WriteLine(x--);
        //Console.WriteLine(x);
        //Console.WriteLine("Pre Decrement: ");
        //Console.WriteLine(--x);

        //int a = 10;
        //int b = 30;
        //bool z = a < b;
        //Console.WriteLine(!z);

        //Ternary Operator:

        int num1 = 17;
        int num2 = 12;

        string result = (num1 > num2) ? $"{num1} is greater than {num2}" : $"{num1} is less than {num2}";
        Console.WriteLine(result);



    }
}