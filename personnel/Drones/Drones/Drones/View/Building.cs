namespace Drones.View
{
    public class Building
    {
        SolidBrush buildingBrush = new SolidBrush(Color.Gray);


        private int _x;
        private int _y;

        private int _dimensionX;
        private int _dimensionY;

        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dimensionX">Taille horizontale du batiment</param>
        /// <param name="dimensionY">Taille vertical du batiment</param>
        /// <param name="x">position horizontale du batiment</param>
        /// <param name="y">posistion vertical du batiment</param>
        public Building(int dimensionX, int dimensionY, int x, int y)
        {
            _dimensionX = dimensionX;
            _dimensionY = dimensionY;
            _x = x;
            _y = y;
        }

        public void BuildingRender(BufferedGraphics drawingSpace)
        {
            Rectangle rect = new Rectangle(_x, _y, _dimensionX, _dimensionY);

            drawingSpace.Graphics.FillRectangle(buildingBrush, rect);
        }


    }
}
