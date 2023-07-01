// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Runtime.InteropServices;



public class Program
{
    public static void Main(string[] args)
    {
        int PrintValue1 = PrintValue(10, 20);
        Console.WriteLine(PrintValue1);
        int PrintValue2 = PrintValue(true);
        Console.WriteLine(PrintValue2);
        PrintValue("Ayaq", "qabı");
        int PrintValue4 = PrintValue(9, 6, 5);
        Console.WriteLine(PrintValue4);
        



    }
    public class MathHelper 
    { 

    }
    public static int PrintValue(int a ,int b)
    {
        return a + b;
    }
    public static int PrintValue(bool c)
    {
        if (c == false) return 0; 
        else return 1;
    }
    public  static void  PrintValue(string d,string f)
    {
        Console.WriteLine(d+f);
    }
    public static int PrintValue(int z,int k,int p)
    {
        return z * k * p;
    }
    

}