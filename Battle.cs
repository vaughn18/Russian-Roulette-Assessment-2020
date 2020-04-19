using System;

namespace RussianRouletteAssessment2020
{
    public class Battle
    {
        Random ran = new Random();

        //Defining the amount of Weapons the user has
        public static int[] userWeapons;

        //Define if one round of the fight has started or not
        public static bool roundStart = false;

        public string Attack(string weaponNumber)
        {
            int newWpnNo = Int32.Parse(weaponNumber);

            //Checks if you used the winning weapon or if you won or not
            if (userWeapons[newWpnNo] == 1)
            {
                Console.WriteLine("Enemy Killed");
                return "You have enliminated your enemy";
            }
            else
            {
                Console.WriteLine("Enemy survived");
                return "Your attack failed";
            }
        }

        public void Prepare()
        {
            //Prepares a new set of Weapons
            userWeapons = new int[6] { 0, 0, 0, 0, 0, 0 };

            //Define the winning weapon
            int winningWeapon = ran.Next(0, 6);

            //This is variable is used during unit testing instead of the other
            //int winningWeapon = 3;

            //shows the winning weapon for backend purposes
            Console.WriteLine("This is the winning weapon" + winningWeapon);

            //Place the winning weapon in one of the weapons
            userWeapons[winningWeapon] = 1;
        }

        public string Score(string message, string currentScr)
        {
            //Checks and calculates the scores
            int newCurrentScr = Int16.Parse(currentScr);

            if (message == "You have enliminated your enemy")
            {
                newCurrentScr++;
                return newCurrentScr.ToString();
            }
            else if (message == "Your attack failed")
            {
                newCurrentScr--;
                return newCurrentScr.ToString();
            }
            else
            {
                return null;
            }
        }

        public string HighScore(string currentScr, string highscore)
        {
            int newHighScore = Int16.Parse(highscore);
            int intCrntScr = Int16.Parse(currentScr);

            //Checks if score is higher than highscore
            if (intCrntScr > newHighScore)
            {
                //if score is higher then replace highscore
                newHighScore = intCrntScr;
                return newHighScore.ToString();
            }
            else
            {
                //otherwise return the default current highscore
                return newHighScore.ToString();
            }


        }

        public string Enemy()
        {
            int enemyNo = ran.Next(0, 4);

            //return randomly generated enemies
            if (enemyNo == 0)
            {
                return "Troll";
            }
            else if (enemyNo == 1)
            {
                return "Wraith";
            }
            else if (enemyNo == 2)
            {
                return "Undead";
            }
            else if (enemyNo == 3)
            {
                return "Dwarf";
            }
            else if (enemyNo == 4)
            {
                return "Devil";
            }
            else
            {
                return null;
            }
        }
    }
}
