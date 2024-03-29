using RockPaperScissors.Application.Enums.Game;
using RockPaperScissors.Application.Processors.Players;
using RockPaperScissors.Application.Results;

namespace RockPaperScissors.Application.Processors.Managers;

public interface IGameManager
{
    RoundResult PlayRound();

    IPlayer? VerifyWinner(Choice player1Choice, Choice player2Choice);
}