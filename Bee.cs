using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;
using Microsoft.Xna.Framework.Input;

namespace EasyShooter
{
    internal class Bee : Actor
    {
        private int reloadCountDown = 0;
        public override void Act()
        {
            reloadCountDown -= 1;
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && reloadCountDown < 0)
            {
                Shoot();
                reloadCountDown = 10  ;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                Turn(-5);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                Turn(5);
            }
        }
        private void Shoot()
        {
            Shot shot = new Shot();
            // Shoot in the direction the bee is facing.
            shot.Rotation = this.Rotation;
            World.Add(shot, "red-draught", X, Y);
            // Start the shot in front of the bee
            shot.Move(50);
        }
    }
}
