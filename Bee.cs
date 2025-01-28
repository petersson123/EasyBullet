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
        private int timeToShoot = 0;
        private int lives = 3;

        public override void Act()
        {
            timeToShoot -= 1;

            this.TurnTowards(Mouse.GetState().X, Mouse.GetState().Y);

            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                if (timeToShoot <= 0)
                {
                    Shoot();
                    timeToShoot = 20;
                }

            }

            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                X = X + 3;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                X = X - 3;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                Y = Y - 3;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                Y = Y + 3;
            }
            if (IsTouching(typeof(Fly)))
            {
                RemoveTouching(typeof(Fly));
                lives -= 1;
                List<Actor> hearts = World.GetActors(typeof(Heart));
                World.RemoveActor(hearts[0]);
                if (lives == 0)
                {
                    World.ShowText("Game over", 500, 500);
                    EasyGame.Instance.IsPaused = true;
                }

            }
            if (IsTouching(typeof(Fly2)))
            {
                RemoveTouching(typeof(Fly2));
                lives -= 1;
                List<Actor> hearts = World.GetActors(typeof(Heart));
                World.RemoveActor(hearts[0]);
                if (lives == 0)
                {
                    World.ShowText("Game over", 500, 500);
                    EasyGame.Instance.IsPaused = true;
                }

            }
        }
        private void Shoot()
        {
            Bullet bullet = new Bullet();
            World.Add(bullet, "red-draught", this.X, this.Y);
            bullet.Rotation = this.Rotation;
            bullet.Move(50);
        }
    }
}
