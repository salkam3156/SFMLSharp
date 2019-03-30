using Game.Interfaces;
using SFMLSharp.Interfaces;

namespace Game
{
    internal class MoveUpCommand : ICommand
    {
        public void Execute(IActor actor)
        {
            actor.MoveUp();
        }
    }
}