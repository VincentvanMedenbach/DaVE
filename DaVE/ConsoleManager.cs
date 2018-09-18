using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DaVE
{
    class ConsoleManager : DrawableGameComponent
    {
        SpriteBatch spriteBatch;

        Console console;
        //Texture2D pixel;
        Texture2D textureImage;

        public ConsoleManager(Game game)
            : base(game)
        {
            //pixel = new Texture2D(Game.GraphicsDevice, 1, 1, false, SurfaceFormat.Color);

        }

        public override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);

            //console = new Console(pixel);

            console = new Console(Game.Content.Load<Texture2D>("image"), new Point(385, 424));

            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();

            console.Draw(gameTime, spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
