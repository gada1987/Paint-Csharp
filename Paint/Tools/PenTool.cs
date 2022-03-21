using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class PenTool : Tool
    {
        Pen myPen;
       
        public PenTool(int size, Color color) : base(size, color)
        {
            
        }

        public override void Draw(int x, int y, int toX, int toY, Graphics g)
        {
            myPen = new Pen(Color, Size);
            myPen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            g.DrawLine(myPen, x, y, toX, toY);
        }
    }
}
