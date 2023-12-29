# Intro to C# Talk

## Setup

Open an empty folder in VS Code and open the console with `ctrl ~`.

Create a new project by running `dotnet new console` in the console.

Run the project with `dotnet run`.

It should print "Hello, World!" to the console.

## Data types

C# is what we call a "statically typed" language, meaning that every value in the language has a specific unchangeable type. This is opposed to dynamically typed languages like Python and JavaScript. So, what is a type?

As far as your computer is concerned everything is just numbers, ones and zeroes that it's shuffling around and modifying. But that homogenous data has to represent all kinds of things, text, images, sounds, and so on. When we're writing a program it's helpful to be able to say "this block of memory is text, this is a number, this value can only be true or false" and so on. A type is basically a tag that keeps us and the computer on the same page about what different bits of memory represent.

There are a few fundamental types we need to go over before we can start writing code.

> Sidebar, comments. You can create a comment with `//`. The computer will ignore everything after that comment symbol. This is a good way of leaving notes for yourself or temporarily disabling code. We'll return to comment etiquette and best practices later.

### Int

Integers are round numbers, with no fractional parts or decimals. They can be negative though.

```c#
Console.WriteLine(128);
Console.WriteLine(-10);
Console.WriteLine(0);
```

We would use an integer to store the answer to questions like "How many cats do I own?", "How many pennies are in my piggy bank?", and "How many roads must a man walk down (before you call him a man)?"

We'll discuss what `Console.WriteLine` means in a moment don't worry. For now just know that's a built in command that lets us print arbitrary values to the console.

### Floats and Doubles

Floating point numbers can represent any real number, including fractions and decimals, to a given level of precision. Floats are 32 bits and doubles are 64 bits so doubles allow more precision at the cost of using more memory. For our purposes we're mostly going to be using doubles.

```c#
Console.WriteLine(3.14159);
Console.WriteLine(9.75);
Console.WriteLine(-3.14159);
Console.WriteLine(0.0);
Console.WriteLine(8.0);
```

Note that floats can be negative and they don't have to have a decimal part, `8.0` is a valid double.

We would use a float to store the answer to questions like "How much does my cat weigh?", "How many liters of coffee do I drink in a day?", and "How many miles would I walk (for you)".

In other words integers are for discrete values and floats are for ~~indiscrete~~ continuous values. I can only meaningfully own a round number of cats, where there are technically an infinite number of weights my cat can have between, say, 9 and 10 pounds.

You might be tempted to store the number of miles I would walk for you (500) as an integer but distances are continuous. It's entirely possible for me to walk 500.79 miles for you (although it would be more awkward to sing).

### Booleans

Sometimes we simply want to represent a fact that is either true or false. Questions like "Do I own a cat?", "Did it rain today?", and "Is this the original Ship of Theseus?" have two possible answers, true and false. There is a special data type for that called a boolean.

```c#
Console.WriteLine(true);
Console.WriteLine(false);
```

Booleans are the only type that are named after a person, specifically, a 19th century mathematician named George Bool who developed what we now call "Boolean Algebra". At the end of the day all operations on the computer are boolean, 1 or 0, true or false. His work would go on to be the foundation of every device we use.

He also, and I'm not kidding about this, died of pneumonia after he walked to a lecture in the rain and delivered it in wet clothes. Take care of yourselves folks.

### Strings

When we first ran `dotnet new` it produced a source file for us `Program.cs` that looked like this:

```c#
Console.WriteLine("Hello, World!");
```

Wrapping some text in quotes like that is how we create a string `literal`, that is, a string that is in the code of our program as opposed to being read from a file, input by the user, downloaded off the internet, etc.

With a string we could store the answers to questions like "What is my cat's name?", "Is there in truth, no beauty?" and "What's the best Cyndi Lauper song?" 

### Null

Finally that brings us to null. Null is the absence of a value. Null is, let's say, a controversial language feature. Tony Hoare has called inventing null references his "billion dollar mistake". But most languages have some kind of null value and we'll explore that soon.

## Variables

We've explored various ways that data can be represented. Let's now look at how it can be stored. This is how we declare a variable.

