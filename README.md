# Advent of Code 2022 (C#)
Repository with solutions for Advent of Code 2022 - https://adventofcode.com/2022.

## My progress
Santa's reindeer typically eat regular reindeer food, but they need a lot of magical energy to deliver presents on Christmas. For that, their favorite snack is a special type of ⭐ fruit that only grows deep in the jungle. The Elves have brought you on their annual expedition to the grove where the fruit grows.

To supply enough magical energy, the expedition needs to retrieve a minimum of fifty ⭐s by December 25th. Although the Elves assure you that the grove has plenty of fruit, you decide to grab any fruit you see along the way, just in case.

Collect ⭐s by solving puzzles. Two puzzles will be made available on each day in the Advent calendar; the second puzzle is unlocked when you complete the first. Each puzzle grants one ⭐.


![Calendar](./docs/assets/calendar.png)

## Tasks
* [Day 1: Calorie Counting](./docs/DayOne.md)
* [Day 2: Rock Paper Scissors](./docs/DayTwo.md)
* [Day 3: Rucksack Reorganization](./docs/DayThree.md)

## Structure
* Every task has a dedicated .NET 7.0 project in the `src` directory.
* For every project in the `src` directory there is a dedicated test project in the `tests` folder.
* Every project is named based on the day in the calendar, ex. `DayOne`, `DayTwo`, etc.
* Name of every test project has a name of the task project with `.Tests.Unit` suffix.
* Name of every benchmark project has a name of the task project with `.Tests.Benchmarks` suffix.

## Usage
### Install .NET Core
Go to: https://dot.net and download the latest version

### Run project
Use your terminal of choice and run:
```bash
cd src/<ProjectName> #ex. src/DayOne
dotnet run
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