using System;

namespace EepilineKaklus
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = PickHero();
            string villain = PickVillain();
            Console.WriteLine($"{hero} will fight {villain}!");

            string heroweapon = PickWeapon();
            string villainweapon = PickWeapon();
            Console.WriteLine($"{hero} has picked {heroweapon} and {villain} has picked {villainweapon}!");
        }




        private static string PickWeapon()
        {
            string[] weapons = { "AK47", "RPG", "Bible", "Undone homework", "broken glass bottle", "banana peel" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, weapons.Length);
            return weapons[randomIndex];
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
            string[] superVillains = { "Osama Bin Laden", "Adolf", "Trump", "my drunk grandpa", "عبد الغني" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, superVillains.Length);
            return superVillains[randomIndex];
        }


    }
}
