using System.Runtime.CompilerServices;

namespace TypeConversion;

public class Program
{
    public static void Main(string[] args)
    {
        //Typeconversion:
        //Integer to string
        //Floating point to string
        //Double to string
        //Boolean to string

        //Explicit conversion:
        //Floating point => Integer

        //Implicit Conversion
        //Small to Large [Integer => Long or Float => Double]

        int ai = 10;
        Console.WriteLine(ai);
        Console.WriteLine(ai.GetType());

        //Int to String Conversion
        string anumber = ai.ToString();
        Console.WriteLine(anumber.GetType());

        long al = 9999999999999;
        Console.WriteLine(al);
        Console.WriteLine(al.GetType());

        //Long to string Conversion
        string lnumber = al.ToString();
        Console.WriteLine(lnumber.GetType());

        //Float to string Conversion [Simple format]
        float af = 3.145f;
        Console.WriteLine(af.ToString().GetType());

        //Double to string Conversion
        double ad = 4.5667899876;
        Console.WriteLine(ad.ToString().GetType());

        //Bool to string Conversion
        bool ab = true;
        Console.WriteLine(ab.ToString().GetType());

        //Explicit Conversion [float to Integer]
        float aff = 3.1456f;
        Console.WriteLine(aff.GetType);
        int afn = (int)aff; //float to Integer conversion
        Console.WriteLine(afn);

        //Implicit Conversion [Small to large]
        int aimp = 10;
        Console.WriteLine(aimp.GetType());

        long limp = aimp;
        Console.WriteLine(limp.GetType());

        float fimp = 10.534f;
        Console.WriteLine(aimp.GetType());

        Double flimp = fimp;
        Console.WriteLine(flimp.GetType());

        //String to integer Conversion
        string stra = "10";
        Console.WriteLine(stra);
        Console.WriteLine(stra.GetType());

        int stoi = Int32.Parse(stra);
        Console.WriteLine(stoi.GetType());

        //string strname = "Mohan";
        //Console.WriteLine(strname);
        //Console.WriteLine(strname.GetType());

        //int stoint = Int32.TryParse(strname);
        //Console.WriteLine(stoint.GetType());
    }
}