using System.Diagnostics.CodeAnalysis;

public class Counter
{
    public void Run()
    {
        for(int i = 0; i < 100000; i++)
        {
            Console.WriteLine(i+1);
        }
    }
}