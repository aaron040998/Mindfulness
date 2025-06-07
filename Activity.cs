// Implements a guided activity session with timing and logging
// Handles user prompts, simple animations, and record-keeping

using System.IO;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine($"\n{_description}");

        // ask user for session length
        while (true)
        {
            Console.Write("\nHow long (in seconds) would you like your session? ");
            string? input = Console.ReadLine();

            if (input == null)
            {
                _duration = 30; // default when canceled
                break;
            }

            if (int.TryParse(input, out int duration) && duration > 0)
            {
                _duration = duration;
                break;
            }
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }

        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"\nYou've completed {_duration} seconds of {_name}.");
        ShowSpinner(3);

        // record session
        SaveToLog();
    }

    protected void SaveToLog()
    {
        var entry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {_name} ({_duration}s)";
        try
        {
            File.AppendAllText("mindfulness_log.txt", entry + Environment.NewLine);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Log error: {ex.Message}");
        }
    }

    public void ShowSpinner(int seconds)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        for (int i = 0; i < seconds * 2; i++)
        {
            Console.Write(spinner[i % 4]);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
