using System;

namespace Practice;
public class Program{
    public static void Main(string[] args){
        Console.Write("What number would you like to factor? ");
        int n=Convert.ToInt32(Console.ReadLine());
        Console.Write("The factors of {0} are:\n 1",n);
        int cnt=0,s=1;
        for(int i=2;i<n;i++){
            if(n%i==0){
                Console.Write(" {0}",i);
                cnt++;
                s+=i;
            } 
        }
        Console.Write(" {0}",n);
        Console.WriteLine("\n{0} has {1} factors.",n,cnt+2);
        if(s==n){
            Console.WriteLine("{0} is a perfect number.",n);
        }
        else{
            Console.WriteLine("{0} is not a perfect number.",n);
        }
        if(cnt==0){
            Console.WriteLine("{0} is a prime number.",n);
        }
        else{
            Console.WriteLine("{0} is not a prime number.",n);
        }
    }
}
