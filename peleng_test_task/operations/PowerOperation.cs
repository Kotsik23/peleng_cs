namespace peleng_test_task.operations;

class PowerOperation : IOperation
{
    private delegate double PowDelegate(double x, double y);

    private readonly PowDelegate _powDelegate = Math.Pow;

    public double? Call(params double[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Power operation requires exactly two arguments.");
            return null;
        }

        return _powDelegate(args[0], args[1]);
    }
}