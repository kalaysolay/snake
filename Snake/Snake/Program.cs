using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program {
        private static void Main( string[] args ) {
            var p1 = new Point();
            p1.x = 1;
            p1.y = 2;
            p1.sym = '*';

            p1.PrintSymbol();

            var p2 = new Point();
            p2.x = 3;
            p2.y = 7;
            p2.sym = '$';
            p2.PrintSymbol();
            Console.ReadKey();

            /*      PrintSymbol(1, 5, '*');
            PrintSymbol(2, 6, '*');
            PrintSymbol(3, 7, '*');

            Console.ReadKey();
        }*/


        }


    }
}
