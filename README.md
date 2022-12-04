# Advent of Code 2022 (C#)
Repository with solutions for Advent of Code 2022 - https://adventofcode.com/2022.

Santa's reindeer typically eat regular reindeer food, but they need a lot of magical energy to deliver presents on Christmas. For that, their favorite snack is a special type of ⭐ fruit that only grows deep in the jungle. The Elves have brought you on their annual expedition to the grove where the fruit grows.

To supply enough magical energy, the expedition needs to retrieve a minimum of fifty ⭐s by December 25th. Although the Elves assure you that the grove has plenty of fruit, you decide to grab any fruit you see along the way, just in case.

Collect ⭐s by solving puzzles. Two puzzles will be made available on each day in the Advent calendar; the second puzzle is unlocked when you complete the first. Each puzzle grants one ⭐.


## My progress
⭐ ⭐ ⭐ ⭐ ⭐ ⭐ ⭐ ⭐ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★

![Calendar](./docs/assets/calendar.png)

## Tasks
| Day | Task details                                        | Collected ⭐s | Benchmark results                        |
|-----|-----------------------------------------------------|--------------|------------------------------------------|
| 01  | [Calorie Counting](./docs/tasks/DayOne.md)          | ⭐ ⭐          | [Benchmarks](./docs/results/DayOne.md)   |
| 02  | [Rock Paper Scissors](./docs/tasks/DayTwo.md)       | ⭐ ⭐          | [Benchmarks](./docs/results/DayTwo.md)   |
| 03  | [Rucksack Reorganization](./docs/tasks/DayThree.md) | ⭐ ⭐          | [Benchmarks](./docs/results/DayThree.md) |
| 04  | [Camp Cleanup](./docs/tasks/DayFour.md)             | ⭐ ⭐          | [Benchmarks](./docs/results/DayFour.md)  |

## Structure
* Every task has a dedicated .NET 7.0 project in the `src` directory.
* For every project in the `src` directory there is a dedicated test project in the `tests` folder.
* Every project is named based on the day in the calendar, ex. `DayOne`, `DayTwo`, etc.
* Name of every test project has a name of the task project with `.Tests.Unit` suffix.
* Name of every benchmark project has a name of the task project with `.Tests.Benchmarks` suffix.

## Usage
### Install .NET Core
Go to: https://dot.net and download the latest version

### Run all tasks
Use your terminal of choice and run:
```bash
cd src/Runner
dotnet run
```

### Run tasks from day
Use your terminal of choice and run:
```bash
cd src/Runner
dotnet run -- run-tasks -d <day_number>
```

### Run tests
```bash
cd tests/unit/<ProjectName>.Tests.Unit #ex. tests/unit/DayOne.Tests.Unit
dotnet test
```

### Run benchmarks
```bash
cd tests/benchmarks/<ProjectName>.Tests.Benchmarks #ex. tests/benchmarks/DayOne.Tests.Benchmarks
dotnet run -c Release
```

## Author
Authored completely by Mateusz Bryll