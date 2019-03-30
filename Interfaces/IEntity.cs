using System;
using System.Collections.Generic;
using System.Text;
using static Game.Enums.Enums;

namespace Game.Interfaces
{
    public interface IEntity : IDrawable
    {
        EntityType GetEntityType();
    }
}
