
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class NumbersRepository
{
    private readonly List<int> inputNumberList;

    public IEnumerable<int> InputNumberList => inputNumberList;

    public NumbersRepository(List<int> inputNumberList)
    {
        this.inputNumberList = inputNumberList;
    }
}

