using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args) {
            PrintSymbol(1, 5, '*');
            PrintSymbol(2, 6, '*');
            PrintSymbol(3, 7, '*');

            Console.ReadKey();
        }

        public static void PrintSymbol( int x, int y, char s ) {
         Console.SetCursorPosition( x,y );
         Console.Write(s);
        }
    }
}
