namespace RockPaperScissors.Application.Processors.Submitter;

public class ChoiceSubmitter : IChoiceSubmitter
{
    public string SubmitChoice()
    {
        Console.Write("Please choose either [R]ock / [P]aper / [S]cissors / [L]izard / [Sp]ock : ");
        return Console.ReadLine() ?? SubmitChoice();
    }
}