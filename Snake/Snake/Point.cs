using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point {
        public int X;
        public int Y;
        public char Sym;

        public Point() {
            
            }

        public Point(int _x, int _y, char _s) 
            {
                X = _x;
                Y = _y;
                Sym = _s;
            }

        public Point( Point p ) {
            X = p.X;
            Y = p.Y;
            Sym = p.Sym;
        }

        public void Move( int offset, Directions directions ) {
            //    offset расстояние
            if ( directions == Directions.Right ) {
                X = X + offset;
            }
            else if ( directions == Directions.Left ) {
                X = X - offset;
            }
            else if (directions == Directions.Up)
            {
                Y = Y - offset;
            }
            else if(directions == Directions.Down)
            {
                Y = Y + offset;
            }





























































































































































































        }

        public void Drow()
            {
                Console.SetCursorPosition(X,Y);
                Console.Write(Sym);

            }
    }
}
