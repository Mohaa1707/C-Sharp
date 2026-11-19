namespace firsttask;

public class Program
{
    public static void Main(string[] args)
    {
        //Get your name as input and Convert to Uppercase and Lowercase
        Console.WriteLine("Enter your Name: ");
        string myName = Console.ReadLine();
        string upName = myName.ToUpper();
        Console.WriteLine($"Name in Uppercase: {upName}");
        string lowName = myName.ToLower();
        Console.WriteLine($"Name in Lowercase: {lowName}");

        //Get two decimal as input in run time and add it the number and print it.
        Console.WriteLine("Enter the first number");
        string firstNumber = Console.ReadLine();
        Console.WriteLine("Enter the Second number");
        string secondNumber = Console.ReadLine();
        if (int.TryParse(firstNumber, out int fNum) &&
            int.TryParse(secondNumber, out int secNum))
        {
            int total = fNum + secNum;

            Console.WriteLine($"Total Number: {total}");
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter valid numbers.");
        }

        //Get firstname,lastname and age in run time and concatenate amd print it
        Console.WriteLine("Enter the first Name: ");
        string myfirstName = Console.ReadLine();
        Console.WriteLine("Enter the Second Name: ");
        string mysecondName = Console.ReadLine();
        Console.WriteLine("Enter your Age: ");
        string myage = Console.ReadLine();
        Console.WriteLine(myfirstName + " " + mysecondName + " " + "my age is " + myage);


    }
}