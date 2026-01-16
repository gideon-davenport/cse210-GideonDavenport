using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
    Console.Write("What is your grade percentage? ");
    string grade = Console.ReadLine();
    int number = int.Parse(grade); 

    if (number > 90)
{
    Console.WriteLine("You got an 'A' congrats!");
    string letter = "A";
    Console.Write($"Your grade is: '{letter}'");
}
else if (number > 80)
{
    Console.WriteLine("You got a 'B' ");
    string letter = "B";
    Console.Write($"Your grade is: '{letter}'");
}
else if (number > 70)
{
    Console.WriteLine("You got a 'C' ");
    string letter = "C";
    Console.Write($"Your grade is: '{letter}'");
}
else if (number > 60)
{
    Console.WriteLine("You got a 'D' ");
    string letter = "C";
    Console.Write($"Your grade is: '{letter}'");
}
else
{
    Console.WriteLine("You got an 'F' you failed.");
    string letter = "F";
    Console.Write($"Your grade is: '{letter}'");
}
if (number > 70)
        {
            Console.WriteLine("Congratulations, you passed the class! ");
        }
else
        {
            Console.WriteLine("You did not score high enough to pass the class. Better luck next time. ");
        }
    }
}