namespace Assignment2_Maayan_Menashe;

public class Utils
{
    #region RNG checker

    private static Random random = new Random();

    
    // a function that gets a number and checks randomly if it hit the odds or didnt
    public static bool CheckRng(int odds)
    {
        // generate a random number between 1 and 100
        int randomNum = random.Next(1, 101);
        
        // checks if odds are hit, returns true if they did and false if didnt
        if (odds >= randomNum)
        {
            return true;
        }
        return false;
    }

    #endregion
}