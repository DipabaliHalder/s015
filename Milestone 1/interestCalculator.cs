using System;

namespace Practice;
public class Program{
    public static void Main(string[] args){
        Console.Write("How much do you want to invest? ");
        decimal a = Convert.ToDecimal(Console.ReadLine());
        Console.Write("How many years are investing? ");
        int y=Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the annual interest rate % growth? ");
        int r=Convert.ToInt32(Console.ReadLine());
        
        Console.Write("\nCalculating...\nCalculating...\n");

        decimal e;
        for(int i=1;i<=y;i++){
            Console.WriteLine("Year {0}:",i);
            Console.WriteLine("Began with ${0}",a);
            e=a*(1+((decimal)r/100));        
            Console.WriteLine("Earned ${0}",e-a);
            Console.WriteLine("Ended with ${0}\n\n",e);
            a=e;
        }
    }
}
