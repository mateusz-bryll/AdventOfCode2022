## Results
### Windows (i9 9900K, 64GB RAM) 
| Method   | BenchmarkInputData |         Mean |        Error |       StdDev |   Gen0 | Allocated |
|----------|--------------------|-------------:|-------------:|-------------:|-------:|----------:|
| Basic    | String[2500]       | 68,081.59 ns |   966.541 ns |   904.103 ns |      - |      88 B |
| Advanced | String[2500]       | 89,604.71 ns | 1,077.246 ns | 1,007.657 ns |      - |     144 B |
| Basic    | String[3]          |     76.08 ns |     0.961 ns |     0.803 ns | 0.0105 |      88 B |
| Advanced | String[3]          |    138.47 ns |     1.777 ns |     1.662 ns | 0.0172 |     144 B |

### MacOS (Macbook Pro (2021) M1 Pro, 32GB RAM) 
| Method   | BenchmarkInputData |         Mean |      Error |     StdDev |   Gen0 |   Gen1 | Allocated |
|----------|--------------------|-------------:|-----------:|-----------:|-------:|-------:|----------:|
| Basic    | String[2500]       | 64,044.04 ns | 197.682 ns | 175.240 ns |      - |      - |      88 B |
| Advanced | String[2500]       | 94,625.29 ns | 371.935 ns | 347.908 ns |      - |      - |     144 B |
| Basic    | String[3]          |     68.69 ns |   0.295 ns |   0.276 ns | 0.0139 | 0.0001 |      88 B |
| Advanced | String[3]          |    140.85 ns |   0.388 ns |   0.363 ns | 0.0229 | 0.0002 |     144 B |
