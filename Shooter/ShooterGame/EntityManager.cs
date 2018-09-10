﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace ShooterGame
{
    static class EntityManager
    {
        static List<Entity> entities = new List<Entity>();
        private static bool isUpdating; 
        static List<Entity> addedEntities = new List<Entity>();

        public static int Count { get { return entities.Count; } }

        public static void Add(Entity entity)
        {
            if (!isUpdating)
            {
                entities.Add(entity);
            }
            else
            {
                addedEntities.Add(entity);
            }
        }

        public static void Update()
        {
            isUpdating = true;

            foreach (var entity in entities)
                entity.Update();
            isUpdating = false;

            foreach (var entity in addedEntities)
            {
                entities.Add(entity);
            }
            addedEntities.Clear();
            //Remove dead
            entities = entities.Where(x => !x.isExpired).ToList();

        }

        public static void Draw(SpriteBatch spriteBatch)
        {
            foreach(var entity in entities)
            {
                entity.Draw(spriteBatch);
            }
        }
    }
}
