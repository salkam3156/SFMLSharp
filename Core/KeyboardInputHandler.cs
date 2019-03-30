using SFML.System;
using SFML.Window;
using SFMLCore.Interfaces;

namespace SFMLCore
{
    public class KeyboardInputHandler : IInputHandler
    {
        //TODO: check tapping into some keypressed event for command assignment
        public ICommand HandleIput()
        {
            ICommand commandToExecute = null;

            if(Keyboard.IsKeyPressed(Keyboard.Key.Left))
            {
                commandToExecute = new MoveLeftCommand();
            }

            if(Keyboard.IsKeyPressed(Keyboard.Key.Right))
            {
                commandToExecute = new MoveRightCommand();
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.Down))
            {
                commandToExecute = new MoveDownCommand();
            }
            
            if (Keyboard.IsKeyPressed(Keyboard.Key.Up))
            {
                commandToExecute = new MoveUpCommand();
            }
            
            return commandToExecute;
        }
    }
}