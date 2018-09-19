using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace DaVE
{
    class LevelManager
    {
        static List<Level> Levels = new List<Level>();
//        private static bool isChanging;
        private int ActiveLevel;
        public static Level currentLevel;

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

        public static void Draw(SpriteBatch spriteBatch)
        {
            currentLevel.Draw(spriteBatch);
        }

    }
}
