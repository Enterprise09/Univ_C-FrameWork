using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Boxes
{
    class BoxD
    {
        //변수 선언
        private int width;
        private int height;

        //속성 생성
        public int Width
        {
            get { return width; }
            set
            {
                if(value > 0)
                {
                    width = value;
                }
                else
                {
                    WriteLine("넓이는 자연수를 입력해 주세요.");
                }
            }
        }

        //속성 생성
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    WriteLine("높이는 자연수를 입력해 주세요.");
                }
            }
        }

        //Constructure
        public BoxD(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Area()
        {
            return this.width * this.height;
        }
    }
}
