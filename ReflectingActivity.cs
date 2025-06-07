public class ReflectingActivity : Activity
{
    private List<string> _prompts = new()
    {
        "Think of a time you stood up for someone",
        "Think of a time you did something difficult",
        "Think of a time you helped someone in need",
        "Think of a time you did something truly selfless"
    };

    private List<string> _questions = new()
    {
        "Why was this experience meaningful?",
        "What did you learn about yourself?",
        "How can you apply this in other situations?",
        "What made this different from other experiences?",
        "What emotions did you feel during this experience?",
        "What challenges did you face and how did you overcome them?",
        "How did this experience shape your perspective?",
        "What strengths did you discover in yourself?",
        "What would you do differently next time?",
        "Who was affected by your actions and how?",
        "What motivated you to act the way you did?",
        "How has this experience helped you grow?",
        "What values were reflected in your response?",
        "How did your decisions align with your personal goals?",
        "Did this experience change how you see yourself?",
        "What lessons will you carry forward from this moment?",
        "How did this experience connect with your past?",
        "What made this different from other experiences?"
    };

    public ReflectingActivity() : base("Reflecting", 
        "This activity will help you reflect on meaningful life experiences.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
        Console.WriteLine("\nPress enter when ready...");
        Console.ReadLine();
        
        Console.WriteLine("\nReflect on these questions:");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write($"\n> {GetRandomQuestion()} ");
            ShowSpinner(5);
        }
        
        DisplayEndingMessage();
    }

    private string GetRandomPrompt() => _prompts[new Random().Next(_prompts.Count)];
    private string GetRandomQuestion() => _questions[new Random().Next(_questions.Count)];
}