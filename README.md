# 🎄 Advent of Code 2022 (C#) 🎅
### Repository with solutions for [Advent of Code 2022](https://adventofcode.com/2022).

Santa's reindeer typically eat regular reindeer food, but they need a lot of magical energy to deliver presents on Christmas. For that, their favorite snack is a special type of ⭐ fruit that only grows deep in the jungle. The Elves have brought you on their annual expedition to the grove where the fruit grows.

To supply enough magical energy, the expedition needs to retrieve a minimum of fifty ⭐s by December 25th. Although the Elves assure you that the grove has plenty of fruit, you decide to grab any fruit you see along the way, just in case.

Collect ⭐s by solving puzzles. Two puzzles will be made available on each day in the Advent calendar; the second puzzle is unlocked when you complete the first. Each puzzle grants one ⭐.


## 🦌🦌 My progress 🦌🦌
⭐ ⭐ ⭐ ⭐ ⭐ ⭐ ⭐ ⭐ ⭐ ⭐ ⭐ ⭐ ⭐ ⭐ ⭐ ⭐ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★ ★

![Calendar](./docs/assets/calendar.png)

## ✔️ Tasks
| Day | Task details                                        | Collected ⭐s | Benchmark results                        |
|-----|-----------------------------------------------------|--------------|------------------------------------------|
| 01  | [Calorie Counting](./docs/tasks/DayOne.md)          | ⭐ ⭐          | [Benchmarks](./docs/results/DayOne.md)   |
| 02  | [Rock Paper Scissors](./docs/tasks/DayTwo.md)       | ⭐ ⭐          | [Benchmarks](./docs/results/DayTwo.md)   |
| 03  | [Rucksack Reorganization](./docs/tasks/DayThree.md) | ⭐ ⭐          | [Benchmarks](./docs/results/DayThree.md) |
| 04  | [Camp Cleanup](./docs/tasks/DayFour.md)             | ⭐ ⭐          | [Benchmarks](./docs/results/DayFour.md)  |
| 05  | [Supply Stacks](./docs/tasks/DayFive.md)            | ⭐ ⭐          | [Benchmarks](./docs/results/DayFive.md)  |
| 06  | [Tuning Trouble](./docs/tasks/DaySix.md)            | ⭐ ⭐          | [Benchmarks](./docs/results/DaySix.md)   |
| 07  | [No Space Left On Device](./docs/tasks/DaySeven.md) | ⭐ ⭐          | [Benchmarks](./docs/results/DaySeven.md) |
| 08  | [Treetop Tree House](./docs/tasks/DayEight.md)      | ⭐ ⭐          | [Benchmarks](./docs/results/DayEight.md) |

## 📂 Structure
* Every task has a dedicated .NET 7.0 project in the `src` directory.
* There is a special project `Runner` (Console application) to run any daily tasks or benchmarks.
* For every project with daily tasks in the `src` directory there is a dedicated test project in the `tests/unit` and `test/benchmarks` folders.
* Every project name is based on the day in the calendar, ex. `DayOne`, `DayTwo`, etc.
* Name of every unit tests project is based on the tasks project name with the `.Tests.Unit` suffix.
* Name of every benchmark test project is based on the tasks project name with the `.Tests.Benchmarks` suffix.

```text
📂 AdventOfCode/
|
├─ 📕 deps/
|     Utils and helpers libraries
|
├─ 📓 docs/
│  ├─ 🖼️ assets/
|  |     Static content like pictures for documentation
│  ├─ 📈 results/
|  |     Benchmarks results
│  └─ ☑️ tasks/
|        Tasks descriptions
|
├─ 📘 src/
│  ├─ ⚙️ Runner/
│  └─ ✅ Day<Number>/
|     |- Project files
|     └- day-<day_number>.inputdata
|
└─ 📗 tests/
   ├─ 🚀 benchmarks/
   |  └─ ⚙️ Day<Number>.Tests.Benchmarks/
   └─ 🧪 unit/
      └─ ⚙️ Day<Number>.Tests.Unit/
         |- Project files
         └- day-<day_number>.testdata
```

## 🛠 Usage
### Install .NET Core
Go to [.NET download page](https://dot.net) and download the latest 7.0 version.

### Run all tasks
```bash
cd src/Runner
dotnet run
```

### Run tasks from day
```bash
cd src/Runner
dotnet run -- run-tasks -d <day_number>
```

### Run tests
```bash
dotnet test
```

### Run benchmarks
```bash
cd src/Runner
dotnet run -c Release -- run-benchmark -d <day_number>
```

## 📜 Wants more?
Check out my colleagues repositories, who are also taking part in this year AoC.
- [Lidjan](https://github.com/minidmnv/aoc2022) (TypeScript)

## 🧙 Author
Authored completely by Mateusz Bryll