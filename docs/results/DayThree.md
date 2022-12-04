## Results
### Windows (i9 9900K, 64GB RAM)
| Method   | BenchmarkInputData |         Mean |       Error |      StdDev |   Gen0 | Allocated |
|----------|--------------------|-------------:|------------:|------------:|-------:|----------:|
| Basic    | String[300]        |  27,117.7 ns |   491.42 ns |   459.68 ns |      - |      32 B |
| Advanced | String[300]        | 263,948.4 ns | 5,268.68 ns | 4,928.33 ns | 4.3945 |   36776 B |
| Basic    | String[6]          |     241.8 ns |     3.14 ns |     2.78 ns | 0.0038 |      32 B |
| Advanced | String[6]          |   2,834.7 ns |    45.77 ns |    42.82 ns | 0.1259 |    1080 B |

### MacOS (Macbook Pro (2021) M1 Pro, 32GB RAM)
| Method   | BenchmarkInputData |         Mean |     Error |    StdDev |   Gen0 |   Gen1 | Allocated |
|----------|--------------------|-------------:|----------:|----------:|-------:|-------:|----------:|
| Basic    | String[300]        |  16,496.6 ns |  71.29 ns |  66.69 ns |      - |      - |      32 B |
| Advanced | String[300]        | 137,253.5 ns | 485.50 ns | 430.39 ns | 5.8594 | 0.2441 |   36776 B |
| Basic    | String[6]          |     183.4 ns |   0.61 ns |   0.57 ns | 0.0050 | 0.0002 |      32 B |
| Advanced | String[6]          |   1,578.1 ns |   2.65 ns |   2.35 ns | 0.1717 | 0.0019 |    1080 B |
