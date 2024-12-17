using MyWaalureProject;

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
}
};
Quiz quiz = new Quiz(questions);
quiz.StartQuiz();
