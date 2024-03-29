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

        if (roundResult.Player1Choice == roundResult.Player2Choice)
        {
            roundResult.IsDraw = true;
            return roundResult;
        }

        IPlayer? winner = null;
        if (roundResult.Player1Choice == Choice.Rock && roundResult.Player2Choice == Choice.Scissors || 
            roundResult.Player1Choice == Choice.Paper && roundResult.Player2Choice == Choice.Rock || 
            roundResult.Player1Choice == Choice.Scissors && roundResult.Player2Choice == Choice.Paper)
        {
            winner = _player1;
        }
        else
        {
            winner = _player2;
        }

        roundResult.Winner = winner;
        return roundResult;
    }
}