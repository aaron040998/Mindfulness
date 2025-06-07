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
            int remainingSeconds = (int)(endTime - DateTime.Now).TotalSeconds;
            int breathIn = Math.Min(4, remainingSeconds);
            
            if (breathIn > 0)
            {
                Console.Write("\nBreathe in... ");
                ShowCountDown(breathIn);
            }
            
            remainingSeconds = (int)(endTime - DateTime.Now).TotalSeconds;
            int breathOut = Math.Min(6, remainingSeconds);
            
            if(breathOut > 0) {
                Console.Write("\nBreathe out... ");
                ShowCountDown(breathOut);
            }
        }
        
        DisplayEndingMessage();
    }
}