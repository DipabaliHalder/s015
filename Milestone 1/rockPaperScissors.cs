using System;

namespace Practice
{
    class Program
    {
        static string turn(int n){
            string res="";
            switch(n){
                case 1: res="Rock";break;
                case 2: res="Paper";break;
                case 3: res="Scissors";break;
            }
            return res;
        }
        static void Main(string[] args)
        {       
            do{
                Console.Write("Enter the no. of rounds: ");
                int r=int.Parse(Console.ReadLine());
                if(r<=10 && r>=1){
                    int uw=0,cw=0,tie=0;
                    for(int i=1;i<=r;i++){
                        Console.Write("Enter your choice(1-Rock 2-Paper 3-Scissors): ");
                        int u=int.Parse(Console.ReadLine());
                        Random rnd=new Random();
                        int c=rnd.Next(1,4);
                        if(u>=1 && u<=3){
                            Console.WriteLine("\nYour Choice: {0} \nComputer Choice: {1}",turn(u),turn(c));
                            if(u==c){Console.WriteLine("It's a Tie...");tie++;}
                            else if(u==1 && c==2){Console.WriteLine("You Loose...");cw++;}
                            else if(u==1 && c==3){Console.WriteLine("You Win...");uw++;}
                            else if(u==2 && c==1){Console.WriteLine("You Win...");uw++;}
                            else if(u==2 && c==3){Console.WriteLine("You Loose...");cw++;}
                            else if(u==3 && c==1){Console.WriteLine("You Loose...");cw++;}
                            else {Console.WriteLine("You Win...");uw++;}
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\nWin: {0}\t Loss: {1} \t Tie: {2}",uw,cw,tie);
                    if(uw>cw)Console.WriteLine("You Win!!");
                    else if(uw<cw)Console.WriteLine("You Loose!!");
                    else Console.WriteLine("Its a tie!!");
                }
                else{
                    Console.WriteLine("Please enter in range 1-10");
                }
                Console.WriteLine("Do you want to continue?(Yes/No)");
                string choice=Console.ReadLine();
                if(choice=="Yes")continue;
                else {Console.WriteLine("Thanks for playing!");break;}
            }while(true);
        }
    }
}
