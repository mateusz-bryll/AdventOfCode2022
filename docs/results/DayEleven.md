## Results
### Windows (i9 9900K, 64GB RAM)
| Method   | BenchmarkInputData |          Mean |      Error |     StdDev |   Gen0 | Allocated |
|----------|--------------------|--------------:|-----------:|-----------:|-------:|----------:|
| Basic    | N=27,00            |      7.946 us |  0.1385 us |  0.1296 us | 0.6256 |   5.13 KB |
| Advanced | N=27,00            |  3,220.910 us | 61.7608 us | 60.6573 us |      - |   5.63 KB |
| Basic    | N=55,00            |     29.644 us |  0.5859 us |  0.6269 us | 1.5869 |  13.02 KB |
| Advanced | N=55,00            | 14,619.369 us | 78.8551 us | 65.8476 us |      - |  13.24 KB |

### MacOS (Macbook Pro (2021) M1 Pro, 32GB RAM)

