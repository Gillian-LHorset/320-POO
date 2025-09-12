namespace Drones.View
{
    public class Building
    {
        SolidBrush buildingBrush = new SolidBrush(Color.Gray);


        private int _x;
        private int _y;

        private int _dimensionX;
        private int _dimensionY;

        public int DimensionX { get; set; }
        public int DimensionY { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dimensionX">Taille horizontale du batiment</param>
        /// <param name="dimensionY">Taille vertical du batiment</param>
        /// <param name="x">position horizontale du batiment</param>
        /// <param name="y">posistion vertical du batiment</param>
        public Building(int dimensionX, int dimensionY, int x, int y)
        {
            DimensionX = dimensionX;
            DimensionY = dimensionY;
            _x = x;
            _y = y;
        }

        public void BuildingRender(BufferedGraphics drawingSpace)
        {
            Rectangle rect = new Rectangle(DimensionX, DimensionY, X, Y);

            drawingSpace.Graphics.FillRectangle(buildingBrush, rect);
        }


        public string _color = "gray";
    }
}
