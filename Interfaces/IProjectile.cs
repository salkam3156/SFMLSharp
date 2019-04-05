using Game.Interfaces;
using SFML.System;

namespace Game.Interfaces
{
    public interface IProjectile : IEntity
    {
         void Move();
         void SetDirection(Vector2f direction);
    }
}