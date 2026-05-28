namespace Assignment03_Maayan_Menashe;

// player is a character class
public class Player : Character
{
    #region Delegates

    public delegate void HealthChangeHandler(float newAmount, string reason);
    public delegate void DeathHandler();

    #endregion
    
    #region Properties
    public float CurrentHp { get; private set; }
    
    public float MaxHp { get; init; }
    
    public bool IsDead { get; private set; }

    #endregion

    #region Constructor

    public Player(int maxHp)
    {
        MaxHp = maxHp;
        CurrentHp = maxHp;
    }

    #endregion

    #region Functions

    public void TakeDamage(float amount)
    {
        CurrentHp -= amount;
        if (CurrentHp < 0)
        {
            CurrentHp = 0;
        }
    }
    
    public void Heal(float amount)
    {
        CurrentHp += amount;
        if (CurrentHp > MaxHp)
        {
            CurrentHp = MaxHp;
        }
    }

    #endregion

    #region Events

    public event HealthChangeHandler OnHealthChanged;
    public event DeathHandler OnPlayerDied;

    #endregion
}