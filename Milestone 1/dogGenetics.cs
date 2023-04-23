using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {              
              Console.Write("What is your dog's name? ");
              string name=Console.ReadLine();
              Console.WriteLine("Well then, I have this highly reliable report on {0} prestigious background right here. \n\n{0} is: ",name);
              Random r=new Random();
              int p1=r.Next(1,101);
              int p2=r.Next(1,101-p1);
              int p3=r.Next(1,101-(p2+p1));
              int p4=r.Next(1,101-(p2+p1+p3));
              Console.WriteLine("{0}% St. Bernard",p1);
              Console.WriteLine("{0}% Chihuahua",p2);
              Console.WriteLine("{0}% Dramatic RedNosed Asian Pug",p3);
              Console.WriteLine("{0}% Common Cur",p4);
              Console.WriteLine("{0}% King Doberman",100-p1-p2-p3-p4);
              Console.WriteLine("\n\nWow, that's QUITE the dog!");
        }
    }
}
