namespace peleng_test_task.operations;

class DivideOperation : IOperation
{
    public double? Call(params double[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Divide operation requires exactly two arguments.");
            return null;
        }

        if (args[1] == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            return null;
        }

        return args[0] / args[1];
    }
}