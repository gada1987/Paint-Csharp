using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class RectangleTool : Tool
    {
        public RectangleTool(int size, Color color) : base(size, color)
        {

        }

        public override void Draw(int x, int y, int toX, int toY, Graphics g)
        {
            Rectangle rectangle = new Rectangle(x, y, toX, toY);
            Brush myBrush = new SolidBrush(Color);
            g.FillRectangle(myBrush, rectangle);
           
        }
    }
}
