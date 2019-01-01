using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuizMaker
{
    class QuizLogic
    {


        Scoring S = new Scoring();
        static int answer;
        static int choice;

        string[] Questions = File.ReadAllLines("C:/FILE/PATH/Questions.txt");
        string[] Answers = File.ReadAllLines("C:/FILE/PATH/Desktop/Answers.txt");
        string[] Choices = File.ReadAllLines("C:/FILE/PATH/Choices.txt");


        public void StartQuiz()
        {

            Question();

        }

        private void Question()
        {
            /*** Iterates through the array of questions. 
             * Each iteration calls the UserInput method
             * The GameOver method is called once the iteration is complete
             * ***/
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine(Questions[i]);
                UserInput(S);
            }

            S.GameOver();


        }

        public void UserInput(Scoring s)
        {
            /*** Prints and iterates through the the list of choices the user has to answer
             * utilizes the split method to organize the choices
             ***/

            String[] ChoiceList = Choices[choice].Split('-');

            for (int i = 0; i < Choices.Length; i++)
            {
                Console.WriteLine(ChoiceList[i]);
            }

            /*** Take the users input in type string
             *   checks to see if the user's input is the correct answer
             *   utilizes the Scoring.score method to keep track of the score
             * ***/

            choice++;
            string Input;
            Input = Console.ReadLine();

            if (Input.Equals(Answers[answer], StringComparison.CurrentCultureIgnoreCase))
            {
                s.Score(true);
                answer++;
            }
            else
            {
                s.Score(false);
                answer++;
            }
            

        }




    }
}
