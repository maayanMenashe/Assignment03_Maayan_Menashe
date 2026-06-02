namespace Assignment03_Maayan_Menashe;

// Base class for all enemy characters. is a character. abstract.
public abstract class Enemy : Character
{
    #region Variables

    // Protected variables
    protected int damage;
    protected int accuracy;
    protected string enemyType;
    protected string attackType;

    #endregion

    #region Functions
    
    // Makes the player take the amount of damage that is passed down
    public void Attack(Player player, float damageAmount)
    { 
        player.TakeDamage(damageAmount);
    }
    
    // Makes the player take the amount of damage that that enemy deals
    public void Attack(Player player)
    {
        Attack(player, damage);
    }

    // Plays victory animation of this enemy
    public void PlayVictoryAnim()
    {
        Console.WriteLine($"{enemyType} enemy plays a victory animation!");
    }

    // Everything that the enemy does when the player dies (just plays victory anim)
    public void OnPlayerDeath()
    {
        PlayVictoryAnim();
    }
    
    #endregion
}