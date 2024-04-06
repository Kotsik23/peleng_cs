namespace peleng_test_task.operations;

public class SubtractOperation : IOperation
{
    public double? Call(params double[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Subtract operation requires at least two arguments.");
            return null;
        }

        var result = args[0];
        for (var i = 1; i < args.Length; i++)
        {
            result -= args[i];
        }

        return result;
    }
}