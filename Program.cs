// using System.Linq;
// Console.WriteLine("Hello, World!");

// data types
// statically typed

// integer
// Console.WriteLine(128);
// Console.WriteLine(-10);
// Console.WriteLine(0);

// float/double
// Console.WriteLine(3.14159);
// Console.WriteLine(9.75);
// Console.WriteLine(-3.14159);
// Console.WriteLine(0.0);
// Console.WriteLine(8.0);

// booleans
// Console.WriteLine(true);
// Console.WriteLine(false);

// strings
// Console.WriteLine("Hello, World!");
// literal

// null

// variables
// int catCount; // declaring
// catCount = 1; // assignment
// int catCount = 1; // cat_count CAT_COUNT cat-count

// Console.WriteLine("The number of cats I own:");
// Console.WriteLine(catCount);

// operators
// Console.WriteLine((10 + 5) * 3);
// value
// expression
// literal
// operator
// statement
// Console.WriteLine(10 + 5); // prints 15
// Console.WriteLine(10 - 5); // prints  5
// Console.WriteLine(10 * 5); // prints 50
// Console.WriteLine(10 / 5); // prints  2
// Console.WriteLine(14.0 / 5.0); 
// Console.WriteLine(14.0 % 5.0); 

// double a = 5.2;
// a %= 2;
// Console.WriteLine(a); 

// conditional operators
// int a = 5;
// int b = 5;
// int c = 10;
// Console.WriteLine(a  c);

// int age = 16;
// if(age < 18){
//     Console.WriteLine("You are not old enough.");
// }
// else if(age < 21){
//     Console.WriteLine("You are almost old enough.");
// }
// else{
//     Console.WriteLine("You are old enough!");
// }

// int idx = 10;

// while(idx > 0){
//     Console.WriteLine(idx);
//     idx = idx - 1;
// }

// syntactic sugar

// initialize
// check condition
// block
// end of block
// condition again

// for(int idx = 0; idx < 3; idx++){
//     Console.WriteLine(idx);
// }

// for (int var = 0; var < 3; var++)
// {
//     //
// }

// int[] numbers = {5, 3, 9, 20, 4, 13};
// Console.WriteLine(numbers.ToList().Max());
// int lowest = numbers[0];
// for (int idx = 0; idx < numbers.Length; idx++)
// {
//     if(lowest > numbers[idx]){
//         lowest = numbers[idx];
//     }
// }
// Console.WriteLine(lowest);
Random rand = new Random();
for (int idx = 0; idx < 5; idx++)
{
    float val = rand.NextSingle() * 6;
    val = MathF.Ceiling(val);
    Console.WriteLine(val);
}