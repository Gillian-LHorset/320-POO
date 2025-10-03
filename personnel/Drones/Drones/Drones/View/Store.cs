using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.View
{
    public class Store : Building
    {
        public string OpeningHours = "Lundi : 8h-18h";

        private int _x;
        private int _y;

        private int _dimensionX;
        private int _dimensionY;

        protected override SolidBrush BuildingBrush => new SolidBrush(Color.Blue);

        public Store(int dimensionX, int dimensionY, int x, int y) : base(dimensionX, dimensionY, x, y)
        {
            _dimensionX = dimensionX;
            _dimensionY = dimensionY;
            _x = x;
            _y = y;
        }

        public override void BuildingRender(BufferedGraphics drawingSpace)
        {

            Rectangle circle = new Rectangle(_x, _y, _dimensionX, _dimensionY);
            drawingSpace.Graphics.FillEllipse(BuildingBrush, circle);
        }
    }
}
