using RockPaperScissors.Application.Enums.Game;
using RockPaperScissors.Application.Processors.Players;
using RockPaperScissors.Application.Results;

namespace RockPaperScissors.Application.Processors.Managers;

public class GameManager : IGameManager
{
    private readonly IPlayer _player1;
    private readonly IPlayer _player2;

    public GameManager(IPlayer player1, IPlayer player2)
    {
        _player1 = player1;
        _player2 = player2;
    }

    public RoundResult PlayRound()
    {
        var roundResult = new RoundResult
        {
            Player1Choice = _player1.Play(),
            Player2Choice = _player2.Play()
        };
        
        roundResult.Winner = VerifyWinner(roundResult.Player1Choice, roundResult.Player2Choice);
        
        return roundResult;
    }

    public IPlayer? VerifyWinner(Choice player1Choice, Choice player2Choice)
    {
        if (player1Choice == player2Choice)
        {
            return null;
        }
        
        if (player1Choice == Choice.Rock && player2Choice == Choice.Scissors || 
            player1Choice == Choice.Paper && player2Choice == Choice.Rock || 
            player1Choice == Choice.Scissors && player2Choice == Choice.Paper)
        {
            return _player1;
        }
        else
        {
            return _player2;
        }
    }
}