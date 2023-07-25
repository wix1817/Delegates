namespace DelegateAndEvents;

public class ExecutionManager
{
    public Dictionary<Operation, Func<int>> FuncExecute { get; set; } = new Dictionary<Operation, Func<int>>();

    private Func<int> _sum;
    private Func<int> _substract;
    private Func<int> _multiply;

    public ExecutionManager(Func<int> sum, Func<int> subtract, Func<int> multiply)
    {
        _sum = sum;
        _substract = subtract;
        _multiply = multiply;
        PrepareExecution();
    }

    private void PrepareExecution()
    {
        FuncExecute.Add(Operation.Sum, _sum);
        FuncExecute.Add(Operation.Multiply, _multiply);
        FuncExecute.Add(Operation.Subtract, _substract);
    }
}