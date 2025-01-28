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
        private int score = 0;
        private const int START_FLY_COUNT = 8;
        private const int START_FLY2_COUNT = 5;
        private Bee player;

        public MyWorld() : base(800, 800)
        {
            // Tile background with the file "bluerock" in the Content folder.
            BackgroundTileName = "bluerock";
            player = new Bee();
            this.Add(player, "bee", Width / 2, Height / 2);

            for (int i = 0; i < 3; i++)
            {
                this.Add(new Heart(), "red-draught", 50 + 30 * i, 50);
            }

            for (int i = 0; i < START_FLY_COUNT; ++i)
            {
                float x = EasyGame.Instance.Random.Next(Width);
                float y = EasyGame.Instance.Random.Next(Height);
                this.Add(new Fly(), "fly", x, y);
            }
            for (int i = 0; i < START_FLY2_COUNT; ++i)
            {
                float x = EasyGame.Instance.Random.Next(Width);
                float y = EasyGame.Instance.Random.Next(Height);
                this.Add(new Fly2(player), "fly", x, y);
            }



        }

        public override void Act()
        {
            List<Actor> flies = GetActors(typeof(Fly));
            if (flies != null)
            {
                int numFlies = flies.Count;
                score = START_FLY_COUNT - numFlies;
                ShowText("Score: " + score, 100, 100);
            }
            
        }


    }
}
