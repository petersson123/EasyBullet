using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;

namespace EasyBullet
{
    internal class Bullet : Actor
    {
        public override void Act()
        {
            Move(20);
            if (this.IsAtEdge())
            {
                World.RemoveActor(this);
            }
        }

    }
}
