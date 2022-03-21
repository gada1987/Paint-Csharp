using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    class EraserTool : Tool
    {
        Pen myPen;
        public EraserTool(int size) : base(size) 
        {
            
        }

        public override void Draw(int x, int y, int toX, int toY, Graphics g)
        {
            myPen = new Pen(Color.White, Size);
            myPen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            g.DrawLine(myPen, x, y, toX, toY);
        }
    }
}
