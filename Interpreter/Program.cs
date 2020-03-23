using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            display("MM DD YYYY");
            display("YYYY MM DD");
            display("DD MM YYYY");
            Console.Read();
        }
        
        public static void display(string myformate)
        {
            List<AbstractExpression> objExpressions = new List<AbstractExpression>();
            Context context = new Context(DateTime.Now);

            context.expression = myformate;
            Console.WriteLine("Fromate:" + context.expression);

            string[] strArray = context.expression.Split(' ');
            foreach (var item in strArray)
            {
                if (item == "DD")
                {
                    objExpressions.Add(new DayExpression());
                }
                else if (item == "MM")
                {
                    objExpressions.Add(new MonthExpression());
                }
                else if (item == "YYYY")
                {
                    objExpressions.Add(new YearExpression());
                }
            }
            objExpressions.Add(new SeparatorExpression());
            foreach (var obj in objExpressions)
            {
                obj.Evaluate(context);
            }
            Console.WriteLine(context.expression);

        }
    }
}
