namespace stringoperations;

public class Program
{
    public static void Main(string[] args)
    {
        //String and its Method 
        //String Manipulation
        //Concatenation //Formatting {0}{1},a,b; //Interpolation ${a}{b}
        //string Methods
        //UpperCase and Lowercase //Substring //Trim 
        //String Operations
        //Index of
        //IsNullorWhiteSpace - null or blank true or false

        string firstName = "John";
        string lastName = "Doe";
        int age = 27;
        Console.WriteLine(firstName);
        Console.WriteLine(lastName);
        Console.WriteLine(firstName + " " + lastName + " and my age is " + age);
        Console.WriteLine("{0} {1} and my age is {2}", firstName, lastName, age);
        Console.WriteLine($"{firstName} {lastName} and my age is {age}");

        //String Methods
        string Name = "Johnwick";
        string UpperName = Name.ToUpper();
        Console.WriteLine(UpperName);

        string LowerName = Name.ToLower();
        Console.WriteLine(LowerName);

        string fullName = string.Concat(" " + Name + " ");
        Console.WriteLine(fullName);
        Console.WriteLine(fullName.Trim());

        //String Operations
        Console.WriteLine(Name.IndexOf("J"));

        bool checker = String.IsNullOrWhiteSpace(fullName);
        Console.WriteLine(checker);

        

    }
}
