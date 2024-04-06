namespace peleng_test_task.operations;

public class SinOperation : IOperation
{
    private delegate double SinDelegate(double a);

    private readonly SinDelegate _sinDelegate = Math.Sin;

    public double? Call(params double[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Sin operation requires one argument.");
            return null;
        }

        return _sinDelegate(args[0]);
    }
}