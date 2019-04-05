using Game.Core;
using Game.Enums;
using Game.Interfaces;
using static Game.Enums.Enums;

namespace Game.Factories
{
    public class EntityFactory : IEntityFactory
    {
        public IEntity GetEntity(EntityType entityType)
        {
            IEntity outEntity = null;

            switch(entityType)
            {
                case EntityType.Player:
                {
                    outEntity = new Player();
                    break;
                }
                case EntityType.Enemy:
                {
                    outEntity = new Enemy();
                    break;
                }
                case EntityType.Projectile:
                {
                    outEntity = new Projectile();
                    break;
                }
                default:
                {
                    outEntity = null;
                    break;
                }
                
            }
            
            return outEntity;
        }
    }
}