## Results
### Windows (i9 9900K, 64GB RAM)
| Method   | BenchmarkInputData |       Mean |     Error |    StdDev |    Gen0 |   Gen1 | Allocated |
|----------|--------------------|-----------:|----------:|----------:|--------:|-------:|----------:|
| Basic    | String[511]        |  89.832 us | 1.0659 us | 0.9971 us | 18.3105 | 0.1221 | 150.27 KB |
| Advanced | String[511]        | 103.871 us | 1.2652 us | 1.1835 us | 23.8037 | 0.1221 | 195.03 KB |
| Basic    | String[9]          |   1.141 us | 0.0158 us | 0.0140 us |  0.2537 |      - |   2.09 KB |
| Advanced | String[9]          |   1.238 us | 0.0153 us | 0.0135 us |  0.2842 |      - |   2.34 KB |

### MacOS (Macbook Pro (2021) M1 Pro, 32GB RAM)

