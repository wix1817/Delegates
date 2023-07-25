namespace DelegateAndEvents;

public class OperationManager
{
    private int _first;
    private int _second;
    private ExecutionManager _executionManager;
    public OperationManager(int first, int second)
    {
        _first = first;
        _second = second;
        _executionManager = new ExecutionManager(Sum, Subtract, Multiply);
    }
    private int Sum()
    {
        return _first + _second;
    }
    private int Subtract()
    {
        return _first - _second;
    }
    private int Multiply()
    {
        return _first * _second;
    }
    public int Execute(Operation operation)
    {
        return _executionManager.FuncExecute[operation].Invoke();
    }
}