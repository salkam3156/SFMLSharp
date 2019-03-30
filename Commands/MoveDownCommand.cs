using SFMLCore.Interfaces;
using SFMLSharp.Interfaces;

namespace SFMLCore
{
    internal class MoveDownCommand : ICommand
    {
        public void Execute(IActor actor)
        {
            actor.MoveDown();
        }
    }
}