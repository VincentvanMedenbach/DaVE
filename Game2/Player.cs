using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game2
{
    public class Player : Game
    {
        public Texture2D Texture;
        public Vector2 Position;
        public Vector2 FrameSize;
        public enum direction { left, right, up, down };
        private bool jumping;
        private bool falling;
        private int speed;
        public double elapsedAirTime = 0.0;
        double maxAirTime = 10;

        public Player()
        {
            Content.RootDirectory = "Content";
            Position.X = 400;
            Position.Y = 900;
            FrameSize.X = 200;
            FrameSize.Y = 150;
            speed = 10;

        }
        public void Draw(SpriteBatch spriteBatch, Texture2D texture)
        {
            if (this.jumping && elapsedAirTime < maxAirTime)
            {
                double calc = 30 - (-2 * elapsedAirTime);
                elapsedAirTime += 1;
                this.Position.Y -= (int)calc;
            }
            else if (this.falling && this.Position.Y < 900 || elapsedAirTime == maxAirTime && this.Position.Y < 900)
            {
                this.jumping = false;
                this.falling = true;
                double calc = 2 + (1 * elapsedAirTime);
                this.Position.Y += (int)calc;
            }
            else if (this.Position.Y >= 900)
            {
                this.falling = false;
                this.elapsedAirTime = 0;
            }
            spriteBatch.Draw(texture, new Rectangle((int)this.Position.X, (int)this.Position.Y, (int)this.FrameSize.X, (int)this.FrameSize.Y), Color.White);
            // TODO: Add your drawing code here

        }
        public void Move(direction Direction)
        {
            if (Direction == direction.left)
            {
                this.Position.X -= speed;
            }
            if (Direction == direction.right)
            {
                this.Position.X += speed;
            }
            if (Direction == direction.up)
            {
                if (elapsedAirTime < maxAirTime)
                {
                    this.jumping = true;
                }
                else if (Position.Y < 900)
                {
                    this.jumping = false;
                    this.falling = true;

                }
            }
        }

        public bool Collide(Enemy target)
        {
            Rectangle ownRect = new Rectangle((int)this.Position.X,
                (int)this.Position.Y, (int)this.FrameSize.X, (int)this.FrameSize.Y);
            Rectangle targetRect = new Rectangle((int)target.Position.X,
                (int)target.Position.Y, (int)target.FrameSize.X, (int)target.FrameSize.Y);
            return ownRect.Intersects(targetRect);
        }

    }
}
