using System;
namespace RockPaperScissors
{
    public class GreetingMessage
    {
        /*Method used to greet the user */
         public string WelcomeMessage()
        {
            string welcome = "\nWelcome to the game Rock-Paper-Scissors!";
            return welcome;
        }

        /*Method used to receive the player's name */
        public string getPlayerName(string playerInput)
        {
            playerInput = playerInput.Trim();   /*.Trim() is used to cut out all the whitespaces */
            if (playerInput.Length > 20 || playerInput.Length < 1) /* Check if it's a valid name */
            {
                return null;
            }
            return playerInput;
        }

    }
}