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
|                                                       Method |      Mean |    Error |   StdDev |   Gen0 |   Gen1 | Allocated |
|------------------------------------------------------------- |----------:|---------:|---------:|-------:|-------:|----------:|
|                         FindElfCarryingMostCalories_TestData |  32.66 us | 0.419 us | 0.350 us | 0.9766 |      - |   8.21 KB |
| CalculateHowManyCaloriesTopThreeElfsCarryingInTotal_TestData |  33.31 us | 0.540 us | 0.451 us | 1.0376 |      - |   8.66 KB |
|                         FindElfCarryingMostCalories_RealData | 114.21 us | 1.360 us | 1.272 us | 8.7891 | 0.2441 |  72.38 KB |
| CalculateHowManyCaloriesTopThreeElfsCarryingInTotal_RealData | 119.34 us | 1.808 us | 1.602 us | 9.5215 | 0.3662 |  78.66 KB |
### MacOS (Macbook Pro (2021) M1 Pro, 32GB RAM)
|                                                       Method |     Mean |    Error |   StdDev |    Gen0 |   Gen1 | Allocated |
|------------------------------------------------------------- |---------:|---------:|---------:|--------:|-------:|----------:|
|                         FindElfCarryingMostCalories_TestData | 25.44 us | 0.145 us | 0.135 us |  1.4648 | 0.0305 |   9.06 KB |
| CalculateHowManyCaloriesTopThreeElfsCarryingInTotal_TestData | 25.48 us | 0.091 us | 0.081 us |  1.5259 | 0.0305 |   9.51 KB |
|                         FindElfCarryingMostCalories_RealData | 84.66 us | 0.377 us | 0.315 us | 11.8408 | 0.2441 |  73.23 KB |
| CalculateHowManyCaloriesTopThreeElfsCarryingInTotal_RealData | 87.53 us | 0.259 us | 0.242 us | 12.9395 | 0.4883 |  79.51 KB |