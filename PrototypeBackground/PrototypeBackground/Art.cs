using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace PrototypeBackground
{
    static class Art
    {
        public static Texture2D Background { get; private set; }
        public static Texture2D Player { get; private set; }


        public static void Load(ContentManager content)
        {
            Background = content.Load<Texture2D>("background");
            Player = content.Load<Texture2D>("Player");

        }
    }
}
