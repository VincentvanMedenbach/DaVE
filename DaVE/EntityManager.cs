using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace DaVE
{
    static class EntityManager
    {
        static List<Entity> entities = new List<Entity>();
        private static bool isUpdating;
        static List<Entity> addedEntities = new List<Entity>();

        public static int Count
        {
            get { return entities.Count;  }
        }

        public static void Add(Entity entity)
        {
            if (!isUpdating)
            {
                AddEntity(entity);
            }
            else
            {
                addedEntities.Add(entity);
            }
            addedEntities.Clear();
    }


        public static void Update()
        {
            isUpdating = true;
            HandleCollisions();

            foreach (var entity in entities)
            {
                entity.Update();
            }
            isUpdating = false;
            foreach (var entity in addedEntities)
            {
                AddEntity(entity);
            }
        }
        public static void Draw(SpriteBatch spriteBatch)
        {
            foreach (var entity in entities)
            {
                entity.Draw(spriteBatch);
            }
        }

        public static void AddEntity(Entity entity)
        {
            entities.Add(entity);
          // TODO add logic for different Entities
        }

        static void HandleCollisions()
        {
            //TODO use build in function of Mono to detect if 2 enemies are colliding
        }
    }
    }
