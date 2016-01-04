using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {

        public Snake( Point tail, int lenght, Directions direction ) 
        {
            pList = new List<Point>();
            for ( int i = 0; i < lenght; i++ )  // пока не дойдем до длины
            {
             var p = new Point(tail); // Создаем точку. В первой итерации, когда I = 0, это будет начальной точкой хвостом. 
                // В следующих итерациях, мы хвосту прибавлять точки методом Move.
                // Т.е. если зададим начальную точку (3;4) и укажем, что у глиста будет длина 2 и направление влево
                // то в первой итерации точка так и останется 3,4. Во второй итерации, мы отнимем с точки Х (она имеет значение 3) единицу. И новая точка будет иметь координаты (2;4)
                p.Move( i, direction ); // двигаем точку по направлению 
                pList.Add( p );
            }
        }
    }
}
