using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DaVE
{
    class Console
    {
        //Texture2D pixel;
        Texture2D textureImage;
        Point size;

        public Console(Texture2D textureImage, Point size)
        {
            //this.pixel = pixel;
            this.textureImage = textureImage;
            this.size = size;

        }

        public void Initialize()
        {
            //pixel.SetData(new[] { Color.White });
        }


        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //spriteBatch.Draw(pixel, new Rectangle(10, 20, 100, 50), Color.DarkGreen);

            spriteBatch.Draw(textureImage, Vector2.Zero, new Rectangle(Point.Zero, size), Color.White);
        }

    }
}
