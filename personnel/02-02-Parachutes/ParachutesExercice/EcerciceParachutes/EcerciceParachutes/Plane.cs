using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcerciceParachutes
{
    public class Plane
    {
        public int _planePositionX = 0;

        public string[] planeskin =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        public void Draw()
        {
            for (int i = 0; i < planeskin.Length; i++)
            {
                Console.SetCursorPosition(_planePositionX, i);
                Console.WriteLine(planeskin[i]);
            }
        }

        public void PlaneMove()
        {
            _planePositionX++;
        }
    }
}
