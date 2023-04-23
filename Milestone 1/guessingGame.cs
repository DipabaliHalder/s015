using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int theAnswer;
            int playerGuess;
            string playerInput;
            int cnt=0,limit=0;

            Console.Write("MENU:-\n 1-Easy Mode 1-5\n 2-Normal Mode 1-20\n 3-Hard Mode 1-50 \nEnter your choice: ");
            int ch=int.Parse(Console.ReadLine());
            if(ch==1 || ch==2 || ch==3){
                if(ch==1) limit=6;
                else if(ch==2) limit=21;
                else limit=51;
                Console.Write("Enter your name: ");
                string name=Console.ReadLine();

                Random r = new Random();
                theAnswer = r.Next(1, limit);

                do
                {
                    // get player input
                    Console.ForegroundColor=ConsoleColor.White;
                    Console.Write("Enter your guess {0}(1-{1}): ",name,limit-1,Console.ForegroundColor);
                    playerInput = Console.ReadLine();

                    //attempt to convert the string to a number
                    if (int.TryParse(playerInput, out playerGuess))
                    {
                        if(playerGuess<1 || playerGuess>limit){
                            Console.ForegroundColor=ConsoleColor.Red;
                            Console.WriteLine("{0} please enter a number between 1 & {1}",name,limit-1,Console.ForegroundColor);
                        }
                        else if (playerGuess == theAnswer)
                        {
                            Console.ForegroundColor=ConsoleColor.Green;
                            Console.WriteLine($"{theAnswer} was the number.  You Win {name}!",Console.ForegroundColor);
                            if(cnt==0){
                                Console.WriteLine("Woow!!! You guessed it right in first chance",Console.ForegroundColor);
                            }
                            else{
                                Console.WriteLine($"You took {cnt+1} chances to guess it right.",Console.ForegroundColor);
                            }
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor=ConsoleColor.Red;
                            if (playerGuess > theAnswer)
                            {
                                Console.WriteLine("{0} your guess was too High!",name,Console.ForegroundColor);
                            }
                            else
                            {
                                Console.WriteLine("{0} your guess was too low!",name,Console.ForegroundColor);
                            }
                        }
                    }
                    else if(playerInput=="Q"){
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor=ConsoleColor.Red;
                        Console.WriteLine("That wasn't a number! Please enter a number {0}",name,Console.ForegroundColor);
                    }
                    cnt++;
                } while (true);
            }
            else{
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine("Invalid Choice!!!",Console.ForegroundColor);
            }
        }
    }
}
