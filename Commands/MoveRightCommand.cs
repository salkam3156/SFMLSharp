using SFMLCore.Interfaces;
using SFMLSharp.Interfaces;

namespace SFMLCore
{
    internal class MoveRightCommand : ICommand
    {
        public void Execute(IActor actor)
        {
            actor.MoveRight();
        }
    }
}