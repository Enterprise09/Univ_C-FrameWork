using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class BoxA
    {
        public int width, height;

        public BoxA(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Area()
        {
            return width * height;
        }

    }
}
