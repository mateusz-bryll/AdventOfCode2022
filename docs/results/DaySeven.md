## Results
### Windows (i9 9900K, 64GB RAM)

### MacOS (Macbook Pro (2021) M1 Pro, 32GB RAM)
| Method   | BenchmarkInputData |        Mean |     Error |    StdDev |   Gen0 |   Gen1 |   Gen2 | Allocated |
|----------|--------------------|------------:|----------:|----------:|-------:|-------:|-------:|----------:|
| Basic    | N=23,00            |    716.5 ns |   2.72 ns |   2.54 ns | 0.1364 | 0.0010 |      - |     856 B |
| Advanced | N=23,00            |    719.9 ns |   2.87 ns |   2.55 ns | 0.1497 | 0.0010 |      - |     944 B |
| Basic    | N=956,00           | 31,995.6 ns | 189.04 ns | 176.83 ns | 5.6152 | 0.4883 | 0.1221 |   35576 B |
| Advanced | N=956,00           | 33,866.4 ns | 115.95 ns | 102.79 ns | 5.6763 | 0.1831 | 0.0610 |   35664 B |
