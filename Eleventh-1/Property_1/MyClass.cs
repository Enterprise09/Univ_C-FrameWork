using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Property_1
{
    class MyClass
    {
        //int 형식 myField를 private 로 갖고 있는 클래스
        private int myField;

        public int GetMyField() { return myField; }
        public void SetMyField(int NewValue) { myField = NewValue; }

    }
}
