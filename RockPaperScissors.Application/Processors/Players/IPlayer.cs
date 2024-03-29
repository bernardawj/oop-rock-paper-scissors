using RockPaperScissors.Application.Enums.Game;

namespace RockPaperScissors.Application.Processors.Players;

public interface IPlayer
{
    Choice Play();
}