using RockPaperScissors.Application.Processors.Submitter;

namespace RockPaperScissors.Application.Tests.Processors.Submitter;

public class FakeChoiceSubmitter : IChoiceSubmitter
{
    private readonly string _submittedChoice;

    public FakeChoiceSubmitter(string submittedChoice)
    {
        _submittedChoice = submittedChoice;
    }

    public string SubmitChoice()
    {
        return _submittedChoice;
    }
}