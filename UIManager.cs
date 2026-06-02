namespace Assignment03_Maayan_Menashe;

public class UIManager
{
    #region Event methods

    // What the UI does when a player's health changes
    public void OnPlayerHealthChanged(float newHealth, string reason)
    {
        // Switch case so that it is more scalable
        // Writes different text dependin on the reason of the health change
        switch (reason)
        {
            case "hit":
                Console.WriteLine($"The player was hit! They are now at {newHealth} Hp...");
                break;
            
            case "heal":
                Console.WriteLine($"The player healed to {newHealth} Hp!");
                break;
            
            default:
                Console.WriteLine($"The player now has {newHealth} Hp.");
                break;
        }
    }
    
    #endregion
 
}