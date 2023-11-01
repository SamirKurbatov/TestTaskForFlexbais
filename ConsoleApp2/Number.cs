public class Number
{
    public string ReplacedWord { get; private set; }

    public int Reason { get; }

    public Number(string replacedWord, int reason)
    {
        if (replacedWord == null) throw new ArgumentNullException(nameof(replacedWord));

        ReplacedWord = replacedWord.ToLower();
        Reason = reason;
    }
}

