## Results
### Windows (i9 9900K, 64GB RAM)
| Method                                               | CaloriesList |        Mean |     Error |    StdDev |   Gen0 | Allocated |
|------------------------------------------------------|--------------|------------:|----------:|----------:|-------:|----------:|
| FindElfCarryingMostCalories                          | String[15]   |    273.3 ns |   4.15 ns |   3.88 ns | 0.0114 |      96 B |
| CalculateHowManyCaloriesTopThreeElvesCarryingInTotal | String[15]   |    444.0 ns |   7.98 ns |   7.46 ns | 0.0658 |     552 B |
| FindElfCarryingMostCalories                          | String[2245] | 36,977.8 ns | 229.49 ns | 191.64 ns |      - |      96 B |
| CalculateHowManyCaloriesTopThreeElvesCarryingInTotal | String[2245] | 41,104.6 ns | 511.49 ns | 453.42 ns | 0.7324 |    6528 B |

### MacOS (Macbook Pro (2021) M1 Pro, 32GB RAM)
| Method                                               | CaloriesList |        Mean |    Error |   StdDev |   Gen0 | Allocated |
|------------------------------------------------------|--------------|------------:|---------:|---------:|-------:|----------:|
| FindElfCarryingMostCalories                          | String[15]   |    206.8 ns |  0.34 ns |  0.30 ns | 0.0153 |      96 B |
| CalculateHowManyCaloriesTopThreeElvesCarryingInTotal | String[15]   |    347.9 ns |  3.82 ns |  3.38 ns | 0.0877 |     552 B |
| FindElfCarryingMostCalories                          | String[2245] | 26,530.4 ns | 52.90 ns | 49.48 ns |      - |      96 B |
| CalculateHowManyCaloriesTopThreeElvesCarryingInTotal | String[2245] | 29,228.3 ns | 77.54 ns | 72.54 ns | 1.0376 |    6528 B |


