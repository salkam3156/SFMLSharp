using Game.Interfaces;
using SFMLSharp.Interfaces;

namespace Game
{
    internal class MoveDownCommand : ICommand
    {
        public void Execute(IActor actor)
        {
            actor.MoveDown();
        }
    }
}