namespace Assignment03_Maayan_Menashe;

// player is a character class
public class Player : Character
{
    #region Delegates

    public delegate void HealthChangeHandler(float newAmount, string reason); // Handles player health change
    public delegate void DeathHandler(); // Handles player death

    #endregion
    
    #region Events

    public event HealthChangeHandler HpChanged; // Event for HP change on player
    public event DeathHandler Died; // Event for death on player

    #endregion
    
    #region Variables and properties
    
    // Variables without properties
    private float defaultMaxHp = 100;

    // Properties without variables
    public float MaxHp { get; init; } // Can't change after initialization
    public bool IsDead { get; private set; } // Can only change from inside
    
    // Variables with properties
    private float currentHp;
    public float CurrentHp
    {
        // Accessable publicly
        get
        {
            return currentHp;
        }
        
        // Can only change from inside
        // Is always between 0 and the max
        // Marks player as dead when reaches 0 (or lower)
        private set
        {
            currentHp = Math.Clamp(value, 0, MaxHp);
            if (currentHp == 0)
            {
                IsDead = true;
            }
        } 
    }
    
    
    #endregion

    #region Constructors

    // Constructor with the default max hp
    public Player()
    {
        MaxHp = defaultMaxHp;
        CurrentHp = defaultMaxHp;
    }
    
    // Constructor with costume max hp
    public Player(int maxHp)
    {
        MaxHp = maxHp;
        CurrentHp = maxHp;
    }
    


    #endregion

    #region Functions

    // Damages the player by given amount
    public void TakeDamage(float amount)
    {
        // Does nothing if the player is dead
        if (!IsDead)
        {
            CurrentHp -= amount; // Lowers hp by given amount
            HpChanged.Invoke(CurrentHp, "hit"); // Invokes all the subscribed methods
            
            // If the player died after the health change, invokes all the subscribed methods to "died" event
            if (CurrentHp == 0)
            {
                Died.Invoke();
            }
        }
    }
    
    // Heals the player by given amount
    public void Heal(float amount)
    {
        // Does nothing if the player is dead
        if (!IsDead)
        {
            CurrentHp += amount; // Adds the given amount to current hp
            HpChanged.Invoke(CurrentHp, "heal"); // Invokes all the subscribed methods
        }
    }

    #endregion

}