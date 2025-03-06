using Moq;
using RockPaperScissors.Application.Enums.Game;
using RockPaperScissors.Application.Processors.Players;

namespace RockPaperScissors.Application.Tests.Processors.Players;

public class ComputerPlayerTests
{
    private readonly Mock<Random> _randomMock = new();

    [Fact]
    public void Play_ShouldReturnARandomChoice_WhenCalled()
    {
        _randomMock
            .SetupSequence(random => random.Next(0, Enum.GetValues(typeof(Choice)).Length))
            .Returns(0)
            .Returns(1)
            .Returns(2);
        
        var computerPlayer = new ComputerPlayer(_randomMock.Object);
        
        Assert.Equal(Choice.Rock, computerPlayer.Play());
        Assert.Equal(Choice.Paper, computerPlayer.Play());
        Assert.Equal(Choice.Scissors, computerPlayer.Play());
    }
}