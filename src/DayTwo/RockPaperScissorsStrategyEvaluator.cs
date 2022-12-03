using System.Diagnostics;

namespace DayTwo;

internal enum Move
{
    Rock = 1,
    Paper = 2,
    Scissors = 3
}

internal enum Result
{
    Lose,
    Win,
    Draw
}

internal readonly record struct Round(Move OpponentMove, Move MyMove)
{
    public int CalculateRoundScore() =>
        (int)MyMove + this switch
        {
            { OpponentMove: Move.Rock, MyMove: Move.Paper } => 6,
            { OpponentMove: Move.Paper, MyMove: Move.Scissors } => 6,
            { OpponentMove: Move.Scissors, MyMove: Move.Rock } => 6,
            { OpponentMove: Move.Rock, MyMove: Move.Scissors } => 0,
            { OpponentMove: Move.Paper, MyMove: Move.Rock } => 0,
            { OpponentMove: Move.Scissors, MyMove: Move.Paper } => 0,
            _ => 3,
        };
}

internal readonly record struct RoundResult(Move OpponentMove, Result ExpectedResult)
{
    public Round CreateRound() =>
        this switch
        {
            { OpponentMove: Move.Rock, ExpectedResult: Result.Win } => new Round(OpponentMove, Move.Paper),
            { OpponentMove: Move.Rock, ExpectedResult: Result.Lose } => new Round(OpponentMove, Move.Scissors),
            { OpponentMove: Move.Paper, ExpectedResult: Result.Win } => new Round(OpponentMove, Move.Scissors),
            { OpponentMove: Move.Paper, ExpectedResult: Result.Lose } => new Round(OpponentMove, Move.Rock),
            { OpponentMove: Move.Scissors, ExpectedResult: Result.Win } => new Round(OpponentMove, Move.Rock),
            { OpponentMove: Move.Scissors, ExpectedResult: Result.Lose } => new Round(OpponentMove, Move.Paper),
            { ExpectedResult: Result.Draw } => new Round(OpponentMove, OpponentMove),
            _ => throw new UnreachableException()
        };
}

public class RockPaperScissorsStrategyEvaluator
{
    public static int CalculateTotalScoreForStrategy(IEnumerable<string> strategyMoves) =>
        GetAllRoundsFromStrategyFile(strategyMoves).Sum(round => round.CalculateRoundScore());
    
    public static int CalculateTotalScoreForResultStrategy(IEnumerable<string> strategyMoves) =>
        GetAllRoundResultsFromStrategyFile(strategyMoves)
            .Select(roundResult => roundResult.CreateRound())
            .Sum(round => round.CalculateRoundScore());

    private static IEnumerable<Round> GetAllRoundsFromStrategyFile(IEnumerable<string> strategyMoves)
    {
        foreach (var move in strategyMoves)
            yield return new Round(MapToMove(move[0]), MapToMove(move[2]));

        Move MapToMove(char move) =>
            move switch
            {
                'A' => Move.Rock,
                'B' => Move.Paper,
                'C' => Move.Scissors,
                'X' => Move.Rock,
                'Y' => Move.Paper,
                'Z' => Move.Scissors,
                _ => throw new UnreachableException()
            };
    }
    
    private static IEnumerable<RoundResult> GetAllRoundResultsFromStrategyFile(IEnumerable<string> strategyMoves)
    {
        foreach (var move in strategyMoves)
            yield return new RoundResult(MapToMove(move[0]), MapToResult(move[2]));

        Move MapToMove(char move) =>
            move switch
            {
                'A' => Move.Rock,
                'B' => Move.Paper,
                'C' => Move.Scissors,
                _ => throw new UnreachableException()
            };
        
        Result MapToResult(char move) =>
            move switch
            {
                'X' => Result.Lose,
                'Y' => Result.Draw,
                'Z' => Result.Win,
                _ => throw new UnreachableException()
            };
    }
}
