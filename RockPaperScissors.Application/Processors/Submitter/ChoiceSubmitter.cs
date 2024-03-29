using RockPaperScissors.Application.Enums.Game;

namespace RockPaperScissors.Application.Processors.Submitter;

public class ChoiceSubmitter : IChoiceSubmitter
{
    public string SubmitChoice()
    {
        Console.Write("Please choose either [R]ock / [P]aper / [S]cissors: ");
        return Console.ReadLine() ?? SubmitChoice();
    }
}