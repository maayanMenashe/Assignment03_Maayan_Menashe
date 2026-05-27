namespace Assignment2_Maayan_Menashe;

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

    public void Attack(Player player)
    {
        // Attack anim
        Console.WriteLine($"{enemyType} enemy attacks the player with a {attackType} attack!");
        // Check if hit
        if (Utils.CheckRng(accuracy))
        {
            // hit anim and update player hp if hit
            Console.WriteLine("And hits...");
            player.TakeDamage(damage);
            Console.WriteLine($"Player now has {player.CurrentHp} HP!");
        }
        else
        {
            // apropriate dodge anim if miss
            Console.WriteLine($"The player avoided the {attackType} attack!");
        }
    }
    
    #endregion

    #region Constructor

    // Base parameterless constructor
    protected Enemy()
    {
    }
    
    #endregion
}