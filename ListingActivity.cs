public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new()
    {
        "People who appreciate you",
        "Personal strengths",
        "People you've helped recently",
        "Times you've felt inspired"
    };

    public ListingActivity() : base("Listing", 
        "This activity will help you recognize positive aspects of your life.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        Console.WriteLine("\nList as many as you can of:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("\nStarting in ");
        ShowCountDown(5);
        
        Console.WriteLine("\n");
        List<string> items = GetListFromUser();
        _count = items.Count;
        
        Console.WriteLine($"\nYou listed {_count} items!");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt() => _prompts[new Random().Next(_prompts.Count)];

    private List<string> GetListFromUser()
    {
        List<string> items = new();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string? input = Console.ReadLine();  // Corrección aquí
            
            if (!string.IsNullOrWhiteSpace(input)) 
                items.Add(input);
        }
        
        return items;
    }
}