namespace peleng_test_task.operations;

public class MultiplyOperation : IOperation
{
    public double? Call(params double[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Multiply operation requires at least two arguments.");
            return null;
        }

        return args.Aggregate(1.0, (current, arg) => current * arg);
    }
}