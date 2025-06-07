using System.IO;

class Program
{
    private static int breathingCount = 0;
    private static int reflectingCount = 0;
    private static int listingCount = 0;

    static void Main()
    {
        /*
         * EXCEEDING REQUIREMENTS:
         * Implemented session logging system that:
         * - Records each activity with timestamp and duration
         * - Saves data to mindfulness_log.txt
         * - Shows session summary upon exit
         * - Maintains full history between program executions
         */

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activities:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an activity: ");

            switch (Console.ReadLine())
            {
                case "1":
                    new BreathingActivity().Run();
                    breathingCount++;
                    break;
                case "2":
                    new ReflectingActivity().Run();
                    reflectingCount++;
                    break;
                case "3":
                    new ListingActivity().Run();
                    listingCount++;
                    break;
                case "4":
                    Console.WriteLine("\nSession Summary:");
                    Console.WriteLine($"- Breathing Activities: {breathingCount}");
                    Console.WriteLine($"- Reflection Activities: {reflectingCount}");
                    Console.WriteLine($"- Listing Activities: {listingCount}");

                    Console.WriteLine("\nThank you for practicing mindfulness!");
                    
                    // Mostrar ubicación del log
                    string logPath = Path.GetFullPath("mindfulness_log.txt");
                    Console.WriteLine($"\nSession saved to: {logPath}");
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    Thread.Sleep(1500);
                    break;
            }
        }
    }
}