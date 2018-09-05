using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            FrameSize.X = (float)(screenSize.X * 0.11);
            FrameSize.Y = (float)(screenSize.Y * 0.2);
            Position.X = (screenSize.X - FrameSize.X) ;
            Position.Y = (screenSize.Y - FrameSize.Y);
            speed = 10;
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D texture)
        {
            if (this.Position.X >= (screenSize.X - FrameSize.X))
            {
                direction = direction.right;
                score+=1;
                speed += 1;

            }
            else if(this.Position.X < 0)
            {
                direction = direction.left;
                score += 1;
                speed += 1;
            }

            spriteBatch.Draw(texture,
                new Rectangle((int) this.Position.X, (int) this.Position.Y, (int) this.FrameSize.X,
                    (int) this.FrameSize.Y), Color.White);
            // TODO: Add your drawing code here

        }
    }
}

