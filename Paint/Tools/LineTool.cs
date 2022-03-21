using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class LineTool : Tool
    {
        public LineTool(int size, Color color) : base(size, color)
        {

        }

        public override void Draw(int x, int y, int toX, int toY, Graphics g)
        {
            Pen myPen = new Pen(Color, Size);
            g.DrawLine(myPen, x, y, toX, toY);
           
        }
    }
}
