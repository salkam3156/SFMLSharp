using System.Collections.Generic;
using System.Collections.ObjectModel;
using Game.Interfaces;

namespace SFMLSharp.Interfaces
{
    public interface IDrawLayerSeparator
    {
        IList<IEntity> GetBackgroundLayer();
        IList<IEntity> GetStaticObjectsLayer();
        IList<IEntity> GetNonPlayerEntitiesLayer();
    }
}