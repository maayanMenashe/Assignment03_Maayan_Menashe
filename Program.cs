// See https://aka.ms/new-console-template for more information

using Assignment03_Maayan_Menashe;

Player player = new Player(); // instance of a player

Enemy[] allEnemies = [new EnemyMelee(), new EnemyRanger(), new EnemyBomber()]; // An array of new enemy instances

// Subscribes all the enemie's on player death functions to the player died event
foreach (var enemy in allEnemies)
{
    player.Died += enemy.OnPlayerDeath;
}

UIManager ui = new UIManager(); // Instance of ui manager

player.HpChanged += ui.OnPlayerHealthChanged; // Subscribes the ui's on player health change method to the player's hp change event


// This is where the battle starts!! \\


// All the enemies attack the player for 30 damage, ui method plays each time. ends on 10 HP
foreach (var enemy in allEnemies)
{
    enemy.Attack(player, 30);
}

player.Heal(10); // Player heals 10 HP, now is on 20
player.Heal(200); // Player heals 200 HP, since this is above the max, he is now on max hp (100)

// All enemies attack the player for 60 Hp
// First attack: leaves the player with 40 HP, ui method is played
// Second attack: Kills the player. Since HP is below 0, HP is 0, and ui method is played, then, all victory animations are played
// Third attack: Does absolutely nothing, since the player is dead.
foreach (var enemy in allEnemies)
{
    enemy.Attack(player, 60);
}

player.Heal(50); // Also does nothing, since the player is dead



// Thanks for watching! don't forget to like, and just like the methods, subscribe! (: