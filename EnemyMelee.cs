namespace Assignment03_Maayan_Menashe;

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
        enemyType = "Melee";
        attackType = "Sword";
    }

    #endregion

    #region Functions
    


    #endregion
}