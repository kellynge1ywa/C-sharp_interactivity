var names= new List<string>{"Kelly","Korir","Ngeiywa"};
names.Add("Alex"); //add an item to the list
names.Add("Elias");
names.Add("Ruth");
names.Remove("Korir"); // removes an item from the list
names.Remove("Ngeiywa");
names.Sort(); //sorts the list

foreach(var name in names){
    Console.WriteLine($"Hello {name}");
}
Console.WriteLine($"The first is {names[0]}");
Console.WriteLine($"The second is {names[1]}");
Console.WriteLine($"The third is {names[2]}");
Console.WriteLine($"The fourth is {names[3]}");

Console.WriteLine($"All the names are {names.Count}");

var index= names.IndexOf("Faith"); //search for an item from the list
if (index != -1){
    Console.WriteLine($"The name {names[index]} is at {index}");
}else{
    // var notFound=names.IndexOf("Not found");
    Console.WriteLine($"Not found");
}


/*<-----ARRAY OF NUMBERS----->*/

var fibonaciNumbers= new List<int>{2,2};
var third=fibonaciNumbers[fibonaciNumbers.Count - 1];
var fourth=fibonaciNumbers[fibonaciNumbers.Count - 2];

fibonaciNumbers.Add(third + fourth);
foreach (var num in fibonaciNumbers){
    Console.WriteLine(num);
}

/*<-----Exercise---->*/

var fibbos= new List<int>{1,1};
while (fibbos.Count < 20){
    var last=fibbos[fibbos.Count - 1];
    var next=fibbos[fibbos.Count - 2];

    fibbos.Add(last + next);
}

foreach (var number in fibbos){
    Console.WriteLine(number);
}