
using System.Text;

public class NumbersRepository
{
    private readonly int[] sourceNumbersList;

    public NumbersRepository(params int[] sourceNumbersList)
    {
        this.sourceNumbersList = sourceNumbersList;
    }

    public IEnumerable<string> GetNumbers(IEnumerable<Number> numbers)
    {
        var resultList = new List<string>();

        for (int index = 0; index < sourceNumbersList.Length; index++)
        {
            string replacedNum = sourceNumbersList[index].ToString();

            var replacements = new List<string>();
            replacedNum = GetReplacedNum(numbers, index, replacedNum, replacements);

            if (replacements.Count > 0)
            {
                replacedNum = string.Join(" good-boy-", replacements);
            }

            resultList.Add(replacedNum);
        }

        return resultList;
    }

    private string GetReplacedNum(IEnumerable<Number> numbers, int index, string replacedNum, List<string> replacements)
    {
        foreach (var number in numbers)
        {
            if (sourceNumbersList[index] % number.Reason == 0)
            {
                replacedNum = StringExtension.Replace(sourceNumbersList[index].ToString(), number.ReplacedWord);
                replacements.Add(number.ReplacedWord);
            }
        }

        return replacedNum;
    }
}

