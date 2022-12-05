## Results
### Windows (i9 9900K, 64GB RAM)
| Method   | BenchmarkInputData |        Mean |     Error |    StdDev |   Gen0 | Allocated |
|----------|--------------------|------------:|----------:|----------:|-------:|----------:|
| Basic    | String[511]        | 57,113.9 ns | 516.40 ns | 483.04 ns | 2.5024 |  20.66 KB |
| Advanced | String[511]        | 60,862.3 ns | 527.68 ns | 467.78 ns | 2.4414 |  20.66 KB |
| Basic    | String[9]          |    916.5 ns |   9.16 ns |   8.12 ns | 0.1411 |   1.16 KB |
| Advanced | String[9]          |    929.8 ns |  11.04 ns |  10.33 ns | 0.1411 |   1.16 KB |


### MacOS (Macbook Pro (2021) M1 Pro, 32GB RAM)

