using System.Net;

int number = 11;

if (number == 0)
{
    Console.WriteLine("Your number is 0");
}

else if (number > 10 || number < -10)
{
    Console.WriteLine($"Your number ({number}) has multiple digets.");
}
else
{
    Console.WriteLine("Single digit.");
}

string response;
do 
{
    Console.Write("Do you want to continue? ");
    response = Console.ReadLine();
}
while (response == "yes");
Console.WriteLine("Done! ");



List<string> words = new List<string>();
words.Add("Snow");
words.Add("Cold");
words.Add("Wet");
words.Add("White");

foreach (string word in words)
{
    Console.WriteLine(word);
}

for(int i = 100000; i > 0;)
{
    Console.WriteLine(i);
    i--;
}

void DisplayMessage()
{
    Console.WriteLine("Hello World");
}
DisplayMessage();