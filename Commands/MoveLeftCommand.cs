using Game.Interfaces;

namespace Game.Commands
{
    internal class MoveLeftCommand : ICommand
    {
        public void Execute(IActor actor)
        {
            actor.MoveLeft();
        }
    }
}