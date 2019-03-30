using Game.Interfaces;
using SFMLSharp.Interfaces;

namespace Game
{
    internal class MoveRightCommand : ICommand
    {
        public void Execute(IActor actor)
        {
            actor.MoveRight();
        }
    }
}