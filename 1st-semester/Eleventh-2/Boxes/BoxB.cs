using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Boxes
{
    class BoxB
    {
        //캡슐화 : 변수 width 와 height 를 건드리지 못하도록 BoxA에서 수정
        private int width;
        private int height;

        public BoxB(int width, int height)
        {
            if(width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                WriteLine("너비와 높이는 자연수로 초기화해 주세요!");   
            }
        }

        public int Area()
        {
            return width * height;
        }
    }
}
