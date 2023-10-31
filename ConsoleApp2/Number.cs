public class Number
{
    public string ReplacedWord { get; private set; }

    public int Reason { get; }

    public Number(string replacedWord, int reason)
    {
        ReplacedWord = replacedWord.ToLower();
        Reason = reason;
    }
}