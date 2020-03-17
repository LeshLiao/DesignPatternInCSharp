using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<OperatorSuperClass> OperList = new List<OperatorSuperClass>();
            OperList.Add(OperationFactory.createOperation("+"));
            OperList.Add(OperationFactory.createOperation("-"));
            OperList.Add(OperationFactory.createOperation("*"));
            OperList.Add(OperationFactory.createOperation("/"));
            foreach(var oper in OperList)
            {
                oper.showExample();
            }
            Console.ReadLine();
        }
    }
    public class OperationFactory
    {
        public static OperatorSuperClass createOperation(string operation)
        {
            OperatorSuperClass oper = null;
            switch (operation)
            {
                case "+":
                    oper = new OperatorAddition();
                    break;
                case "-":
                    oper = new OperatorSubtraction();
                    break;
                case "*":
                    oper = new OperatorMultiplication();
                    break;
                case "/":
                    oper = new OperatorDivision();
                    break;
            }
            return oper;
        }

    }

    public class OperatorSuperClass
    {
        string name { get; set; }
        public virtual void showExample()
        {
            Console.WriteLine("OperatorSuperClass showExample");
        }
    }
    class OperatorAddition : OperatorSuperClass
    {
        public override void showExample()
        {
            Console.WriteLine("One plus one equals two.");
        }
    }
    class OperatorSubtraction : OperatorSuperClass
    {
        public override void showExample()
        {
            Console.WriteLine("Subtract 1 from 2 and you have 1");
        }
    }
    class OperatorMultiplication : OperatorSuperClass
    {
        public override void showExample()
        {
            Console.WriteLine("Two multiplied by two is four.");
        }
    }
    class OperatorDivision : OperatorSuperClass
    {
        public override void showExample()
        {
            Console.WriteLine("Six divided by two is three.");
        }
    }


}
