## Results
### Windows (i9 9900K, 64GB RAM)
| Method   | BenchmarkInputData |         Mean |     Error |    StdDev |    Gen0 |    Gen1 |    Gen2 | Allocated |
|----------|--------------------|-------------:|----------:|----------:|--------:|--------:|--------:|----------:|
| Basic    | N=2000,00          |   642.109 us | 7.6454 us | 7.1515 us | 41.0156 | 41.0156 | 41.0156 |  322710 B |
| Advanced | N=2000,00          | 1,079.569 us | 9.6878 us | 8.5880 us | 17.5781 |  3.9063 |       - |  154329 B |
| Basic    | N=8,00             |     1.061 us | 0.0054 us | 0.0048 us |  0.0992 |       - |       - |     840 B |
| Advanced | N=8,00             |     1.357 us | 0.0186 us | 0.0174 us |  0.0381 |       - |       - |     320 B |

### MacOS (Macbook Pro (2021) M1 Pro, 32GB RAM)
| Method   | BenchmarkInputData |         Mean |       Error |      StdDev |     Gen0 |     Gen1 |    Gen2 | Allocated |
|----------|--------------------|-------------:|------------:|------------:|---------:|---------:|--------:|----------:|
| Basic    | N=2000,00          | 519,476.6 ns | 3,061.29 ns | 2,556.32 ns | 200.1953 | 200.1953 | 34.1797 |  322730 B |
| Advanced | N=2000,00          | 925,552.2 ns | 3,027.79 ns | 2,832.20 ns |  23.4375 |   0.9766 |       - |  154329 B |
| Basic    | N=8,00             |     825.8 ns |     4.98 ns |     4.65 ns |   0.1335 |   0.0010 |       - |     840 B |
| Advanced | N=8,00             |   1,111.9 ns |     3.51 ns |     3.29 ns |   0.0496 |   0.0019 |       - |     320 B |
