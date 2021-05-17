using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Property_2
{
    class MyClass
    {
        //일반적인 속성 생성 방법 - 메서드 보다 속성(프로퍼팅)
        private int myField;
        public int MyField
        {
            get
            {
                return myField; 
            }

            set
            {
                myField = value;
            }
        }
    }
}
