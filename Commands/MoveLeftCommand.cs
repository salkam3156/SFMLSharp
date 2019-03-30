using SFMLCore.Interfaces;
using SFMLSharp.Interfaces;

namespace SFMLCore
{
    internal class MoveLeftCommand : ICommand
    {
        public void Execute(IActor actor)
        {
            actor.MoveLeft();
        }
    }
}