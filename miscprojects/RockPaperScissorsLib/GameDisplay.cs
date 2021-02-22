using System;

namespace RockPaperScissorsLib
{
    public class GameDisplay
    {
        public static void displayAnswers(string answer, string computeranswer)
        {
            System.Console.WriteLine($"You answer was {answer}, The computer's was a {computeranswer}");
        }

        public static void displayResult(string result)
        {
            System.Console.WriteLine($"The result of this battle was a {result.ToLower()}");
        }


    };
}
