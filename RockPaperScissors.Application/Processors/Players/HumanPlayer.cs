using RockPaperScissors.Application.Enums.Game;
using RockPaperScissors.Application.Processors.Submitter;

namespace RockPaperScissors.Application.Processors.Players;

public class HumanPlayer : IPlayer
{
    private readonly IChoiceSubmitter _choiceSubmitter;
    
    public HumanPlayer(IChoiceSubmitter choiceSubmitter)
    {
        _choiceSubmitter = choiceSubmitter;
    }
    
    public Choice Play()
    {
        var submittedChoice = _choiceSubmitter.SubmitChoice();

        return submittedChoice.ToUpper() switch
        {
            "R" => Choice.Rock,
            "P" => Choice.Paper,
            "S" => Choice.Scissors,
            _ => throw new NotImplementedException("Choice not yet implemented.")
        };
    }

    public override string ToString()
    {
        return "Human Player";
    }
}