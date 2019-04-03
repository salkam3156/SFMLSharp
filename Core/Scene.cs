using SFML.Graphics;
using SFML.Window;
using Game.Interfaces;
using SFMLSharp.Interfaces;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Game.Core
{
    public class Scene : IScene, IDisposable
    {
        private ObservableCollection<IEntity> drawableElements = new ObservableCollection<IEntity>();
        private IList<IEntity> backGroundLayer = new List<IEntity>();
        private IList<IEntity> actorsLayer = new List<IEntity>();
        private IList<IEntity> staticElementsLayer = new List<IEntity>();
        private IActor player;
        private readonly RenderWindow window;
        private readonly IInputHandler inputHandler;
        private readonly IDrawLayerSeparator drawLayerSeparator;
        private readonly Stopwatch timer = new Stopwatch();
        private readonly TimeSpan frameTime = new TimeSpan();
        private readonly TimeSpan innputPollingTime = new TimeSpan();

        public Scene(IActor player, IInputHandler inputHandler)
        {
            this.inputHandler = inputHandler;
            this.drawLayerSeparator = new DrawLayerSeparator(drawableElements);
           
            this.player = player;

            window = new RenderWindow(VideoMode.DesktopMode, "SFML");
            //TODO: make configurable
            window.SetVerticalSyncEnabled(true);
            window.SetMouseCursorVisible(true);
            frameTime = TimeSpan.FromMilliseconds(1000/60);
            innputPollingTime = frameTime/2;

            window.KeyPressed += (o, e) => { if(e.Alt && Keyboard.IsKeyPressed(Keyboard.Key.C)){ window.Close();} };

            drawableElements.CollectionChanged += ReevaluateLayerSeparation;
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

            timer.Start();

            while (window.IsOpen)
            {
                window.DispatchEvents();
                player.TurnToCursor(Mouse.GetPosition());
                
                if (timer.Elapsed >= innputPollingTime) 
                {
                    var inputCommand = inputHandler.HandleIput();
                    inputCommand?.Execute(player);

                }

                if(timer.Elapsed >= frameTime)
                {
                    DrawScene();
                }
            }
        }

        private void DrawScene()
        {
            window.Clear();

            foreach (var element in backGroundLayer)
            {
                element.Draw(window, RenderStates.Default);
            }

            foreach (var element in staticElementsLayer)
            {
                element.Draw(window, RenderStates.Default);
            }

            foreach (var element in actorsLayer)
            {
                element.Draw(window, RenderStates.Default);
            }

            player.Draw(window, RenderStates.Default);

            window.Display();
        }

        private void ReevaluateLayerSeparation(object sender, NotifyCollectionChangedEventArgs e)
        {
            backGroundLayer = drawLayerSeparator.GetBackgroundLayer();
            actorsLayer = drawLayerSeparator.GetNonPlayerEntitiesLayer();
            staticElementsLayer = drawLayerSeparator.GetStaticObjectsLayer();
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
