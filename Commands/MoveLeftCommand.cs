using Game.Interfaces;
using SFMLSharp.Interfaces;

namespace Game
{
    internal class MoveLeftCommand : ICommand
    {
        public void Execute(IActor actor)
        {
            actor.MoveLeft();
        }
    }
}