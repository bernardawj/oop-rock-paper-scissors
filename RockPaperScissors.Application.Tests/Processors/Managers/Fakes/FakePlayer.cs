using RockPaperScissors.Application.Enums.Game;
using RockPaperScissors.Application.Processors.Players;

namespace RockPaperScissors.Application.Tests.Processors.Managers.Fakes;

public class FakePlayer : IPlayer
{
    private readonly Choice _choice;

    public FakePlayer(Choice choice)
    {
        _choice = choice;
    }

    public Choice Play()
    {
        return _choice;
    }
}