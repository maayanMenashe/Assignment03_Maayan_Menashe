// See https://aka.ms/new-console-template for more information

using Assignment2_Maayan_Menashe;

Player player = new Player();
Enemy melee = new EnemyMelee();
Enemy ranger = new EnemyRanger();
Enemy bomber = new EnemyBomber();

melee.Attack(ref player.Hp);
ranger.Attack(ref player.Hp);
bomber.Attack(ref player.Hp);







// check all topics and make sure i used all of them and the right ones (interface, abstract, ovberride)
// do group attack
// getter and setters and maybe death for player
// Update ULM