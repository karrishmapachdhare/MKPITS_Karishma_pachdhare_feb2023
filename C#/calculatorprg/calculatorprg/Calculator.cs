using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorprg
{
    internal class Calculator
    {

        int prevno;

        char op;
        int result = 0;
        public char plusclick(int prevno)
        {
            this.prevno = prevno;
            op = '+';
            return op;
        }
        public char minusclick(int prevno)
        {
            this.prevno = prevno;
            op = '-';
            return op;
        }
        public char multiple(int prevno)
        {
            this.prevno = prevno;
            op = '*';
            return op;
        }
        public char division(int prevno)
        {
            this.prevno = prevno;
            op =  '÷';
            return op;
        }

        public int calculateresult(int num)
        {
            switch (op)
            {
                case '+':
                    result = prevno + num;
                    break;
                case '-':
                    result = prevno - num;
                    break;
                case '*':
                    result = prevno * num;
                    break;
                case '/':
                    result = prevno / num;
                    break;


            }
            return result;

        }
    }
}
