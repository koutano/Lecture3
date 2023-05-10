using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_colabo
{
    internal class Program
    {
        enum Hand
        { 
        ROCK,
        SCISSORS,
            PAPER
        }

        enum State
        { 
        WIN,
        LOSE,
        DRAW
        }


        static void Main(string[] args)
        {
        }

        static State Judge(Hand hand1, Hand hand2)
        {

            if(isSame(hand1,hand2)) return State.DRAW;
            else return State.WIN;
        }

        static bool isSame(Hand hand1, Hand hand2)
        {
            return hand1 == hand2;
        }

    }
}
