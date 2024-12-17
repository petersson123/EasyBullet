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

            for (int i = 0; i < 20; ++i)
            {
                float x = EasyGame.Instance.Random.Next(Width);
                float y = EasyGame.Instance.Random.Next(Height);
                this.Add(new Fly(), "fly", x, y);
            }



        }


    }
}
