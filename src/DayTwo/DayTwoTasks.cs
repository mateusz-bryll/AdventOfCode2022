using AdventOfCode.Tasks.Sdk;

namespace DayTwo;

public class DayTwoTasks : ITasks
{
    public int DayNumber => 2;

    [TaskResultDescription("total score for strategy")]
    public int GetBasicTaskResult(IEnumerable<string> input) =>
        RockPaperScissorsStrategyEvaluator.CalculateTotalScoreForStrategy(input);

    [TaskResultDescription("total score for expected results strategy")]
    public int GetAdvancedTaskResult(IEnumerable<string> input) =>
        RockPaperScissorsStrategyEvaluator.CalculateTotalScoreForResultStrategy(input);
}
