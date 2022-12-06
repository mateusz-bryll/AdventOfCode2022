## Results
### Windows (i9 9900K, 64GB RAM)
| Method   | BenchmarkInputData |         Mean |     Error |    StdDev | Allocated |
|----------|--------------------|-------------:|----------:|----------:|----------:|
| Basic    | N=30,00            |     27.75 ns |  0.178 ns |  0.158 ns |         - |
| Advanced | N=30,00            |     60.50 ns |  0.574 ns |  0.537 ns |         - |
| Basic    | N=4095,00          |  6,725.47 ns | 38.294 ns | 33.946 ns |         - |
| Advanced | N=4095,00          | 19,749.20 ns | 72.315 ns | 67.643 ns |         - |

### MacOS (Macbook Pro (2021) M1 Pro, 32GB RAM)
| Method   | BenchmarkInputData |         Mean |      Error |     StdDev | Allocated |
|----------|--------------------|-------------:|-----------:|-----------:|----------:|
| Basic    | N=30,00            |     31.99 ns |   0.040 ns |   0.037 ns |         - |
| Advanced | N=30,00            |     64.36 ns |   0.087 ns |   0.072 ns |         - |
| Basic    | N=4095,00          |  7,713.75 ns |  15.080 ns |  14.106 ns |         - |
| Advanced | N=4095,00          | 14,081.66 ns | 144.350 ns | 127.962 ns |         - |
