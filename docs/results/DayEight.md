## Results
### Windows (i9 9900K, 64GB RAM)
| Method   | BenchmarkInputData |          Mean |        Error |       StdDev |   Gen0 | Allocated |
|----------|--------------------|--------------:|-------------:|-------------:|-------:|----------:|
| Basic    | N=5,00             |      88.95 ns |     1.811 ns |     1.779 ns | 0.0076 |      64 B |
| Advanced | N=5,00             |     146.16 ns |     1.907 ns |     1.592 ns | 0.0076 |      64 B |
| Basic    | N=99,00            | 291,670.14 ns | 2,412.262 ns | 2,014.348 ns |      - |     816 B |
| Advanced | N=99,00            | 325,214.24 ns | 3,706.387 ns | 3,466.957 ns |      - |     816 B |

### MacOS (Macbook Pro (2021) M1 Pro, 32GB RAM)
| Method   | BenchmarkInputData |          Mean |        Error |       StdDev |   Gen0 |   Gen1 | Allocated |
|----------|--------------------|--------------:|-------------:|-------------:|-------:|-------:|----------:|
| Basic    | N=5,00             |      64.34 ns |     0.140 ns |     0.131 ns | 0.0101 |      - |      64 B |
| Advanced | N=5,00             |     129.91 ns |     0.204 ns |     0.181 ns | 0.0100 | 0.0002 |      64 B |
| Basic    | N=99,00            | 221,760.76 ns | 1,009.901 ns |   843.313 ns |      - |      - |     816 B |
| Advanced | N=99,00            | 268,134.06 ns | 3,178.316 ns | 2,972.999 ns |      - |      - |     816 B |
