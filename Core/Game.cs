﻿using System;
using System.Collections.Generic;
using SFML;
using SFML.Graphics;
using SFML.Window;
using Game;

namespace Game.Core
{
    internal class Game
    {
        static void Main(string[] args)
        {
            using (var player = new Player(@"Resources/soldier_shotgun.png"))
            using (var enemy = new Enemy())
            using (var scene = new Scene(player, new KeyboardInputHandler()))
            {
                scene.SubscribeElement(enemy);
                scene.Play();
            }
        }
    }
}
