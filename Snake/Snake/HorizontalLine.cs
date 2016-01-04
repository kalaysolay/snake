using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine: Figure 
    {
      public HorizontalLine(int xLeft, int xRight, int y, char sym) 
      {   
            //y - строка, где будет рисоваться линия, она не изменная, и соответствет 2 параметру для точки
            pList = new List<Point>();
            for ( int x = xLeft; x <= xRight; x++ ) {
                Point p = new Point(x, y, sym);
                pList.Add( p );
            }
        }
    }
}
