## Results
### Windows (i9 9900K, 64GB RAM) 
| Method   | BenchmarkInputData |         Mean |        Error |       StdDev |   Gen0 | Allocated |
|----------|--------------------|-------------:|-------------:|-------------:|-------:|----------:|
| Basic    | String[2500]       | 68,081.59 ns |   966.541 ns |   904.103 ns |      - |      88 B |
| Advanced | String[2500]       | 89,604.71 ns | 1,077.246 ns | 1,007.657 ns |      - |     144 B |
| Basic    | String[3]          |     76.08 ns |     0.961 ns |     0.803 ns | 0.0105 |      88 B |
| Advanced | String[3]          |    138.47 ns |     1.777 ns |     1.662 ns | 0.0172 |     144 B |

### MacOS (Macbook Pro (2021) M1 Pro, 32GB RAM) 
| Method                               | StrategyMoves |         Mean |      Error |     StdDev |   Gen0 | Allocated |
|--------------------------------------|---------------|-------------:|-----------:|-----------:|-------:|----------:|
| CalculateTotalScoreForStrategy       | String[2500]  | 64,058.79 ns | 208.931 ns | 195.434 ns |      - |      88 B |
| CalculateTotalScoreForResultStrategy | String[2500]  | 94,498.71 ns | 302.605 ns | 283.057 ns |      - |     144 B |
| CalculateTotalScoreForStrategy       | String[3]     |     67.98 ns |   0.126 ns |   0.118 ns | 0.0139 |      88 B |
| CalculateTotalScoreForResultStrategy | String[3]     |    140.19 ns |   0.746 ns |   0.698 ns | 0.0229 |     144 B |

