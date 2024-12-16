using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;

namespace EasyShooter
{
    internal class MyWorld : World
    {
        private Bee bee;
        private int score = 0;
        private const int MAX_FLY = 20;
        public MyWorld() : base(800, 800)
        {
            // Tile background with the file "bluerock" in the Content folder.
            BackgroundTileName = "bluerock";

            bee = new Bee();
            Add(bee, "bee", 400, 400);

            for (int i = 0; i < MAX_FLY; i++)
            {
                float x = EasyGame.Instance.Random.Next(0, 800);
                float y = EasyGame.Instance.Random.Next(0, 800);
                Add(new Fly(), "fly", x, y);
            }

        }

        public override void Act()
        {
            List<Actor> flies = GetActors(typeof(Fly));
            int noFlies = flies.Count;
            score = MAX_FLY - noFlies;
            ShowText("Score: " + score, 100, 100);
        }
    }
}
