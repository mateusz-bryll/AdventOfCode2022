using System.Globalization;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Runner.Extensions;
using Runner.Utils;
using Runner.Utils.Commands;

ValidatorOptions.Global.LanguageManager.Culture = new CultureInfo("en");

var servicesProvider = new ServiceCollection()
    .AddCommandBus()
    .AddTasks()
    .AddBenchmarks()
    .BuildServiceProvider();

using var scope = servicesProvider.CreateScope();
var commandBus = scope.ServiceProvider.GetRequiredService<CommandBus>();
var command = CommandLineUtils.ParseArguments(args);
commandBus.Send(command);