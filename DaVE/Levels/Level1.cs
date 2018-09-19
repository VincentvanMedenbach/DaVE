using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace DaVE.Levels
{
    class Level1 : Level
    {
        public Level1()
        {
            this.background = Art.BackgroundLevel1;
            this.number = 1;
            this.name = "harry";
            Game1.currentLevel = name;
            LevelManager.currentLevel = this;
        }
    }
}
