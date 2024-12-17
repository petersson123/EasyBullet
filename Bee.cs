using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;
using Microsoft.Xna.Framework.Input;

namespace EasyBullet
{
    internal class Bee : Actor
    {

        public override void Act()
        {

            this.TurnTowards(Mouse.GetState().X, Mouse.GetState().Y);
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                Bullet bullet = new Bullet();
                World.Add(bullet, "red-draught", this.X, this.Y);
                bullet.Rotation = this.Rotation;
                bullet.Move(50);
            }
        }
    }
}
