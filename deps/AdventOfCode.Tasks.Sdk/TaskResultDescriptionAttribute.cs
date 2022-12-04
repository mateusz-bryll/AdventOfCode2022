namespace AdventOfCode.Tasks.Sdk;

[AttributeUsage(AttributeTargets.Method)]
public class TaskResultDescriptionAttribute : Attribute
{
    public string Text { get; }

    public TaskResultDescriptionAttribute(string text)
    {
        Text = text;
    }
}
