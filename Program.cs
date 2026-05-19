// See https://aka.ms/new-console-template for more information

using Assignment2_Maayan_Menashe;

Player player = new Player();
Enemy melee = new EnemyMelee();
Enemy ranger = new EnemyRanger();
Enemy bomber = new EnemyBomber();

melee.Attack(ref player);
ranger.Attack(ref player);
bomber.Attack(ref player);