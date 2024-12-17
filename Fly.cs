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
            
            if (IsTouching(typeof(Bullet)))
            {
                World.RemoveActor(this);
            }
        }

    }
    
}
