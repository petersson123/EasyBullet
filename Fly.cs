using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;
using Microsoft.Xna.Framework.Input;

namespace EasyBullet
{
    internal class Fly : Actor
    {
        public override void Act()
        {
            Turn(EasyGame.Instance.Random.Next(-30, 30));
            Move(3);
            
            if (IsTouching(typeof(Bullet)))
            {
                World.RemoveActor(this);
            }
        }

    }
    
}
