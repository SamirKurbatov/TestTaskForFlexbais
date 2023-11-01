
namespace TestTask
{
    public class NumberReplacer
    {
        private readonly IEnumerable<int> numbers;

        private readonly IEnumerable<Number> replacementRules;

        public NumberReplacer(IEnumerable<int> numbers, IEnumerable<Number> replacementRules)
        {
            if (numbers is null)  throw new ArgumentNullException(nameof(numbers));
            if (replacementRules is null)  throw new ArgumentNullException(nameof(replacementRules));

            this.numbers = numbers;
            this.replacementRules = replacementRules;
        }

        public IEnumerable<string> GetReplacedNumbers()
        {
            var resultNumbersCollection = new List<string>();

            foreach (int number in numbers)
            {
                var replacements = replacementRules
                    .Where(rule => number % rule.Reason == 0)
                    .Select(rule => rule.ReplacedWord)
                    .ToList();

                InsertKeyWordBeforeNumber(number, replacements, "good", "boy");

                if (replacements.Count == 0)
                {
                    resultNumbersCollection.Add(number.ToString());
                }
                else
                {
                    resultNumbersCollection.Add(string.Join("-", replacements));
                }
            }

            return resultNumbersCollection;
        }

        private static void InsertKeyWordBeforeNumber(
            int number,
            List<string> replacements,
            string firstWord,
            string secondWord)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                var replacementNumber = number.ToString();
                if (replacements.Contains("cat") && replacements.Contains("dog"))
                {
                    var replaceWord = string.Join("-",
                        replacementNumber.Replace(firstWord),
                        replacementNumber.Replace(secondWord));

                    replacements.Remove("cat");
                    replacements.Remove("dog");
                    replacements.Insert(0, replaceWord);
                }
            }
        }
    }
}
