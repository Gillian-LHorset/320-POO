using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.View
{
    public class Factory : Building
    {
        public Factory(int dimensionX, int dimensionY, int x, int y) : base(dimensionX, dimensionY, x, y)
        {
        }
    }
}
