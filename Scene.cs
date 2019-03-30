using SFML.Graphics;
using SFML.Window;
using SFMLCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SFMLCore
{
    public class Scene : IScene, IDisposable
    {
        private IList<IDrawable> drawableElements = new List<IDrawable>();
        private IEntity player;
        private readonly RenderWindow window;
        private readonly IInputHandler inputHandler;

        public Scene(IEntity player, IInputHandler inputHandler)
        {
            this.inputHandler = inputHandler;

            this.player = player;

            window = new RenderWindow(VideoMode.DesktopMode, "SFML");

            window.SetFramerateLimit(60);
            window.SetVerticalSyncEnabled(true);
            window.MouseButtonPressed += (o, e) => { window.Close(); };
        }

        public void SubscribeElement(IEntity element)
        {
            drawableElements.Add(element);
        }

        public void UnsubscribeElement(IEntity element)
        {
            drawableElements.Remove(element);
        }

        public void Play()
        {
            if(player == null)
            {
                throw new Exception(@"The player character has not been set");
            }

            while (window.IsOpen)
            {
                window.DispatchEvents();

                inputHandler.HandleIput();

                window.Clear();
                
                foreach(var element in drawableElements)
                {
                    element.Draw(window, RenderStates.Default);
                }
                
                player.Draw(window, RenderStates.Default);

                window.Display();
            }
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    foreach(var element in drawableElements)
                    {
                        element.Dispose();
                        window.Dispose();
                    }
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
