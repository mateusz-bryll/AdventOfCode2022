## Results
### Windows (i9 9900K, 64GB RAM)
| Method                                                  | EncodedRucksacks |         Mean |       Error |      StdDev |   Gen0 | Allocated |
|---------------------------------------------------------|------------------|-------------:|------------:|------------:|-------:|----------:|
| CalculateSumOfPrioritiesForEncodedRucksacks             | String[300]      |  25,448.3 ns |   116.13 ns |   102.95 ns |      - |      32 B |
| CalculateSumOfPrioritiesOfBadgeItemsForEncodedRucksacks | String[300]      | 263,996.3 ns | 2,174.40 ns | 1,927.55 ns | 4.3945 |   36776 B |
| CalculateSumOfPrioritiesForEncodedRucksacks             | String[6]        |     237.3 ns |     1.49 ns |     1.32 ns | 0.0038 |      32 B |
| CalculateSumOfPrioritiesOfBadgeItemsForEncodedRucksacks | String[6]        |   3,084.5 ns |    22.24 ns |    20.80 ns | 0.1259 |    1080 B |
### MacOS (Macbook Pro (2021) M1 Pro, 32GB RAM)
| Method                                                  | EncodedRucksacks |         Mean |     Error |    StdDev |   Gen0 |   Gen1 | Allocated |
|---------------------------------------------------------|------------------|-------------:|----------:|----------:|-------:|-------:|----------:|
| CalculateSumOfPrioritiesForEncodedRucksacks             | String[300]      |  16,415.0 ns | 113.66 ns | 106.32 ns |      - |      - |      32 B |
| CalculateSumOfPrioritiesOfBadgeItemsForEncodedRucksacks | String[300]      | 137,160.7 ns | 817.95 ns | 725.09 ns | 5.8594 | 0.2441 |   36776 B |
| CalculateSumOfPrioritiesForEncodedRucksacks             | String[6]        |     181.4 ns |   0.38 ns |   0.35 ns | 0.0050 |      - |      32 B |
| CalculateSumOfPrioritiesOfBadgeItemsForEncodedRucksacks | String[6]        |   1,569.9 ns |   3.03 ns |   2.84 ns | 0.1717 |      - |    1080 B |
