using System;
using System.Collections.Generic;
using System.Text;
namespace Game.Interfaces
{
    public interface ICommand
    {
        void Execute(IActor actor);
    }
}