```c#
int catCount;
catCount = 1;

Console.WriteLine("The number of cats I own:");
Console.WriteLine(catCount);
```

The part of the above program that's important right now is this:

```c#
int catCount;
catCount = 1;
```

On the first line we are declaring the variable. `int` is the variable type, and `catCount` is the variable name. In other words we told C# to set aside space for an integer value called "catCount". Note the capitalization. Style guides differ but variables are often written in something called camelCase, where the words in a variable name are distinguished by capitalizing the first letter of each word after the first.

On the next line we are assigning a value to catCount, in this case 1. Now when we go to print catCount it prints a 1 as we expect.

Nearly always declaring a variable and assigning a value to it are done on the same line like so:

```c#
int catCount = 1;
```

It is worth remembering though that these are technically two operations. We'll see plenty more examples of variable declaration and assignment going forward.

## Operators

So we have values, now we would like to do stuff to them. Behold:

```c#
Console.WriteLine(10 + 5); // prints 15
```

Awe inspiring. So what's happening here? Well this is going to sound like I'm dramatically over-explaining something simple but there are a few terms I want to make sure we're comfortable with.

Value: A piece of data of some type.
Expression: A section of code that evaluates to some value.
Literal: A value from the code itself, not loaded from a file or some other source.
Operator: A symbol like + that performs an operation on some value or values.
Variable: A named section of memory, big enough to store a value of some type.
Statement: A larger section of code that does not evaluate to anything. Typically it performs some action like declaring a variable.

So with all that out of the way let's look at our program again.

5 in "5 + 10" is an `integer literal`, that 5 is coming from our source code.
"+" is an `operator`, it is adding two values together to produce another.
"5 + 10" is an `expression`, it evaluates to a value, 15.
Finally the whole line is a statement. It is invoking C#'s ability to evaluate an expression and print the result to the console.

Ok, sorry, that was a lot of terminology at once. Let's look at some more examples.

### Arithmetic Operators

```c#
Console.WriteLine(10 + 5); // prints 15
Console.WriteLine(10 - 5); // prints  5
Console.WriteLine(10 * 5); // prints 50
Console.WriteLine(10 / 5); // prints  2
```

These should all be pretty much as expected. You can also use values from variables like so.

```c#
int a = 5;
int b = 10;
int c = a + b;

Console.WriteLine(c); // prints 15
```

### Assignment Operator

When we first talked about variables I mentioned declaring and assigning to variables are two separate steps. We can only declare a variable once in a scope (more on scope later) but we can *assign* to it as many times as we like.

```c#
int a = 5;
int b = 10;
b = 20;
int c = a + b;

Console.WriteLine(c); // prints 25
```

In math when you say something like `x = 10` that means x always and forever equals ten. That variable is immutable. There are programming languages like that but in C# and most mainstream languages you can change the contents of variables whenever you like. 

Basically a variable is like a bucket with a name painted on it. When you declare a variable you ask for a bucket and paint its name on. When you assign to a bucket you put something in it. When you use the value in the variable you're peeking in the bucket but not changing it. And when you assign to a variable when there is already a value inside? You replace that value, you dump out the bucket and put something new in it.

That equals sign is an operator, the assignment operator. It performs variable assignment, taking whatever value is on its right and storing it in the variable to its left.

Alright hotshot, what do you think this will print?

```c#
int a = 5;
int b = 10;
int c = a + b;
b = 20;

Console.WriteLine(c); // prints ?
```

You would be forgiven for saying the answer is 25. Again in math if you say `c = a + b` that's always true. However, in C# what happens is more like this:

- declare a variable `a` and set it to 5
- declare a variable `b` and set it to 10
- declare a variable `c`
- read the value of `a` and add it to `b`.
- store that value (15) in `c`
- change the value of `b` to 20 (this has no effect).
- print the contents of `c`: 15

So it's not that `c` always and forever equals `a + b`, we are performing a procedure where the value of `a` and `b` are looked up, added together, and stored in `c`. `c` doesn't know or care where it got its value from.

What do you think this will print?

```c#
int a = 5;
a = a + 1;

Console.WriteLine(a); // prints ?
```

