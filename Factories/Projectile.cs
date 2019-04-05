using System;
using Game.Enums;
using Game.Interfaces;
using SFML.Graphics;
using SFML.System;
using static Game.Enums.Enums;

namespace Game.Factories
{
    public class Projectile : IProjectile
    {
        private Sprite sprite = new Sprite(new Texture(@"Resources/bullet.png"));
        private EntityType type = EntityType.Projectile;
        private Vector2f direction;
        private int speed = 15;

        public void Dispose()
        {
            sprite.Dispose();
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            sprite.Draw(target, states);
        }

        public EntityType GetEntityType()
        {
            return type;
        }

        public void Move()
        {
            sprite.Position += direction * speed;
        }

        public void SetDirection(Vector2f direction)
        {
            this.direction = direction;
            AlignWithShootVector();
        }

        private void AlignWithShootVector()
        {
            sprite.Rotation = (float)(-(Math.Atan2((direction.X - sprite.Position.X), (direction.Y - sprite.Position.Y)) * 180 / Math.PI) + 90);
        }
    }
}