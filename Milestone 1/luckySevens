using System;

namespace Practice;
public class Program{
    public static void Main(string[] args){
        Console.Write("How many dollars do you have? ");
        int d=Convert.ToInt32(Console.ReadLine());
        int dice1,dice2,cnt=1,max=d,maxcnt=0;
        Random r=new Random();
        while(d!=0){
            dice1=r.Next(1,7);
            dice2=r.Next(1,7);
            if(dice1+dice2==7)d+=4;
            else d-=1;
            if(max<d) {
                max=d;
                maxcnt=cnt;
            }
            cnt++;
        }
        Console.WriteLine("You are broke after {0} rolls.",cnt);
        Console.WriteLine("You should have quit after {0} rolls when you had ${1}.",maxcnt,max);
    }
}
