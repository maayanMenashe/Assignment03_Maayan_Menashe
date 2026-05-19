namespace Assignment2_Maayan_Menashe;

// Class for a bomber type enemy. is an enemy.
public class EnemyBomber : Enemy
{
    #region Variables

    // private variables
    private int bomberDamage = 50;
    private int bomberAcc = 100;

    #endregion

    #region Constructor

    // The constructor. initializes damage and accuracy to be the apropriate number for that type of enemy
    public EnemyBomber()
    {
        damage = bomberDamage;
        accuracy = bomberAcc;
    }

    #endregion

    #region Functions
    
    // Public
    
    // Attacks, "plays animation" (implemented as printing on console) of the apropriate enemy type, and updates player HP if hits.
    public override void Attack(ref Player player)
    {
        // Attack anim
        Console.WriteLine("Bomber enemy screams 'EXUPULOSION!!!!!!!!!!!!!!'");
        // Check if hit
        if (CheckRng(accuracy))
        {
            // hit anim and update player hp if hit
            Console.WriteLine("BOOMMMMMMMM!");
            player.Hp -= damage;
            Console.WriteLine($"Player now has {player.Hp} HP!");
        }
        else
        {
            // apropriate dodge anim if miss
            Console.WriteLine("But the player was literally in a different place then where he was looking...");
        }
    }

    #endregion
}