int age=34;
string fname="Kelvin";

if((age > 18) && (age < 25)){
    Console.WriteLine($"Hello {fname} you're of the required age");
    Console.WriteLine("And you're only allowed to sit on the second row");
} 
else{
    Console.WriteLine($"Hello {fname} you can sit on the first row");
}

Console.WriteLine($"My name is {fname} and I am {age} years old");

/*---LOOPS---*/
//We use loops to repeat statements that you want it to be executed more than once

/*----THE WHILE LOOP---*/
//The -while loop- checks the condition and execute the code untile when the condition is false;
//---++ is the increment operator and it adds 1 to the value of counter
//The -while loop- tests the condition before executing the code following the while

int counter=0;

while (counter < 10){
    Console.WriteLine($"The counter is at {counter} value");
    counter++;
}

/*<-----do while---->*/
//The -do while- executes the code first and then checks the condition

int count=0;
do{
    Console.WriteLine($"The count is: {count}");
    count++;
}
while(count < 20);

/*---FOR LOOP---*/

for(int cont=0; cont < 20; cont++ ){
    Console.WriteLine($"The count is {cont}");
}

/*--NESTED LOOPS--*/

for (int row=0; row < 11 ; row++){
    for(char column='a';column < 'k';column++){
        Console.WriteLine($"The cell is ({row},{column})");
    }
}