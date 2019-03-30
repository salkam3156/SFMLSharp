using SFMLCore.Interfaces;

namespace SFMLSharp.Interfaces
{
    public interface IActor : IEntity
    {
         void MoveLeft();
         void MoveRight();
         void MoveDown();
         void MoveUp();
    }
}