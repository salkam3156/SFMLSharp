using Game.Interfaces;
using static Game.Enums.Enums;

namespace Game.Interfaces
{
    public interface IEntityFactory
    {
         IEntity GetEntity(EntityType type);
    }
}