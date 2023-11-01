namespace TestTask.NUnitTests
{
    /// <summary>
    /// ����� ��� �������� ����� � ��������� �����
    /// </summary>
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// ���� ����������� ������ ������� ��������� �� 3 � �� 5 ��� �������, �� ���� ������ �� fizz, buzz, fizz-buzz
        /// </summary>
        [Test]
        public void ReplaceFizzBuzzTest()
        {
            var repository = new NumbersRepository(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 });

            var rules = new List<Number> {
                new Number("fizz", 3),
                new Number("buzz", 5)
            };

            var replacer = new NumberReplacer(repository.InputNumberList, rules);

            var replacedNumbers = replacer.GetReplacedNumbers();

            string actualResult = string.Join(", ", replacedNumbers);
            var expected = "1, 2, fizz, 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz, 13, 14, fizz-buzz";
            Assert.AreEqual(actualResult, expected);
        }
        /// <summary>
        /// ���� ����������� ������ ������� ��������� �� 4 � �� 7 ��� �������, �� ���� ������ �� muzz, guzz, muzz-guzz
        /// </summary>
        [Test]
        public void ReplaceNumbersEvenFourAndSevenTest()
        {
            var repository = new NumbersRepository(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 });

            var rules = new List<Number> {
                new Number("fizz", 3),
                new Number("buzz", 5),
                new Number("muzz", 4),
                new Number("guzz", 7)
            };

            var replacer = new NumberReplacer(repository.InputNumberList, rules);

            var replacedNumbers = replacer.GetReplacedNumbers();
            string actualResult = string.Join(", ", replacedNumbers);

            var expected = "1, 2, fizz, muzz, buzz, fizz, guzz, muzz, fizz, buzz, 11, fizz-muzz, 13, guzz, fizz-buzz, fizz-buzz-muzz, fizz-buzz-guzz, fizz-buzz-muzz-guzz";
            Assert.AreEqual(actualResult, expected);
        }

        /// <summary>
        /// ���� ����������� ��������� �� 3 � 5 � ������ �����, ����� "good-boy" ����� �������, 
        /// </summary>
        [Test]
        public void ReplaceDogCatOnGoodBoyTest()
        {
            var repository = new NumbersRepository(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420});


            var rules = new List<Number> {
                new Number("dog", 3),
                new Number("cat", 5),
                new Number("muzz", 4),
                new Number("guzz", 7)
            };

            var replaceCommand = new NumberReplacer(repository.InputNumberList, rules);


            var replacedNumbers = replaceCommand.GetReplacedNumbers();

            string actualResult = string.Join(", ", replacedNumbers);
            var expected = "1, 2, dog, muzz, cat, dog, guzz, muzz, dog, cat, 11, fizz-muzz, 13, guzz, good-boy, good-boy-muzz, good-boy-guzz, good-boy-muzz-guzz";
            Assert.AreEqual(actualResult, expected);
        }
    }
}