using peleng_test_task.operations;

namespace peleng_test_task;

public class Calculator
{
    private readonly Dictionary<string, IOperation> _operations = new(StringComparer.OrdinalIgnoreCase)
    {
        { "add", new AddOperation() },
        { "subtract", new SubtractOperation() },
        { "multiply", new MultiplyOperation() },
        { "divide", new DivideOperation() },
        { "power", new PowerOperation() },
        { "sqrt", new SqrtOperation() },
        { "sin", new SinOperation() }
    };

    public void PrintOperations()
    {
        Console.WriteLine("Available operations:");
        foreach (var op in _operations.Keys)
        {
            Console.Write($"{op}\t");
        }

        Console.WriteLine("\n");
    }

    public void ExecuteOperation(string operationName, params double[] args)
    {
        if (!_operations.TryGetValue(operationName.ToLower(), out var operation))
        {
            Console.WriteLine($"Operation '{operationName}' is not defined");
            return;
        }

        var result = operation.Call(args);
        if (result.HasValue)
        {
            Console.WriteLine($"Result: {result}");
        }
    }
}