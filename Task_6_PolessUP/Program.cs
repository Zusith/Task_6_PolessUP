using System.Collections;

double number = 2.345;
Console.WriteLine(WordFormatNumber(number));
Console.WriteLine(WordFormatNumber(-23.809));



string WordFormatNumber(double number)
{
    Hashtable numberswordtable = HashtableCreateForWordFormatNumber();
    string numbertext = number.ToString();
    string wordformattext = "";
    for (int letterindex = 0; letterindex < numbertext.Length; letterindex++)
    {
        wordformattext += numberswordtable[numbertext[letterindex]] + " ";
    }
    return wordformattext;
}

Hashtable HashtableCreateForWordFormatNumber() => new Hashtable
     {
        { '-', "minus" },
        { ',', "point" },
        { '0', "zero" },
        { '1', "one" },
        { '2', "two" },
        { '3', "three" },
        { '4', "four" },
        { '5', "five" },
        { '6', "six" },
        { '7', "seven" },
        { '8', "eight" },
        { '9', "nine" }
    };
