using RockPaperScissors.Application.Results;

namespace RockPaperScissors.Application.Processors.Managers;

public interface IGameManager
{
    RoundResult PlayRound();
}