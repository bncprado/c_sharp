// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string aFriend = "Bill";
Console.WriteLine(aFriend);
aFriend = "Maria";
Console.WriteLine(aFriend);

// STRING INTERPOLATION:
Console.WriteLine($"Hello {aFriend}");

string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

// LENGTH

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters");