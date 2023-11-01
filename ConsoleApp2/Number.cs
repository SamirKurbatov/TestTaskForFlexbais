namespace TestTask
{
    public class Number
    {
        public string ReplacedWord { get; }

        public int Reason { get; private set; }

        public Number(string replacedWord, int reason)
        {
            ReplacedWord = replacedWord.ToLower();
            Reason = reason;
        }
    }
}