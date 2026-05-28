// See https://aka.ms/new-console-template for more information

using Assignment03_Maayan_Menashe;

Player player = new Player(10);

Enemy[] allEnemies = [new EnemyMelee(), new EnemyRanger(), new EnemyBomber()];

foreach (var enemy in allEnemies)
{
    enemy.Attack(player);
}





// about the events.... what he called events in the assignment sound like methods
// check about delegate being public and inside
// dont forget to use delegate for the health funcs
// also use lambda and anonymos funcs
// add comments
// change dlm