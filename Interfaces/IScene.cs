using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace SFMLCore.Interfaces
{
    internal interface IScene
    {
        void SubscribeElement(IEntity element);
        void UnsubscribeElement(IEntity element);
        void Play();
    }
}
