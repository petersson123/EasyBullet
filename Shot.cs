using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;

namespace EasyShooter
{
    internal class Shot : Actor
    {
        public override void Act()
        {
            Move(20);
            if ( IsAtEdge())
            {
                World.RemoveActor(this);
            }
        }

    }
}
