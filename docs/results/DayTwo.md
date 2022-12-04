## Results
### Windows (i9 9900K, 64GB RAM) 
| Method                               | StrategyMoves |         Mean |        Error |     StdDev |   Gen0 | Allocated |
|--------------------------------------|---------------|-------------:|-------------:|-----------:|-------:|----------:|
| CalculateTotalScoreForStrategy       | String[2500]  | 67,180.79 ns |   778.323 ns | 728.044 ns |      - |      88 B |
| CalculateTotalScoreForResultStrategy | String[2500]  | 87,612.31 ns | 1,040.525 ns | 922.399 ns |      - |     144 B |
| CalculateTotalScoreForStrategy       | String[3]     |     72.83 ns |     0.545 ns |   0.483 ns | 0.0105 |      88 B |
| CalculateTotalScoreForResultStrategy | String[3]     |    126.56 ns |     2.521 ns |   3.001 ns | 0.0172 |     144 B |
### MacOS (Macbook Pro (2021) M1 Pro, 32GB RAM) 
| Method                               | StrategyMoves |         Mean |      Error |     StdDev |   Gen0 | Allocated |
|--------------------------------------|---------------|-------------:|-----------:|-----------:|-------:|----------:|
| CalculateTotalScoreForStrategy       | String[2500]  | 64,058.79 ns | 208.931 ns | 195.434 ns |      - |      88 B |
| CalculateTotalScoreForResultStrategy | String[2500]  | 94,498.71 ns | 302.605 ns | 283.057 ns |      - |     144 B |
| CalculateTotalScoreForStrategy       | String[3]     |     67.98 ns |   0.126 ns |   0.118 ns | 0.0139 |      88 B |
| CalculateTotalScoreForResultStrategy | String[3]     |    140.19 ns |   0.746 ns |   0.698 ns | 0.0229 |     144 B |

