using System;

namespace EepilineKaklus
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = PickHero();
            string villain = PickVillain();
            string heroweapon = PickWeapon();
            string villainweapon = PickWeapon();
            int heroHP = GenerateHP(hero);
            int villainHP = GenerateHP(villain);



            Console.WriteLine($"{hero} will fight {villain}!");
            Console.WriteLine($"{hero} has picked {heroweapon} and {villain} has picked {villainweapon}!");

            while (heroHP > 0 && villainHP > 0)
            {
                heroHP = heroHP - HIT(villain, hero, villainweapon);
                villainHP = villainHP - HIT(hero, villain, heroweapon);
            }

            if (heroHP <= 0)
            {
                Console.WriteLine($"{villain} wins!");
            }
            else
            {
                Console.WriteLine($"{hero} saves the day from {villain}!");
            }

        }

        private static int HIT(string CharacterOne, string CharacterTwo, string SomeWeapon)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, SomeWeapon.Length/2);

            Console.WriteLine($"{CharacterOne} hit {strike}.");
            if (strike == SomeWeapon.Length / 2)

            {
                Console.WriteLine($"CRIT! {CharacterOne} has landed a critical hit to the opponent!");
            } 
            else if (strike == 0)
            {
                Console.WriteLine($"{CharacterTwo} hit a matrix and dodged the attack!");
            }

            return strike;

        }







        private static string PickWeapon()
        {
            string[] weapons = { "AK47", "RPG", "Bible", "Used Condom", "Undone homework", "broken glass bottle", "banana peel" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, weapons.Length);
            return weapons[randomIndex];
        }


        private static int GenerateHP(string SomeName)
        {
            Random rnd = new Random();
            return rnd.Next(2, SomeName.Length);



        }



        private static string PickHero()
        {
            string[] superHeroes = { "Albert Ainstein", "Shrek", "Obama", "Jesus", "Local Crack Dealer" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, superHeroes.Length);
            return superHeroes[randomIndex];
        }


        private static string PickVillain()
        {
            string[] superVillains = { "Osama Bin Laden", "Adolf", "Trump", "my drunk grandpa", "ahmed" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, superVillains.Length);
            return superVillains[randomIndex];
        }


    }
}
