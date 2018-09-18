using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace DaVE
{
    class Art
    {
        public static Texture2D ExampleTexture2D { get; private set; }
        public static void Load(ContentManager content)
        {
            ExampleTexture2D = content.Load<Texture2D>("example");

        }

        public static void Unload(ContentManager content)
        {

        }
    }
}
