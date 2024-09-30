﻿int points = 0;
Console.WriteLine("This is Deadpool and Wolverine movie quiz");

// -----------------------------------------------------------------------------

Console.WriteLine("1: Around how long is the new deadpool and Wolverine movie?");
Console.WriteLine("a) 1h 50min");
Console.WriteLine("b) 2h 30 min");
Console.WriteLine("c) 2h 10min");
string answer1 = Console.ReadLine();
if (answer1 == "c")
{
  points++;
  Console.WriteLine("correct");
}
else
{
  Console.WriteLine("Incorrect");
}

// -----------------------------------------------------------------------------

Console.WriteLine("2: Who is the geat villian of this story");
Console.WriteLine("a) X-mans Leaders sister who died in the womb");
Console.WriteLine("b) Doctor Strange Adopted brother who died in a car crash");
Console.WriteLine("c) Petter");
string answer2 = Console.ReadLine();
if (answer2 == "a")
{
  points++;
  Console.WriteLine("CORRECT");
}
else
{
  Console.WriteLine("INCORRECT");
}

// -----------------------------------------------------------------------------

Console.WriteLine("3: How does the movie end?");
Console.WriteLine("a) Deadpool and Wolverine part ways");
Console.WriteLine("b) They become pals");
Console.WriteLine("c) They start a new adventure with Dogpool");
string answer3 = Console.ReadLine();
if (answer3 == "a")
{
  points++;
  Console.WriteLine("Correct");
}
else
{
  Console.WriteLine("Incorrect");
}

// -----------------------------------------------------------------------------

Console.WriteLine($"Total points: {points}/3");
if (points == 0)
{
  Console.WriteLine("Go watch the movie first.");
}
else if (points < 3)
{
  Console.WriteLine("Did you dose of at the movie salon.");
}
else 
{
  Console.WriteLine("Good job, you reached the standard.");
}

Console.WriteLine("Press any button to end.");
Console.ReadKey();