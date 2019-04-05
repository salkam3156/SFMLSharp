using Game.Interfaces;
using SFML.System;

namespace Game.Interfaces
{
    public interface IActor : IEntity
    {
         void MoveLeft();
         void MoveRight();
         void MoveDown();
         void MoveUp();
         void TurnToCursor(Vector2i cursorPosition);
    }
}