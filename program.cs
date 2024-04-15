using System;

public class Program
{
    public static void Main(string[] args)
    {
        Calculator mine=new Calculator();
        {
            Console.Write(mine.Add(2,3));               
        }
    }
}
public class Calculator
{    
    public int Add(int a,int b)
   {
    return a+b;
   }
}
