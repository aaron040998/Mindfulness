public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", 
        "This activity will help you relax by guiding you through breathing exercises.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountDown(4);
            
            Console.Write("\nBreathe out... ");
            ShowCountDown(6);
        }
        
        DisplayEndingMessage();
    }
}