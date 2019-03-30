using System;
using System.Collections.Generic;
using System.Text;
using SFMLSharp.Interfaces;

namespace SFMLCore.Interfaces
{
    public interface ICommand
    {
        void Execute(IActor actor);
    }
}
