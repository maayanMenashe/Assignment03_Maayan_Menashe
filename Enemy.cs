namespace Assignment2_Maayan_Menashe;

// Base class for all enemy characters. is a character. abstract.
public abstract class Enemy : Character
{
    #region Variables

    // Protected variables
    protected int damage;
    protected int accuracy;

    #endregion

    #region Functions

    // abstract functions
    public abstract void Attack(ref int playerHp);
    
    #endregion

    #region Constructor

    // Base parameterless constructor
    protected Enemy()
    {
    }
    
    #endregion

    

}