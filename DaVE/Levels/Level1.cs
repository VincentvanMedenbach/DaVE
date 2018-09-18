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
        public Level1(Texture2D image)
        {
            this.background = image;
            this.number = 1;
            this.name = "harry"; 

            
        } 
    }
}
