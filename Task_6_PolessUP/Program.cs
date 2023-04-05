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

Hashtable HashtableCreateForWordFormatNumber()
{ 
    Hashtable numbersWordTable = new Hashtable();
    numbersWordTable.Add('-', "minus");
    numbersWordTable.Add(',', "point");
    numbersWordTable.Add('0', "zero");
    numbersWordTable.Add('1', "one");
    numbersWordTable.Add('2', "two");
    numbersWordTable.Add('3', "three");
    numbersWordTable.Add('4', "four");
    numbersWordTable.Add('5', "five");
    numbersWordTable.Add('6', "six");
    numbersWordTable.Add('7', "seven");
    numbersWordTable.Add('8', "eight");
    numbersWordTable.Add('9', "nine");
    return numbersWordTable;
}