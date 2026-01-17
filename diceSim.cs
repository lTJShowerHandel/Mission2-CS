public class diceSimulator
{
    public int[] simulateRolls(int rolls)
    {
        //make an array with 13 slots aka 0-12
        int[] results = new int[13]; 
        //create the random number
        Random rnd = new Random();
        
        //make a for loop to go through the array a given amount of times 
        for (int iCount = 0; iCount < rolls; iCount++)
        {
            int die1 = rnd.Next(1,7);
            int die2 = rnd.Next(1,7);
            int sum = die1 + die2;
            
            results[sum]++;
        }
        return results;
    }
}