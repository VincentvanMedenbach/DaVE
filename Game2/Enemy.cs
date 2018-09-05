using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game2
{
    public class Enemy : Player
    {
        public Texture2D Texture;
        public Vector2 Position;
        public Vector2 FrameSize;
        public int score;

        public int speed;
//        public enum direction { left, right, up, down };

        public direction direction;

        public Enemy()
        {
            FrameSize.X = 250;
            FrameSize.Y = 200;
            Position.X = 600;
            Position.Y = 900;
            speed = 20;
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D texture)
        {
            if (this.Position.X >= 1900)
            {
                direction = direction.right;
                score+=1;
            }
            else if(this.Position.X < 100)
            {
                direction = direction.left;
            }

            spriteBatch.Draw(texture,
                new Rectangle((int) this.Position.X, (int) this.Position.Y, (int) this.FrameSize.X,
                    (int) this.FrameSize.Y), Color.White);
            // TODO: Add your drawing code here

        }
    }
}

