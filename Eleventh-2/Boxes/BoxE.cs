using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class BoxE
    {
        //변수 선언
        //필드에 할당되지 않음으로 항상 0값을 사용합니다. 오류남
        private int width;
        private int height;

        //Create Property 
        //Auto Create
        public int Width
        {
            get;
            set;
        }

        //속성 생성
        public int Height
        {
            get;
            set;
        }

        //Constructure
        public BoxE(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Area()
        {
            return this.width * this.height;
        }
    }
}
