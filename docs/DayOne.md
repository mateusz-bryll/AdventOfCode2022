### --- Day 1: Calorie Counting ---
The jungle must be too overgrown and difficult to navigate in vehicles or access from the air; the Elves' expedition traditionally goes on foot. As your boats approach land, the Elves begin taking inventory of their supplies. One important consideration is food - in particular, the number of Calories each Elf is carrying (your puzzle input).


The Elves take turns writing down the number of Calories contained by the various meals, snacks, rations, etc. that they've brought with them, one item per line. Each Elf separates their own inventory from the previous Elf's inventory (if any) by a blank line.


For example, suppose the Elves finish writing their items' Calories and end up with the following list:
```
1000
2000
3000

4000

5000
6000

7000
8000
9000

10000

```
This list represents the Calories of the food carried by five Elves:
* The first Elf is carrying food with 1000, 2000, and 3000 Calories, a total of 6000 Calories.
* The second Elf is carrying one food item with 4000 Calories.
* The third Elf is carrying food with 5000 and 6000 Calories, a total of 11000 Calories.
* The fourth Elf is carrying food with 7000, 8000, and 9000 Calories, a total of 24000 Calories.
* The fifth Elf is carrying one food item with 10000 Calories.
* In case the Elves get hungry and need extra snacks, they need to know which Elf to ask: they'd like to know how many Calories are being carried by the Elf carrying the most Calories. In the example above, this is 24000 (carried by the fourth Elf).

Find the Elf carrying the most Calories. How many total Calories is that Elf carrying?

### --- Part Two ---
By the time you calculate the answer to the Elves' question, they've already realized that the Elf carrying the most Calories of food might eventually run out of snacks.

To avoid this unacceptable situation, the Elves would instead like to know the total Calories carried by the top three Elves carrying the most Calories. That way, even if one of those Elves runs out of snacks, they still have two backups.

In the example above, the top three Elves are the fourth Elf (with 24000 Calories), then the third Elf (with 11000 Calories), then the fifth Elf (with 10000 Calories). The sum of the Calories carried by these three elves is 45000.

Find the top three Elves carrying the most Calories. How many Calories are those Elves carrying in total?

## Results
### Windows (i9 9900K, 64GB RAM)
| Method                                               | CaloriesList |        Mean |     Error |    StdDev |   Gen0 | Allocated |
|------------------------------------------------------|--------------|------------:|----------:|----------:|-------:|----------:|
| FindElfCarryingMostCalories                          | String[15]   |    273.3 ns |   4.15 ns |   3.88 ns | 0.0114 |      96 B |
| CalculateHowManyCaloriesTopThreeElvesCarryingInTotal | String[15]   |    444.0 ns |   7.98 ns |   7.46 ns | 0.0658 |     552 B |
| FindElfCarryingMostCalories                          | String[2245] | 36,977.8 ns | 229.49 ns | 191.64 ns |      - |      96 B |
| CalculateHowManyCaloriesTopThreeElvesCarryingInTotal | String[2245] | 41,104.6 ns | 511.49 ns | 453.42 ns | 0.7324 |    6528 B |

### MacOS (Macbook Pro (2021) M1 Pro, 32GB RAM)
|                                                       Method |     Mean |    Error |   StdDev |    Gen0 |   Gen1 | Allocated |
|------------------------------------------------------------- |---------:|---------:|---------:|--------:|-------:|----------:|
|                         FindElfCarryingMostCalories_TestData | 25.44 us | 0.145 us | 0.135 us |  1.4648 | 0.0305 |   9.06 KB |
| CalculateHowManyCaloriesTopThreeElvesCarryingInTotal_TestData | 25.48 us | 0.091 us | 0.081 us |  1.5259 | 0.0305 |   9.51 KB |
|                         FindElfCarryingMostCalories_RealData | 84.66 us | 0.377 us | 0.315 us | 11.8408 | 0.2441 |  73.23 KB |
| CalculateHowManyCaloriesTopThreeElvesCarryingInTotal_RealData | 87.53 us | 0.259 us | 0.242 us | 12.9395 | 0.4883 |  79.51 KB |

