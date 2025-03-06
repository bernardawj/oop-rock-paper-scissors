using RockPaperScissors.Application.Enums.Game;
using RockPaperScissors.Application.Processors.Players;
using RockPaperScissors.Application.Tests.Processors.Players.Fakes;

namespace RockPaperScissors.Application.Tests.Processors.Players;

public class HumanPlayerTests
{
    [Theory]
    [InlineData("R", Choice.Rock)]
    [InlineData("r", Choice.Rock)]
    [InlineData("P", Choice.Paper)]
    [InlineData("p", Choice.Paper)]
    [InlineData("S", Choice.Scissors)]
    [InlineData("s", Choice.Scissors)]
    [InlineData("L", Choice.Lizard)]
    [InlineData("l", Choice.Lizard)]
    [InlineData("Sp", Choice.Spock)]
    [InlineData("sp", Choice.Spock)]
    public void Play_ShouldReturnCorrectChoice_WhenEnteredWithValidValueAsChoice(string submittedChoice, Choice expectedChoice)
    {
        var humanPlayer = new HumanPlayer(new FakeChoiceSubmitter(submittedChoice));
        var actualChoice = humanPlayer.Play();
        Assert.Equal(expectedChoice, actualChoice);
    }
}