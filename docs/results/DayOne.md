## Results
### Windows (i9 9900K, 64GB RAM)
| Method   | BenchmarkInputData |        Mean |     Error |    StdDev |   Gen0 | Allocated |
|----------|--------------------|------------:|----------:|----------:|-------:|----------:|
| Basic    | String[15]         |    287.4 ns |   5.78 ns |   8.65 ns | 0.0114 |      96 B |
| Advanced | String[15]         |    438.2 ns |   5.75 ns |   5.37 ns | 0.0658 |     552 B |
| Basic    | String[2245]       | 37,234.6 ns | 362.94 ns | 339.49 ns |      - |      96 B |
| Advanced | String[2245]       | 41,325.4 ns | 655.05 ns | 580.69 ns | 0.7324 |    6528 B |


### MacOS (Macbook Pro (2021) M1 Pro, 32GB RAM)
| Method                                               | CaloriesList |        Mean |    Error |   StdDev |   Gen0 | Allocated |
|------------------------------------------------------|--------------|------------:|---------:|---------:|-------:|----------:|
| FindElfCarryingMostCalories                          | String[15]   |    206.8 ns |  0.34 ns |  0.30 ns | 0.0153 |      96 B |
| CalculateHowManyCaloriesTopThreeElvesCarryingInTotal | String[15]   |    347.9 ns |  3.82 ns |  3.38 ns | 0.0877 |     552 B |
| FindElfCarryingMostCalories                          | String[2245] | 26,530.4 ns | 52.90 ns | 49.48 ns |      - |      96 B |
| CalculateHowManyCaloriesTopThreeElvesCarryingInTotal | String[2245] | 29,228.3 ns | 77.54 ns | 72.54 ns | 1.0376 |    6528 B |


