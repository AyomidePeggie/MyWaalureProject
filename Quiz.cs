using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWaalureProject
{
    public class Quiz
    {
        private List<Question> _questions;
        private int _score;
        public Quiz(List<Question> questions)
        {

            Random random = new Random();
            _questions=questions.OrderBy(q =>  random.Next()).ToList();
            _score = 0;
        }
        public void StartQuiz()
        {
            Console.WriteLine("You are about to start the quiz");
            int questionnumber = 1;
            foreach (var question in _questions)
            {
                Console.WriteLine($"\nQuestion {questionnumber}: {question.Text}");
                

                int optionnumber = 1;
                foreach (var Option in question.Options)
                {
                    Console.WriteLine($"{optionnumber}: {Option}");
                    optionnumber++;
                }
                Console.WriteLine("What is the answer");

                var userAnswer = Console.ReadLine();
                int answer;
                if (int.TryParse(userAnswer, out answer) && answer>=1 && answer <=question.Options.Count)
                {
                    if (answer - 1 == question.CorrectAnswerIndex)
                    {
                        Console.WriteLine("You are correct");
                        _score++;
                    }
                    else
                    {
                        Console.WriteLine($"incorrect answer selected.The correct answer is :{question.Options[question.CorrectAnswerIndex]}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option selected");
                }

                questionnumber++;
            }
            DisplayResult(); 
        }


     public void DisplayResult()
        {
            Console.WriteLine("\nThe quiz score is given below");
            Console.WriteLine($"Your score is {_score}/{_questions.Count}");
            if (_score == _questions.Count)
            {
                Console.WriteLine("Excellent");
            }
            else if (_score >= _questions.Count / 2)
            {
                Console.WriteLine("Put in more effort");
            }
            else
            {
                Console.WriteLine("Repeat the test");
            }
        }
    }
}
