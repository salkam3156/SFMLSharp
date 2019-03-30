using System;
using System.Collections.Generic;
using SFML;
using SFML.Graphics;
using SFML.Window;
using SFMLCore;

namespace MainLoop
{
    internal class Game
    {
        static void Main(string[] args)
        {
            using (var player = new Player(@"Resources/doge.png"))
            using (var enemy = new Enemy())
            using (var scene = new Scene(player, new InputHandler()))
            {
                scene.SubscribeElement(enemy);
                scene.Play();
            }
        }
    }
}
