using SFML.Graphics;
using SFML.System;
using SFMLCore.Enums;
using SFMLCore.Interfaces;
using SFMLSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static SFMLCore.Enums.Enums;

namespace SFMLCore
{
    internal class Player : IActor
    {
        private readonly Sprite sprite;
        public int Speed{ get; set; } = 10;

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
        public void MoveLeft()
        {
            sprite.Position += new Vector2f(-1 * Speed,0);
        }

        public void MoveRight()
        {
            sprite.Position += new Vector2f(1 * Speed, 0);
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
