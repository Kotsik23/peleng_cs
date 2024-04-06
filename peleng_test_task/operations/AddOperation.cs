namespace peleng_test_task.operations;

public class AddOperation : IOperation
{
    public double? Call(params double[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Add operation is required at least two arguments");
            return null;
        }

        return args.Sum();
    }
}