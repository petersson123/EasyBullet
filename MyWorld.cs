using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;

namespace EasyStart
{
    internal class MyWorld : World
    {
        public MyWorld() : base(600, 800)
        {
            // Tile background with the file "bluerock" in the Content folder.
            BackgroundTileName = "bluerock";
        }  
    }
}
