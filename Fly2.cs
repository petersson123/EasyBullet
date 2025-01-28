using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;
using Microsoft.Xna.Framework.Input;

namespace EasyBullet
{
    internal class Fly2 : Actor
    {
        private Bee player;
        public Fly2(Bee mittBee)
        {
            player = mittBee;  
    }
        public override void Act()
        {
           
            TurnTowards(player.X,player.Y);
            Move(1);

            if (IsTouching(typeof(Bullet)))
            {
                World.RemoveActor(this);
            }
        }

    }

}
