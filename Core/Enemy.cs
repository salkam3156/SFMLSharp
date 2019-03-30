using SFML.Graphics;
using SFMLCore.Enums;
using SFMLCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static SFMLCore.Enums.Enums;

namespace SFMLCore
{
    internal class Enemy : IEntity
    {
        private readonly Sprite sprite = new Sprite(new Texture(@"Resources/doge.png"));

        public Enemy()
        {

        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            sprite.Draw(target, states);
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

        public EntityType GetEntityType()
        {
            return EntityType.Enemy;
        }

        #endregion


    }
}
