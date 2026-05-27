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
        enemyType = "Ranger";
        attackType = "Bow";
    }

    #endregion

    #region Functions
    


    #endregion
}