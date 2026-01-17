internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice game sim. ");
        Console.Write("How many dice rolls do you want to simulate? ");

        //parse the readline from a string into an int
        int numRolls = int.Parse(Console.ReadLine());

        //create the instance of the second class 
        diceSimulator ds = new diceSimulator();

        //pass the number to the method and get the array back 
        int[] rollResults = ds.simulateRolls(numRolls);

        //use the array to make the 2-12 chart histogram
        printHistogram(rollResults, numRolls);
    }
    
    private static void printHistogram(int[] results, int totalRolls)
    {
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + totalRolls + ".\n");

        for (int i = 2; i <= 12; i++)
        {
            // Calculate percentage
            int pct = (int)Math.Round(((double)results[i] / totalRolls) * 100);

            // Build the star string
            string stars = new string('*', pct);

            // Output the row
            Console.WriteLine($"{i}: {stars}");
        }
        
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}