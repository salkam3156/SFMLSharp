using SFMLCore.Interfaces;
using SFMLSharp.Interfaces;

namespace SFMLCore
{
    internal class MoveUpCommand : ICommand
    {
        public void Execute(IActor actor)
        {
            actor.MoveUp();
        }
    }
}