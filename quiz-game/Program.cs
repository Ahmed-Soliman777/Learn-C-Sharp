using System;

namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] questions = new string[3]
            {
              "1. What is the capital of France ?",
              "2. What is the red planet ?",
              "3. What is the largest animal ?"
            };

            string[] answers = new string[3]
            {
              "paris",
              "mars",
              "whale"
            };

            int correctAnswers = 0;

            Console.WriteLine("Welcome to the Game");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Please answer the following questions.");

            Console.WriteLine(questions.Length);


            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);

                string userAnswer = Console.ReadLine();


                try
                {
                    bool result = IsCorrect(userAnswer, answers[i]);

                    if (result == true)
                    {
                        Console.WriteLine("Correct!");

                        correctAnswers++;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, the correct answer is {answers[i]}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Quiz completed, your score is {correctAnswers} out of {answers.Length} thank you for playing");
        }

        private static bool IsCorrect(string userAnswer, string correctAnswer)
        {
            if (string.IsNullOrEmpty(userAnswer))
            {
                throw new Exception("Empty answers are not accepted!");
            }

            if (userAnswer == correctAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}