using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOP.Classes
{
    // Structres is value type -- Class is refrence type.
    // Value type is more fast in performance more than refrence type.
    // Inheritance not work in struct between each other (can inhert interface)
    public struct Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void MovePoint()
        {
            x = x++;
        }
    }
}
