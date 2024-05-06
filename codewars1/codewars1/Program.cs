using System;
// take input
// go through the input until the end
// every substring is a morse symbol
// make the string longer by adding the next substring as a character


// take input
// go through the input until the end
// every substring is a morse symbol
// make the string longer by adding the next substring as a character
string morseCode = ".... . -.--   .--- ..- -.. .";
string morseLetter = "";
string result = "";
int spaceCount = 0;
int forEachCount = 0;
foreach (char c in morseCode)
{
    morseLetter += c;
    Console.WriteLine("char c = " + c);
    forEachCount++;
    if (c == ' ' && spaceCount != 0)
    {
        spaceCount++;
        if (spaceCount == 3)
        {
            result += " ";
            Console.WriteLine("MorseCode.Get(morseLetter) =  ");
        }
        continue;
    }
    spaceCount = 0;
    Console.WriteLine("For Each Count: " + forEachCount + "  morseCode.Length: " + morseCode.Length);
    if ((c == ' ' && spaceCount == 0) || forEachCount == morseCode.Length)
    {
        spaceCount++;
        result += MorseCode(morseLetter); // should be MorseCode.Get(morseLetter)
        Console.WriteLine("MorseCode.Get(morseLetter) = " + MorseCode(morseLetter));
        morseLetter = "";
        continue;
    }



}
Console.WriteLine(result);



public static partial class Program
{
    public static string MorseCode(string myString)
    {
        return "a";
    }

}
