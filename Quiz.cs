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
            _questions= questions.OrderBy(q =>  random.Next()).ToList();
            _score = 0;
        }
        public void StartQuiz()
        {
            Console.WriteLine("You are about to start the quiz");
            int questionnumber = 1;
            foreach (var question in _questions)
            {
                Console.Clear();
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
                    //else
                    //{
                    //    Console.WriteLine($"incorrect answer selected.The correct answer is :{question.Options[question.CorrectAnswerIndex]}");
                    //}
                }
                else
                {
                    Console.WriteLine("Invalid option selected");
                }

                questionnumber++;
            }
            DisplayResult(); 
        }

        public static List<Question> Question()
        {
            var questions = new List<Question>
{
new Question
{
    Text = "How many seconds make a minute?",
    Options = new List<string>{"60 Seconds", "90seconds", "25seconds" },
    CorrectAnswerIndex = 0
},
new Question
{
    Text = "How many planets do we have in the world?",
    Options = new List<string>{"16", "8", "12" },
    CorrectAnswerIndex = 1
},
new Question
{
    Text = "What is the symbol of Helium?",
    Options = new List<string>{"he", "h", "He" },
    CorrectAnswerIndex = 2
},
new Question
{
    Text = "What is the past tense of go?",
    Options = new List<string>{"camed", "went", "goed" },
    CorrectAnswerIndex = 1
},
new Question
{
    Text = "How long does it takes to boil an egg?",
    Options = new List<string>{"60 Seconds", "90seconds", "25seconds" },
    CorrectAnswerIndex = 0
},
new Question
{
    Text = "What do you call a baby goat?",
    Options = new List<string>{"mice", "kid", "sailor" },
    CorrectAnswerIndex = 1
},
new Question
{
    Text = "Anchor is associated to what?",
    Options = new List<string>{"ship", "train", "airplane" },
    CorrectAnswerIndex = 0
},
new Question
{
    Text = "How many players make a team in the game of football?",
    Options = new List<string>{"12", "15", "11" },
    CorrectAnswerIndex = 2
},
new Question
{
    Text = "Car is associated to park, while airplane is associated to?",
    Options = new List<string>{"hanger", "motorpark", "parkview" },
    CorrectAnswerIndex = 0
},
new Question
{
    Text = "What is the name of Manchester United stadium?",
    Options = new List<string>{"Ethiad", "blue Arena", "Old Trafford" },
    CorrectAnswerIndex = 2
},
};

            return questions;
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
