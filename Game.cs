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
            using (var player = new Entity(@"Resources/skewee.jpg"))
            using (var enemy = new Entity())
            using (var scene = new Scene(player, new InputHandler()))
            {
                scene.SubscribeElement(enemy);
                scene.Play();
            }
        }
    }
}