Again, in math something like `a = a + 1` would be nonsense. But in this case we just look up the value of `a` (5), add 1 to it, and store the result in `a`. So it prints 6.

It turns out that incrementing the value of a variable is common enough there is a special operator for it, `+=`.

```c#
int a = 5;
a = a + 1;
a += 1;

Console.WriteLine(a); // prints 7
```

In fact it turns out incrementing a variable by 1 is so common there is an operator for *that*:

```c#
int a = 5;
a = a + 1;
a += 1;
a++;

Console.WriteLine(a); // prints 7
```

So in C# and most other languages `++` means increment a variable by 1. That's why C++ is called that. 

Because `+=` and `++` can be a little confusing for first timers I'll write it longhand for a little longer. You'll get comfortable with it soon.

### Conditional Operators

Suppose I have two variables and I want to know if they are equal. How do I do that? Well, as you might have guessed there is an operator that does just that. Because one equals sign `=` is taken by the assignment operator, the equality operator uses two `==`.

```c#
int a = 5;
int b = 5;
int c = 10;

Console.WriteLine(a == b); // prints true
Console.WriteLine(a == c); // prints false
Console.WriteLine(a + b == c); // prints true
```

Up until now the operators we've been using have evaluated to the same data type that went in. These conditional operators take two values (integers in our case) and evaluate to a bool, true or false.

```c#
int a = 5;
int b = 5;
int c = 10;

Console.WriteLine(a < b); // less than, a is not less than b (they are equal), prints false
Console.WriteLine(a < c); // prints true, a is less than c
Console.WriteLine(c > b); // prints true, c is greater than b
Console.WriteLine(a <= b); // less than or equal to, prints true
Console.WriteLine(a <= c); // less than or equal to, prints true
Console.WriteLine(a != c); // not equal to, prints true
Console.WriteLine(a != b); // not equal to, prints false (they are equal)
```

Some of those operators, like `<=`, are special. They check if one of two conditionals is true, less than *or* equal. If either of those conditions are true the whole expression is true. More on that concept later.

## If Statements

Wouldn't it be great if we could run code conditionally? Like, only run some code if a condition is true, otherwise do something else? Well, I have good news for you. Let's ditch the abstract variable names and look at a more specific example.

```c#
int age = 16;

if(age < 18){
    Console.WriteLine("You are not old enough.");
}
```

If the above code is run, sure enough, it prints "You are not old enough." If we set age to 20 it won't do diddly squat, because we didn't tell it to. Let's handle that case:

```c#
int age = 20;

if(age < 18){
    Console.WriteLine("You are not old enough.");
}
else {
    Console.WriteLine("You are old enough!");
}
// prints "You are old enough!"
```

Super. Now let's make our club harder to get into.

```c#
int age = 20;

if(age < 18){
    Console.WriteLine("You are not old enough.");
}
else if(age < 21){
    Console.WriteLine("You are almost old enough.");
}
else {
    Console.WriteLine("You are old enough!");
}
// prints "You are almost old enough."
```

Given successive if, else if, and else blocks you can ensure that one and exactly one block of code is run.

## Loops

(sorry Corwyn this is where I ran out of steam with the notes)

### While Loop

```c#
int idx = 3;

while(idx > 0){
    Console.WriteLine(idx);
    idx = idx - 1;
}
// prints 0, 1, 2
```

### For Loop

```c#
for(int idx = 0; idx < 3; idx++){
    Console.WriteLine(idx);
}
// also prints 0, 1, 2
```

## Arrays

```c#
int[] numbers = {5, 3, 9, 20, 4, 13};

Console.WriteLine(numbers[0]); // prints 5
Console.WriteLine(numbers[1]); // prints 3
Console.WriteLine(numbers[2]); // prints 9
Console.WriteLine(numbers[3]); // prints 20
Console.WriteLine(numbers[4]); // prints 4
Console.WriteLine(numbers[5]); // prints 13

Console.WriteLine(numbers.Length); // prints 6
```

```c#
int[] numbers = {5, 3, 9, 20, 4, 13};
for (int idx = 0; idx < numbers.Length; idx++)
{
    Console.WriteLine(numbers[idx]);
}
// prints 5, 3, 9, 20, 4, 13
```