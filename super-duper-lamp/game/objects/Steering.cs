﻿using System;
using super_duper_lamp.core.objects;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace super_duper_lamp.game.objects
{
    class Steering : Part
    {
        public Steering(string pathToTexture, Ship Parent) : base("steering", pathToTexture, Parent)
        {
            Sprite.Scale =new Vector2f(0.1f, 0.1f);
        }

        public override void Think(Time dt)
        {
            //tween angular velocity so that the movement is smooth and more difficult to 360, takes a time for vel to catch up
            
            base.Think(dt);
        }

        public override void Draw(RenderWindow window)
        {
            //needs to be moved
            if (((Player)Parent).MouseLDown)
            {
                //Doesnt work when moving away from 0,0
                var MousePos = Mouse.GetPosition(window) - new Vector2i((int)window.Size.X / 2, (int)window.Size.Y / 2);
                Console.WriteLine(MousePos);

                Parent.Rotation = (float)(Math.Atan2(MousePos.Y, MousePos.X) * (180.0 / Math.PI)) + 90;
            }

            base.Draw(window);
        }
    }
}
