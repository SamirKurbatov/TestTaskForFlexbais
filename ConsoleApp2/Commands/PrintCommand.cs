public class PrintCommand<T> : ICommand
{
    private readonly IEnumerable<T> repository;

    public PrintCommand(IEnumerable<T> repository)
    {
        this.repository = repository;
    }

    public bool CanExecute()
        => repository != null && repository.Count() != 0;

    public void Execute()
    {
        if (!CanExecute()) return;

        foreach (var item in repository)
        {
            Console.Write(item + ",");
        }
        Console.Write("\n");
    }
}
