using Game.Interfaces;

namespace Game.Commands
{
    internal class MoveDownCommand : ICommand
    {
        public void Execute(IActor actor)
        {
            actor.MoveDown();
        }
    }
}