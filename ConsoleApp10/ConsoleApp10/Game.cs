using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Word
    {
        string secretword1;
        string guess1;
        int guesscount;
        int guesslimit;

        bool outofguesses;

        public Word(string asecretword, string aguess, int aguesscount, int aguesslimit, bool aoutofguesses)
        {
            secretword1 = asecretword;
            guess1 = aguess;
            guesscount = aguesscount;
            guesslimit = aguesslimit;
            outofguesses = aoutofguesses;

            while (guess1 != secretword1 && !outofguesses)
            {
                if (guesscount < guesslimit)
                {
                    Console.Write("Enter the word:");
                    guess1 = Console.ReadLine();
                    guesscount++;
                }
                else
                {
                    outofguesses = true;
                }
            }
            if (outofguesses)
            {
                Console.WriteLine("you lose!");
            }
            else
            {
                Console.WriteLine("you win!");
            }
        }
    }
}
