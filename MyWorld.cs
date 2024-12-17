using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;

namespace EasyBullet
{
    internal class MyWorld : World
    {

        public MyWorld() : base(800, 800)
        {
            // Tile background with the file "bluerock" in the Content folder.
            BackgroundTileName = "bluerock";

            this.Add(new Bee(), "bee", Width / 2, Height / 2);



        }


    }
}
