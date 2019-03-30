using System;
using System.Collections.Generic;
using System.Text;
using static SFMLCore.Enums.Enums;

namespace SFMLCore.Interfaces
{
    public interface IEntity : IDrawable
    {
        EntityType GetEntityType();
    }
}
