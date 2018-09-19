using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace DaVE
{
    class Art
    {
        public static Texture2D BackgroundLevel1 { get; private set; }
        public static SpriteFont Font { get; private set; }
        public static void Load(ContentManager content)
        {
            BackgroundLevel1 = content.Load<Texture2D>("backgroundLevel1");
            Font = content.Load<SpriteFont>("Font");
        }

        public static void Unload(ContentManager content)
        {

        }
    }
}
