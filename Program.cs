// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// string aFriend = "Bill";
// Console.WriteLine(aFriend);
// aFriend = "Maria";
// Console.WriteLine(aFriend);

// // STRING INTERPOLATION:
// Console.WriteLine($"Hello {aFriend}");

// string firstFriend = "Maria";
// string secondFriend = "Sage";
// Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");


// // LENGTH

// Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters");
// Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters");


// // TRIM

// string greeting = "     Hello World!     ";
// Console.WriteLine($"[{greeting}]");

// string trimmedGreeting = greeting.TrimStart();
// Console.WriteLine($"[{trimmedGreeting}]");

// trimmedGreeting = greeting.TrimEnd();
// Console.WriteLine($"[{trimmedGreeting}]");

// trimmedGreeting = greeting.Trim();
// Console.WriteLine($"[{trimmedGreeting}]");

// // The square brackets [ and ] help visualize what the Trim, TrimStart and TrimEnd methods do. The brackets show where whitespace starts and ends.


// // REPLACE, UPPER AND LOWER

// string sayHello = "Hello World!";
// Console.WriteLine(sayHello);
// sayHello = sayHello.Replace("Hello", "Greetings");
// Console.WriteLine(sayHello);

// Console.WriteLine(sayHello.ToUpper());
// Console.WriteLine(sayHello.ToLower());


// // SEARCH STRINGS, STARTSWITH AND ENDSWITH METHODS

// string songLyrics = "You say goodbye, and I say hello";
// Console.WriteLine(songLyrics.Contains("goodbye")); //true
// Console.WriteLine(songLyrics.Contains("greetings")); //false

// Console.WriteLine(songLyrics.StartsWith("you")); //false (capital letter at the beginning)
// Console.WriteLine(songLyrics.EndsWith("hello")); //true
// Console.WriteLine(songLyrics.EndsWith("goodbye")); //false


// // NUMBERS

// //EXPLORE INTEGERS MATH
// int a = 18;
// int b = 6;
// int c = a + b;
// Console.WriteLine(c);

// // + for subtraction
// // - for subtraction
// // * for multiplication
// // / for division

// // Subtraction:
// c = a - b;
// Console.WriteLine(c);

// // Multiplication:
// c = a * b;
// Console.WriteLine(c);

// // Division:
// c = a / b;
// Console.WriteLine(c);


// EXPLORE ORDER OF OPERATIONS (BIDMAS)

// int a = 5;
// int b = 4;
// int c = 2;
// int d = a + b * c;
// Console.WriteLine(d); // 13

// int a = 5;
// int b = 4;
// int c = 2;
// int d = (a + b) * c;
// Console.WriteLine(d); // 18

// int e = (a + b) - 6 * c + (12 * 4) / 3 + 12;
// Console.WriteLine(e);

/*
You may have noticed an interesting behavior for integers. Integer division always produces an integer result, even when you'd expect the result to include a decimal or fractional portion.

If you haven't seen this behavior, try the following code:
*/

// int a = 7;
// int b = 4;
// int c = 3;
// int d = (a + b) / c;
// Console.WriteLine(d);


// EXPLORE INTEGER PRECISION AND LIMITS

/*
You can get the remainder by using the remainder operator, the % character:
*/

// int a = 7;
// int b = 4;
// int c = 3;
// int d = (a + b) / c;
// int e = (a + b) % c;
// Console.WriteLine($"quotient: {d}");
// Console.WriteLine($"remainder: {e}");

/*
The C# integer type differs from mathematical integers in one other way: the int type has minimum and maximum limits. Run this code in the interactive window to see those limits:
*/

// int max = int.MaxValue;
// int min = int.MinValue;
// Console.WriteLine($"The range of integers is {min} to {max}");

/*
UNDERFLOW OR OVERFLOW

If a calculation produces a value that exceeds those limits, you have an underflow or overflow condition. The answer appears to wrap from one limit to the other. Add these two lines to the interactive window to see an example:
*/

// int what = max + 3;
// Console.WriteLine($"An example of overflow: {what}");

/*Notice that the answer is very close to the minimum (negative) integer. It's the same as min + 2. The addition operation overflowed the allowed values for integers. The answer is a very large negative number because an overflow "wraps around" from the largest possible integer value to the smallest.*/

//WORK WITH THE DOUBLE TYPE (includes decimals to the results)

double a = 19;
double b = 23;
double c = 8;
double d = (a + b) / c;
Console.WriteLine(d);

double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}"); // These values are printed out in scientific notation. The number to the left of the E is the significand. The number to the right is the exponent, as a power of 10.

/* 
Just like decimal numbers in math, doubles in C# can have rounding errors. Try this code:
*/

double third = 1.0 / 3.0;
Console.WriteLine(third); //You know that 0.3 is 3/10 and not exactly the same as 1/3. Similarly, 0.33 is 33/100. That's closer to 1/3, but still not exact.