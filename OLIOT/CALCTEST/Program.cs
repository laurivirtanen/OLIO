using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCTEST
{
    interface ICalculator
    {
        int Add(int number1, int number2);
        int Multiply(int number1, int number2);
        int Divide(int number1, int number2);
        int Subtract(int number1, int number2);
    }

    public class Calculator : ICalculator
    {

        public int Add(int num1,int num2)
        {
            return num1 + num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Divide(int n1,int n2)
        {
            return n1 / n2;
        }
        public int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {



        }
    }
}
