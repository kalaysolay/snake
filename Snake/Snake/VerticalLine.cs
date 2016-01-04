using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake 
{
    class VerticalLine : Figure
    {
        public VerticalLine( int xTop, int xBottom, int x, char sym ) 
        {
            //y - строка, где будет рисоваться линия
            pList = new List<Point>();
            for (int y = xTop; y <= xBottom; y++)
            {
                Point vPoint = new Point( x, y, sym );
                pList.Add( vPoint );
            }
        }
    }
}