## Results
### Windows (i9 9900K, 64GB RAM)
| Method                                                      | AssignmentStrings |        Mean |     Error |    StdDev |   Gen0 | Allocated |
|-------------------------------------------------------------|-------------------|------------:|----------:|----------:|-------:|----------:|
| CountHowManyAssignmentPairsDoesOneRangeFullyContainTheOther | String[1000]      | 78,275.5 ns | 995.97 ns | 882.90 ns |      - |      32 B |
| CountHowManyAssignmentPairsDoesOneRangeOverlapTheOther      | String[1000]      | 73,472.4 ns | 938.65 ns | 878.01 ns |      - |      32 B |
| CountHowManyAssignmentPairsDoesOneRangeFullyContainTheOther | String[6]         |    389.9 ns |   5.95 ns |   5.56 ns | 0.0038 |      32 B |
| CountHowManyAssignmentPairsDoesOneRangeOverlapTheOther      | String[6]         |    416.5 ns |   7.96 ns |   7.82 ns | 0.0038 |      32 B |

### MacOS (Macbook Pro (2021) M1 Pro, 32GB RAM)