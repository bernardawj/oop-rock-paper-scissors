using System.Security.Cryptography;
using RockPaperScissors.Application.Enums.Game;

namespace RockPaperScissors.Application.Processors.Players;

public class ComputerPlayer : IPlayer
{
    public Choice Play()
    {
        return (Choice)RandomNumberGenerator.GetInt32(0, 3);
    }
}