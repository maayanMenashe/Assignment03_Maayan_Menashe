// See https://aka.ms/new-console-template for more information

using Assignment2_Maayan_Menashe;

Player player = new Player(10);

Enemy[] allEnemies = [new EnemyMelee(), new EnemyRanger(), new EnemyBomber()];

foreach (var enemy in allEnemies)
{
    enemy.Attack(player);
}







// dont forget to use delegate for the health funcs
// also use lambda and anonymos funcs
// add comments
// change dlm