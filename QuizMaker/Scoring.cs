using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    class Scoring
    {
        static int correct = 0;
        static int Wrong = 0;

        public void Score(bool flag)
        {
            /*** if the user inputs the right answer, the integer value 'correct' increments by one
             * vice versa if the user enters the wrong answer
             * ***/
            if (flag)
            {
                correct++;
                Console.WriteLine("You got the answer right! \n");
            }
            else
            {
                Wrong++;
                Console.WriteLine("That is not the correct answer. \n");
            }
        }

        public void GameOver()
        {
            // Calculates the final score once the game is over and displays it to the user
            Console.WriteLine("Your final score is " + correct + "/" + (correct + Wrong) + "\n");
        }


    }
}
