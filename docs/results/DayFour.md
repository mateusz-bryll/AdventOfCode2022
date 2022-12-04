## Results
### Windows (i9 9900K, 64GB RAM)
| Method   | BenchmarkInputData |        Mean |       Error |      StdDev |   Gen0 | Allocated |
|----------|--------------------|------------:|------------:|------------:|-------:|----------:|
| Basic    | String[1000]       | 75,375.9 ns |   949.86 ns |   888.50 ns |      - |      32 B |
| Advanced | String[1000]       | 71,705.5 ns | 1,259.47 ns | 1,116.48 ns |      - |      32 B |
| Basic    | String[6]          |    393.2 ns |     5.31 ns |     4.97 ns | 0.0038 |      32 B |
| Advanced | String[6]          |    415.0 ns |     4.38 ns |     4.09 ns | 0.0038 |      32 B |

### MacOS (Macbook Pro (2021) M1 Pro, 32GB RAM)