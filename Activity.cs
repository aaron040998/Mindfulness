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
        
        // Validación robusta de duración
        while (true)
        {
            Console.Write("\nHow long (in seconds) would you like your session? ");
            string? input = Console.ReadLine();  // Usa tipo nullable
            
            // Manejo explícito de posible valor nulo
            if (input == null)
            {
                Console.WriteLine("Input canceled. Using default duration: 30 seconds");
                _duration = 30;
                break;
            }
            
            if (int.TryParse(input, out int duration) && duration > 0)
            {
                _duration = duration;
                break;
            }
            // Mensaje de error para entrada inválida
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
        
        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(2);
        Console.WriteLine($"\nYou've completed {_duration} seconds of the {_name} Activity");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        for (int i = 0; i < seconds * 2; i++)
        {
            Console.Write(spinner[i % 4]);  // Corrección aquí
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