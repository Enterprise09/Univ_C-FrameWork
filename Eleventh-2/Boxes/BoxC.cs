using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Boxes
{
    class BoxC
    {
        //Getter & Setter 사용 - 복잡한 방법
        private int width, height;

        public BoxC(int width, int height)
        {
            if(width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                WriteLine("너비와 높이는 자연수로 초기화 해주세요!");
            }
        }

        public int Area()
        {
            return this.width * this.height;
        }

        public int GetWidth() { return width; }
        public int GetHeight() { return height; }
         
        public void SetWidth(int width)
        {
            if (width > 0)
            {
                this.width = width;
            }
            else
            {
                WriteLine("너비는 자연수를 입력해주세요.");
            }
        }

        public void SetHeight(int height)
        {
            if(height > 0)
            {
                this.height = height;
            }
            else
            {
                WriteLine("높이는 자연수를 입력해주세요.");
            }
        }
    }
}
