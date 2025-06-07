// Facilitates a listing exercise to highlight positives in life
public class ListingActivity : Activity
{
    private int _count;                        // tracks number of entries
    private List<string> _prompts = new()      // possible listing prompts
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
        DisplayStartingMessage();              // prompt user and set duration
        
        Console.WriteLine("\nList as many as you can of:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---"); // show random topic
        Console.Write("\nStarting in ");
        ShowCountDown(5);                      // brief countdown
        
        Console.WriteLine("\n");
        List<string> items = GetListFromUser();
        _count = items.Count;                  // count entries
        
        Console.WriteLine($"\nYou listed {_count} items!");
        DisplayEndingMessage();                // conclude and log
    }

    private string GetRandomPrompt() => _prompts[new Random().Next(_prompts.Count)]; // pick prompt

    private List<string> GetListFromUser()
    {
        List<string> items = new();           // store user inputs
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string? input = Console.ReadLine();
            
            if (!string.IsNullOrWhiteSpace(input))
                items.Add(input);              // record non-empty response
        }
        
        return items;
    }
}
