using System;
using System.Collections.Generic;
using System.Text;

namespace SFMLCore.Interfaces
{
    public interface ICommand
    {
        void Execute(IEntity actor);
    }
}
