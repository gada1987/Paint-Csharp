using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class CircleTool : Tool
    {
        public CircleTool(int size, Color color) : base(size, color)
        {
            
        }

        public override void Draw(int x, int y, int toX, int toY, Graphics g)
        {
            Rectangle rectangle = new Rectangle(x, y, toX, toY);
            Brush myBrush = new SolidBrush(Color);
            g.FillEllipse(myBrush, rectangle);
           
        }
    }
}
