using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Commands
{
    public class ReplaceCommand
    {
        public List<string> GetReplacedNumbers(IEnumerable<int> numbers, List<Number> replacementRules)
        {
            if (numbers is null) throw new ArgumentNullException(nameof(numbers));
            if (replacementRules is null) throw new ArgumentNullException(nameof(replacementRules));

            var resultList = new List<string>();

            foreach (int number in numbers)
            {
                var replacements = replacementRules
                    .Where(rule => number % rule.Reason == 0)
                    .Select(rule => rule.ReplacedWord)
                    .ToList();

                InsertKeyWordBeforeNumber(number, replacements, "good", "boy");

                if (replacements.Count == 0)
                {
                    resultList.Add(number.ToString());
                }
                else
                {
                    resultList.Add(string.Join("-", replacements));
                }
            }

            return resultList;
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
