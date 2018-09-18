using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaVE
{
    class LevelManager
    {
        static List<Level> Levels = new List<Level>();
//        private static bool isChanging;
        private int ActiveLevel;

        LevelManager(int number)
        {
            this.ActiveLevel = number;

        }

        public static int Count
        {
            get { return Levels.Count; }
        }

        public static void LoadLevel(int levelNumber)
        {
            if (levelNumber == 0)
            {

            }
        }
    }
}
