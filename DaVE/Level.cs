using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DaVE
{
    abstract class Level
    {
        public  int number;
        public string name;

       

        public Texture2D background;

        public virtual void Draw(SpriteBatch spriteBatch)
        
        {
//            spriteBatch.Begin(SpriteSortMode.Texture, BlendState.Additive);
            spriteBatch.Draw(background, new Rectangle(0, 0, 800, 480), Color.White);
//            spriteBatch.End();
        }
    }
}
