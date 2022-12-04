## Results
### Windows (i9 9900K, 64GB RAM)
| Method   | BenchmarkInputData |        Mean |     Error |    StdDev |   Gen0 | Allocated |
|----------|--------------------|------------:|----------:|----------:|-------:|----------:|
| Basic    | String[15]         |    287.4 ns |   5.78 ns |   8.65 ns | 0.0114 |      96 B |
| Advanced | String[15]         |    438.2 ns |   5.75 ns |   5.37 ns | 0.0658 |     552 B |
| Basic    | String[2245]       | 37,234.6 ns | 362.94 ns | 339.49 ns |      - |      96 B |
| Advanced | String[2245]       | 41,325.4 ns | 655.05 ns | 580.69 ns | 0.7324 |    6528 B |


### MacOS (Macbook Pro (2021) M1 Pro, 32GB RAM)
| Method   | BenchmarkInputData |        Mean |    Error |   StdDev |   Gen0 |   Gen1 | Allocated |
|----------|--------------------|------------:|---------:|---------:|-------:|-------:|----------:|
| Basic    | String[15]         |    226.6 ns |  1.03 ns |  0.96 ns | 0.0153 | 0.0002 |      96 B |
| Advanced | String[15]         |    347.0 ns |  1.02 ns |  0.95 ns | 0.0877 | 0.0005 |     552 B |
| Basic    | String[2245]       | 26,503.1 ns | 71.00 ns | 66.41 ns |      - |      - |      96 B |
| Advanced | String[2245]       | 29,265.8 ns | 79.10 ns | 70.12 ns | 1.0376 | 0.0305 |    6528 B |
