// Sample for the Environment.GetEnvironmentVariables method 
using System;
using System.Collections;

class Sample
{
    public static void Main()
    {
        Console.WriteLine();
        Console.WriteLine("GetEnvironmentVariables: ");
        foreach (DictionaryEntry de in Environment.GetEnvironmentVariables())
            Console.WriteLine("  {0} = {1}", de.Key, de.Value);
        Console.Read();
    }
}
