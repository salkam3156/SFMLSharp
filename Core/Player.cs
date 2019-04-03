using SFML.Graphics;
using SFML.System;
using Game.Enums;
using Game.Interfaces;
using SFMLSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static Game.Enums.Enums;

namespace Game.Core
{
    internal class Player : IActor
    {
        private readonly Sprite sprite;
        internal Player()
        {

        }
        public int Speed { get; set; } = 10;

        public EntityType GetEntityType()
        {
            return EntityType.Player;
        }

        public Player(string texture)
        {
            sprite = new Sprite(new Texture(texture));
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            sprite.Draw(target, states);
        }
        public void TurnToCursor(Vector2i cursorPosition)
        {
            sprite.Rotation = (float)(-(Math.Atan2(Math.Abs(cursorPosition.X - sprite.Origin.X), Math.Abs(cursorPosition.Y - sprite.Origin.Y)) * 180 / Math.PI));
        }
        public void MoveLeft()
        {
            sprite.Position += new Vector2f(-1 * Speed, 0);
        }

        public void MoveRight()
        {
            sprite.Position += new Vector2f(1 * Speed, 0);
        }
        public void MoveDown()
        {
            sprite.Position += new Vector2f(0, 1 * Speed);
        }

        public void MoveUp()
        {
            sprite.Position += new Vector2f(0, -1 * Speed);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    sprite.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }


        #endregion
    }
}
