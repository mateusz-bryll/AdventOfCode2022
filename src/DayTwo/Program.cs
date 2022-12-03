using DayTwo;

var strategyMoves = File.ReadLines("./input");

Console.WriteLine($"Part 1 answer: {RockPaperScissorsStrategyEvaluator.CalculateTotalScoreForStrategy(strategyMoves)}");
Console.WriteLine($"Part 2 answer: {RockPaperScissorsStrategyEvaluator.CalculateTotalScoreForResultStrategy(strategyMoves)}");
