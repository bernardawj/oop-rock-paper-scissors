using RockPaperScissors.Application.Exceptions;
using RockPaperScissors.Application.Processors.Managers;
using RockPaperScissors.Application.Processors.Players;
using RockPaperScissors.Application.Processors.Submitter;

namespace RockPaperScissors.Application;

public class Program
{
    public static void Main(string[] args)
    {
        do
        {
            try
            {
                var gameManager = new GameManager(new HumanPlayer(new ChoiceSubmitter()), new ComputerPlayer());
                var result = gameManager.PlayRound();

                Console.WriteLine($"Player 1 played {result.Player1Choice} and Player 2 played {result.Player2Choice}.");
                Console.WriteLine(result.IsDraw ? "This match ends with a draw!" : $"{result.Winner} is the winner!");
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine(ex.Message);       
            }
        } while (true);
    }
}