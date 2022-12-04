using CommandLine;
using Runner.Utils.Commands;

namespace Runner.Utils;

public static class CommandLineUtils
{
    public static ICommand ParseArguments(string[] args)
    {
        var parser = new Parser(configuration =>
        {
            configuration.CaseInsensitiveEnumValues = true;
            configuration.AutoHelp = true;
            configuration.HelpWriter = Console.Out;
        });
        
        return parser.ParseArguments(args, GetAvailableCommands()).Value as ICommand ?? throw new InvalidOperationException();
    }

    private static Type[] GetAvailableCommands() => AppDomain.CurrentDomain.GetAssemblies()
        .SelectMany(assembly => assembly.GetTypes())
        .Where(type => type.GetCustomAttributes(typeof(VerbAttribute), false).Length > 0 && type.IsAssignableTo(typeof(ICommand)))
        .ToArray();
}
