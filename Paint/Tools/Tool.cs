using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    abstract class Tool
    {
        public bool DrawOnMove { get; set; }
        public Color Color { get; set; }

        public virtual int Size { get; set; } = 1;

        public Tool(int size, Color color)
        {

            Color = color;
            Size = size;
        }

        public Tool(int size)
        {
            Size = size;
        }

        public virtual void Draw(int x, int y, int toX, int toY, Graphics g)
        {

        }
    }
}
    
