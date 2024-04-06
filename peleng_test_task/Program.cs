using System.Globalization;
using peleng_test_task;

var calculator = new Calculator();
calculator.PrintOperations();

while (true)
{
    Console.Write("op: ");
    var operation = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(operation))
    {
        Console.WriteLine("Operation cannot be empty.");
        continue;
    }

    Console.Write("args: ");
    var argsInput = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(argsInput))
    {
        Console.WriteLine("Arguments cannot be empty.");
        continue;
    }

    var argsSplit = argsInput.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
    var arguments = new double[argsSplit.Length];
    var isValid = true;

    for (var i = 0; i < argsSplit.Length; i++)
    {
        if (!double.TryParse(argsSplit[i], NumberStyles.Any, CultureInfo.InvariantCulture, out var result))
        {
            Console.WriteLine($"'{argsSplit[i]}' is not a valid number.");
            isValid = false;
            break;
        }

        arguments[i] = result;
    }

    if (!isValid) continue;

    calculator.ExecuteOperation(operation, arguments);
}