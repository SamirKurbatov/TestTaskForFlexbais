int number = int.Parse(Console.ReadLine());

if (number % 3 == 0)
{
    var replacedStr = "fizz";
    var str = StringExtension.Replace(number.ToString(), replacedStr);
    Console.Write(str + " ");
}


class MyClass
{

}



public static class StringExtension
{
    public static string Replace(this string inputStr, string replaceStr)
    {
        inputStr = replaceStr;
        return inputStr;
    }
}