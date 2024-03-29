using RockPaperScissors.Application.Enums.Game;
using RockPaperScissors.Application.Processors.Managers;
using RockPaperScissors.Application.Tests.Processors.Managers.Fakes;

namespace RockPaperScissors.Application.Tests.Processors.Managers;

public class GameManagerTests
{
    [Theory]
    [InlineData(Choice.Rock, Choice.Scissors)]
    [InlineData(Choice.Paper, Choice.Rock)]
    [InlineData(Choice.Scissors, Choice.Paper)]
    public void Play_ShouldReturnPlayer1AsWinner_WhenProvidedWithPlayer1WinningChoice(Choice player1Choice, Choice player2Choice)
    {
        var player1 = new FakePlayer(player1Choice);
        var player2 = new FakePlayer(player2Choice);
        var gameManager = new GameManager(player1, player2);

        var result = gameManager.PlayRound();
        
        Assert.Equal(result.Player1Choice, player1Choice);
        Assert.Equal(result.Player2Choice, player2Choice);
        Assert.Equal(result.Winner, player1);
        Assert.False(result.IsDraw);
    }
    
    [Theory]
    [InlineData(Choice.Rock, Choice.Paper)]
    [InlineData(Choice.Paper, Choice.Scissors)]
    [InlineData(Choice.Scissors, Choice.Rock)]
    public void Play_ShouldReturnPlayer2AsWinner_WhenProvidedWithPlayer2WinningChoice(Choice player1Choice, Choice player2Choice)
    {
        var player1 = new FakePlayer(player1Choice);
        var player2 = new FakePlayer(player2Choice);
        var gameManager = new GameManager(player1, player2);

        var result = gameManager.PlayRound();
        
        Assert.Equal(result.Player1Choice, player1Choice);
        Assert.Equal(result.Player2Choice, player2Choice);
        Assert.Equal(result.Winner, player2);
        Assert.False(result.IsDraw);
    }
    
    [Theory]
    [InlineData(Choice.Rock, Choice.Rock)]
    [InlineData(Choice.Paper, Choice.Paper)]
    [InlineData(Choice.Scissors, Choice.Scissors)]
    public void Play_ShouldReturnDraw_WhenProvidedWithSameChoices(Choice player1Choice, Choice player2Choice)
    {
        var player1 = new FakePlayer(player1Choice);
        var player2 = new FakePlayer(player2Choice);
        var gameManager = new GameManager(player1, player2);

        var result = gameManager.PlayRound();
        
        Assert.Equal(result.Player1Choice, player1Choice);
        Assert.Equal(result.Player2Choice, player2Choice);
        Assert.Null(result.Winner);
        Assert.True(result.IsDraw);
    }
}