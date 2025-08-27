using RockPaperScissors.Application.Enums.Game;
using RockPaperScissors.Application.Processors.Players;
using RockPaperScissors.Application.Results;

namespace RockPaperScissors.Application.Processors.Managers;

public class GameManager : IGameManager
{
    private readonly IPlayer _player1;
    private readonly IPlayer _player2;

    private static readonly IDictionary<Choice, ISet<Choice>> WinningHands = new Dictionary<Choice, ISet<Choice>>
    {
        { Choice.Rock, new HashSet<Choice> { Choice.Scissors, Choice.Lizard } },
        { Choice.Paper, new HashSet<Choice> { Choice.Rock, Choice.Spock } },
        { Choice.Scissors, new HashSet<Choice> { Choice.Paper, Choice.Lizard } },
        { Choice.Lizard, new HashSet<Choice> { Choice.Spock, Choice.Paper } },
        { Choice.Spock, new HashSet<Choice> { Choice.Scissors, Choice.Rock } }
    };

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

        return WinningHands[player1Choice].Contains(player2Choice) ? _player1 : _player2;
    }
}