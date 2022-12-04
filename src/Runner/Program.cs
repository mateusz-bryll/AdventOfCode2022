using Microsoft.Extensions.DependencyInjection;
using Runner.Extensions;
using Runner.Utils;
using Runner.Utils.Commands;

var servicesProvider = new ServiceCollection()
    .AddCommandBus()
    .AddTasks()
    .BuildServiceProvider();

using var scope = servicesProvider.CreateScope();
var commandBus = scope.ServiceProvider.GetRequiredService<CommandBus>();
var command = CommandLineUtils.ParseArguments(args);
commandBus.Send(command);