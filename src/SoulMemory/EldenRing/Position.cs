using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory.EldenRing
{
    public class Position
    {
        public byte Area;
        public byte Block;
        public byte Region;
        public byte Size;

        public float X;
        public float Y;
        public float Z;

        public override string ToString()
        {
            return $"m{Area:D2}_{Block:D2}_{Region:D2}_{Size:D2} - ({X:F2}, {Y:F2}, {Z:F2})";
        }
    }
}
