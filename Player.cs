namespace Assignment2_Maayan_Menashe;

// player is a character class
public class Player : Character
{
    #region Variables
    public float CurrentHp { get; private set; }
    public float MaxHp { get; init; }

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
}