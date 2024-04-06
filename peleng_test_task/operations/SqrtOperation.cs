namespace peleng_test_task.operations;

class SqrtOperation : IOperation
{
    private delegate double SqrtDelegate(double d);

    private readonly SqrtDelegate _sqrtDelegate = Math.Sqrt;

    public double? Call(params double[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Sqrt operation requires exactly one argument.");
            return null;
        }

        if (args[0] < 0)
        {
            Console.WriteLine("Cannot take the square root of a negative number.");
            return null;
        }

        return _sqrtDelegate(args[0]);
    }
}