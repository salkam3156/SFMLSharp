using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Game.Interfaces;
using SFMLSharp.Interfaces;
using static Game.Enums.Enums;

namespace Game.Core
{
    public class DrawLayerSeparator : IDrawLayerSeparator
    {
        ObservableCollection<IEntity> drawables;
        public DrawLayerSeparator(ObservableCollection<IEntity> drawableElementsCollection)
        {
            drawables = drawableElementsCollection;
        }
        public IList<IEntity> GetBackgroundLayer()
        {
            return drawables.Where(x => x.GetEntityType() == EntityType.Background).ToList();
        }

        public IList<IEntity> GetNonPlayerActorsElementsLayer()
        {
            return drawables.Where(x => x.GetEntityType() == EntityType.Enemy).ToList();
        }

        public IList<IEntity> GetStaticObjectsLayer()
        {
            return drawables.Where(x => x.GetEntityType() == EntityType.SceneElement).ToList();
        }
    }
}