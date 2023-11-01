using TestTask;

public class PrintCommand : ICommand
{
    private readonly NumberReplacer numberReplacer;

    public PrintCommand(NumberReplacer numberReplacer)
    {
        this.numberReplacer = numberReplacer;
    }

    public bool CanExecute()
        => numberReplacer != null;

    public void Execute()
    {
        if (!CanExecute()) 
            return;

        IEnumerable<string> replacedNumbers = numberReplacer.GetReplacedNumbers();

        foreach (var item in replacedNumbers)
        {
            Console.Write(item + ",");
        }

        Console.Write("\n");
    }
}
