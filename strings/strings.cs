string myWord="Hujambo";
Console.WriteLine($"The word has {myWord.Length} characters"); //find the length of your variable value.

string myW="  Mambo    ";
Console.WriteLine(myW.TrimStart()); //remove spaces at the beginning of a variable

string myWe=myW.TrimEnd(); // remove spaces at the end of a variable.
Console.WriteLine(myWe);

string myWn=myW.Trim(); //remove spaces at both ends.
Console.WriteLine(myWn);

myW=myW.Replace("Mambo", "Niaje"); //replacing the value of an initial value.
Console.WriteLine(myW);

string myTunda="Chungwa";

Console.WriteLine(myTunda.ToUpper()); // formating string value to upper case
Console.WriteLine(myTunda.ToLower());// formatting string value to lower case
Console.WriteLine(myWord.ToLower());

string word="Hello there my name is Kelly";
Console.WriteLine(word.Contains("Kelly")); //checking if a word is in a sentence
Console.WriteLine(word.Contains("wewe"));

var result1=word.StartsWith("Hello"); //check if a sentence starts with the specified word;
Console.WriteLine(result1);

var endW=word.EndsWith("Kelly"); //check if a sentence ends with the specified word
Console.WriteLine(endW);
