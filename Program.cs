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


// SEARCH STRINGS, STARTSWITH AND ENDSWITH METHODS

string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye")); //true
Console.WriteLine(songLyrics.Contains("greetings")); //false

Console.WriteLine(songLyrics.StartsWith("you")); //false (capital letter at the beginning)
Console.WriteLine(songLyrics.EndsWith("hello")); //true
Console.WriteLine(songLyrics.EndsWith("goodbye")); //false
