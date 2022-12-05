## Results
### Windows (i9 9900K, 64GB RAM)
| Method   | BenchmarkInputData |      Mean |     Error |    StdDev |    Gen0 |   Gen1 | Allocated |
|----------|--------------------|----------:|----------:|----------:|--------:|-------:|----------:|
| Basic    | String[511]        | 88.779 us | 0.7148 us | 0.6686 us | 16.9678 | 0.1221 | 138.63 KB |
| Advanced | String[511]        | 89.892 us | 1.1206 us | 0.9934 us | 16.9678 | 0.1221 | 138.63 KB |
| Basic    | String[9]          |  1.152 us | 0.0140 us | 0.0124 us |  0.2556 |      - |   2.09 KB |
| Advanced | String[9]          |  1.176 us | 0.0175 us | 0.0155 us |  0.2556 |      - |   2.09 KB |

### MacOS (Macbook Pro (2021) M1 Pro, 32GB RAM)

