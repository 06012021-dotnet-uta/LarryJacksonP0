using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        { 

        /********** USING A SWITCH STATMENT /**********/
            string inputPlayer, inputCPU;   /* Declaring all inputs as a string */
            int randomInt;                  /* Declaring random choices as intergers */
            bool playAgain = true;          /* Declaring a yes or no response if player wants to play again */
        
            /* The Greeting Message */
            GreetingMessage greeting = new GreetingMessage();
            Console.WriteLine(greeting.WelcomeMessage());

            /** Getting the players info **/
            UserName player = new PlayerDerived("player");
            Console.WriteLine("Enter your first name to begin.");
            player.Fname = greeting.getPlayerName(Console.ReadLine());
            Console.WriteLine($"\nWelcome to the game {player.Fname}, and good luck to you!");

            
            while (playAgain) {
                int scorePlayer = 0;            /* Declaring the player's score */
                int scoreCPU = 0;               /* Declaring the CPU's score */
            
                 while (scorePlayer < 3 && scoreCPU < 3) {
                
            Console.WriteLine();    /*Gives a space */

            /* Greetings message with user prompt */
            Console.WriteLine("Choose between R, P, S:  \n");
            
            inputPlayer = Console.ReadLine();   /*Gets the player input */
            
            Random rnd = new Random();       /* Declaring a random generate */

            randomInt = rnd.Next(1,4);      /* Get a random number between 1-4 */

            switch (randomInt)
            {
                case 1:
                    inputCPU = "ROCK";                  /* CPU picks rock */
                    Console.WriteLine("Computer chose ROCK");
                    if (inputPlayer == "R") {           /* If Player inputs rock */
                        Console.WriteLine("Draw!\n");   /* Result will be a draw */
                    }
                    else if (inputPlayer == "P") {      /* Else If Player inputs paper */
                        Console.WriteLine("Player WINS!\n");
                        scorePlayer++;                  /*Adds a point to the score if the player wins */
                    }
                    else if (inputPlayer == "S") {      /* Else If Player inputs scissors */
                        Console.WriteLine("CPU WINS!\n");
                        scoreCPU++;                     /*Adds a point to the score if the CPU wins */
                    }
                        break;
                case 2:
                    inputCPU = "PAPER";                 /* CPU picks paper */
                    Console.WriteLine("Computer chose PAPER");
                    if (inputPlayer == "P") {           /* If Player inputs paper */
                        Console.WriteLine("Draw!\n");   /* Result will be a draw */
                    }
                    else if (inputPlayer == "R") {      /* Else If Player inputs rock */
                        Console.WriteLine("CPU WINS!\n");
                        scoreCPU++;                     /*Adds a point to the score if the CPU wins */
                    }
                    else if (inputPlayer == "S") {      /* Else If Player inputs scissors */
                        Console.WriteLine("Player WINS!\n");
                        scorePlayer++;                  /*Adds a point to the score if the player wins */
                    }
                        break;
                case 3:
                    inputCPU = "SCISSORS";              /* CPU picks scissors */
                    Console.WriteLine("Computer chose SCISSORS");
                    if (inputPlayer == "S") {           /* If Player inputs scissors */
                        Console.WriteLine("Draw!\n");   /* Result will be a draw */
                    }
                     else if (inputPlayer == "R") {     /* Else If Player inputs rock */
                        Console.WriteLine("Player WINS!\n");
                        scorePlayer++;                  /*Adds a point to the score if the player wins */
                    }
                    else if (inputPlayer == "P") {      /* Else If Player inputs paper */
                        Console.WriteLine("CPU WINS!\n");
                        scoreCPU++;                     /*Adds a point to the score if the CPU wins */
                    }
                        break;
                default:
                    Console.WriteLine("Invalid entry!");    /* Anything else but R, P, or S
                                                            this will display an error message */
                    break;
                }
                
                Console.WriteLine($"PLAYER SCORE:{scorePlayer}\n\nCPU SCORE: {scoreCPU}");  /* Keeps both CPU and player scores */
            }//end of the outer while loop

            if (scorePlayer == 3)                       /* If player wins the best out of 3 */
                Console.WriteLine($"\n{player.Fname} WINS THE GAME!\n");
            else if (scoreCPU == 3)                     /* If CPU wins the best out of 3 */ 
                Console.WriteLine("\nCPU WINS THE GAME!\n");
            else{}
            
            Console.WriteLine("Do you want to play again?(YES/ NO)");    /* Asking the player if they want another round */ 
            string loop = Console.ReadLine();           /*use to store the yes or no response */
            if (loop == "YES"){
                playAgain = true;
                Console.Clear();                        /* Clears out the entire console */
            }
            else if (loop == "NO")
                playAgain = false;
            }//end of the outer while loop
        }//end of main
    }//end of class
}//end of namespace
         




/*********************  MARK MOORE EXAMPLE *********************/





    // class Program
    // {
//         public enum RpsChoice {
//             Rock = 1,
//             Paper = 2,
//             Scissors = 3
// //         }
//         static void Main(string[] args)
//         { 
//             /* Greeting message and prompt the user to make a choice */
//             Console.WriteLine("\t\nWelcome to the game Rock-Paper-Scissors!\n\nPlease make a choice");
//             bool successfulConversion = false;
//             int playerChoiceInt;
//             do {
//                 Console.WriteLine ("1.Rock\n2.Paper\n3.Scissors\n");
//                 string playerChoice = Console.ReadLine();

//                 /* Create a int variable to catch the converted choice. */
//                 successfulConversion = Int32.TryParse(playerChoice, out playerChoiceInt);
            
//                 /* Checks if the user inputs correct # but the # is out of bounds */ 
//                 if (playerChoiceInt > 3 || playerChoiceInt < 0) {
//                     Console.WriteLine($"You inputted {playerChoiceInt}. That is not a valid choice!");
//                 }
//                 else if (!successfulConversion) {
//                     Console.WriteLine($"You inputted {playerChoiceInt}. That is not a valid choice!");
//                 }
//             } while(!successfulConversion || (playerChoiceInt >= 1 || playerChoiceInt <= 3));


//             // if (successfulConversion == true) {
//             //     Console.WriteLine($"The conversion returned {successfulConversion} and the player chose {playerChoiceInt}");
//             // } 

//             // else {
//             //     Console.WriteLine($"The conversion returned {successfulConversion} and the player chose {playerChoiceInt}");
//             //  }  


//             Random rnd = new Random();       /* Declaring a random generate */
//             int cpuChoice = rnd.Next(1,4);

//             Console.WriteLine($"The computers choices {playerChoiceInt}.");
//             Console.WriteLine($"The computers choices {cpuChoice}.");

//             /*Checks the winner */
//             if( (playerChoiceInt == 1 && cpuChoice == 2) ||
//                 (playerChoiceInt == 2 && cpuChoice == 3) || 
//                 (playerChoiceInt == 3 && cpuChoice == 1)) Console.WriteLine("Computer Wins!");
//             else if(playerChoiceInt == cpuChoice ) Console.WriteLine("TIE GAME!");
//             else Console.WriteLine("Player WINS!");
//         }//End of main
//     }//end of class
// }//end of namespace



