namespace Assignment2_Maayan_Menashe;

// Class for a melee type enemy. is an enemy.
public class EnemyMelee : Enemy
{
    #region Variables

    // private variables
    private int meleeDamage = 20;
    private int meleeAcc = 20;

    #endregion

    #region Constructor

    // The constructor. initializes damage and accuracy to be the apropriate number for that type of enemy
    public EnemyMelee()
    {
        damage = meleeDamage;
        accuracy = meleeAcc;
    }

    #endregion

    #region Functions
    
    // Public
    
    // Attacks, "plays animation" (implemented as printing on console) of the apropriate enemy type, and updates player HP if hits.
    public override void Attack(ref Player player)
    {
        // Attack anim
        Console.WriteLine("Melee enemy did an extrealy cool animation with like a epic effects and stuff...");
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
            Console.WriteLine("But the player did an even cooler dodge animation!");
        }
    }

    #endregion
}