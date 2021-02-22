using System;

namespace RockPaperScissorsLib
{
    public class Game
    {
        public string[] possibilities = { "S", "P", "R" };


        public void StartGame(){
            string answer = GetUserAnswer().ToUpper();
            string computeranswer = this.Draw(this.possibilities);
            GameDisplay.displayAnswers(answer,computeranswer);
            string result = determineResult(answer,computeranswer);
            GameDisplay.displayResult(result);
            

        }

        public string Draw(string[] options)
        {

            Random random = new Random();
            int randomindex = random.Next(1,3);
            return this.possibilities[randomindex];

        }

        public bool CheckUserAnswer(string answer){
            for (int i = 0; i < this.possibilities.Length ; i++)
            {
                if(answer.ToUpper() == possibilities[i].ToUpper()){
                    return true;
                }
            }

            return false;
        }

        public string GetUserAnswer()
        {
            System.Console.WriteLine("Please Choose Rock (R), Paper (P), or Scissors (S)");
            string answer = Console.ReadLine().ToUpper();
            if(!isValidInput(answer)){
               System.Console.WriteLine("Use R for Rock, S for Scissors, and P for Paper");
               GetUserAnswer();
            }
            return answer;

            
        }

        public bool isValidInput(string answer){

            for (int i = 0; i < possibilities.Length; i++)
            {
                if(answer == possibilities[i]){
                    return true;
                }

            }

             return false;

        }

        public string determineResult(string playeranswer, string computeranswer){


            if(playeranswer == computeranswer){
                return "tie";
            };

            if(playeranswer == "R"){
                switch (computeranswer)
                {
                    case "S":
                        return "Win";
                    case "P":
                         return "Loss";

                }
            }
            
            if(playeranswer == "S"){
                switch (computeranswer)
                {
                    case "P":
                        return "Win";
                    case "R":
                         return "Loss";

                }
            }
            
            if(playeranswer == "P"){
                switch (computeranswer)
                {
                    case "R":
                        return "Win";
                    case "S":
                         return "Loss";

                }
            }

            return "Failed to determine a winner";
        }
    }
}

