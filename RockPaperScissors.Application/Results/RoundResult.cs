using RockPaperScissors.Application.Enums.Game;
using RockPaperScissors.Application.Processors.Players;

namespace RockPaperScissors.Application.Results;

public class RoundResult
{
    public Choice Player1Choice { get; set; }
    public Choice Player2Choice { get; set; }
    public IPlayer? Winner { get; set; }
    public bool IsDraw => Player1Choice == Player2Choice;
}