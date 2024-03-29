using RockPaperScissors.Application.Enums.Game;
using RockPaperScissors.Application.Processors.Players;
using RockPaperScissors.Application.Tests.Processors.Submitter;

namespace RockPaperScissors.Application.Tests.Processors.Players;

public class HumanPlayerTests
{
    [Theory]
    [InlineData("R", Choice.Rock)]
    [InlineData("P", Choice.Paper)]
    [InlineData("S", Choice.Scissors)]
    public void Play_ShouldReturnCorrectChoice_WhenEnteredWithValidValueAsChoice(string submittedChoice, Choice expectedChoice)
    {
        var humanPlayer = new HumanPlayer(new FakeChoiceSubmitter(submittedChoice));
        var actualChoice = humanPlayer.Play();
        Assert.Equal(expectedChoice, actualChoice);
    }
}