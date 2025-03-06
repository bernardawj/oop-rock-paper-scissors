using System.Security.Cryptography;
using RockPaperScissors.Application.Enums.Game;

namespace RockPaperScissors.Application.Processors.Players;

public class ComputerPlayer : IPlayer
{
    private readonly Random _random;

    public ComputerPlayer(Random? random = null)
    {
        _random = random ?? new Random();
    }

    public Choice Play()
    {
        var numberOfChoices = Enum.GetValues(typeof(Choice)).Length;
        return (Choice)_random.Next(0, numberOfChoices);
    }

    public override string ToString()
    {
        return "CPU";
    }
}