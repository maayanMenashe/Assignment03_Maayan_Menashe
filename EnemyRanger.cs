namespace Assignment2_Maayan_Menashe;

// Class for a ranger type enemy. is an enemy.
public class EnemyRanger : Enemy
{
    #region Variables

    // private variables
    private int rangerDamage = 5;
    private int rangerAcc = 50;

    #endregion

    #region Constructor

    // The constructor. initializes damage and accuracy to be the apropriate number for that type of enemy
    public EnemyRanger()
    {
        damage = rangerDamage;
        accuracy = rangerAcc;
    }

    #endregion

    #region Functions
    
    // Public
    
    // Attacks, "plays animation" (implemented as printing on console) of the apropriate enemy type, and updates player HP if hits.
    public override void Attack(ref Player player)
    {
        // Attack anim
        Console.WriteLine("Ranger enemy did an awsome shooting animation with lots of fire and shi...");
        // Check if hit
        if (CheckRng(accuracy))
        {
            // hit anim and update player hp if hit
            Console.WriteLine("And hit!");
            player.Hp -= damage;
            Console.WriteLine($"Player now has {player.Hp} HP!");
        }
        else
        {
            // apropriate dodge anim if miss
            Console.WriteLine("But the player did a slow mo neo from the matrix like animation!!");
        }
    }

    #endregion
}