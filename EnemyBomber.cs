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
        enemyType = "Bomber";
        attackType = "Bomb";
    }

    #endregion

    #region Functions
    
    

    #endregion
}