using System;
using System.Collections;

namespace InterpreterPattern
{
    /*
     
         动机（Motivation）

            在软件构建过程中，如果某一特定领域的问题比较复杂，类似的模式
            不断重复出现，如果使用普通的编程方式来实现将面临非常频繁的变化。

            在这种情况下，将特定领域的问题表达为某种语法规则下的句子，然后构建
            一个解释器来解释这样的句子，从而达到解决问题的目的。
         =======================================================
         Interpreter模式的几个要点
              Interpreter模式的应用场合是Interpreter模式应用中的难点，
              只有满足“业务规则频繁变化，且类似的模式不断得利出现，并且容易
              抽象为语法规则的问题”才适合使用Interpreter模式。

              使用Interpreter模式来表示文法规则，从而可以使用面向对象技巧来方便地“
               扩展”方法。
              
                Interpreter模式比较适合简单的文法表示，对于复杂的文法表示，Interpeter
                模式会产生比较大的类层次结构，需要求助于语法分析生成器这样的标准工具。
         
         */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("解释器模式");

            //string roman = "四万六千四百五十二";//46452
            //string roman = "六千零五十二";//46452
            //string roman = "五十二";//46452
            //(((i*j)+(k/l))-m)==>((ij+kl)-m)==>(ijkl-m)
            string roman = "一亿四千三百零九万六千四百五十二";//46452

            Context context = new Context(roman);
            ArrayList tree = new ArrayList();
            tree.Add(new GeExpression());
            tree.Add(new ShiExpression());
            tree.Add(new BaiExpression());
            tree.Add(new QianExpression());
            tree.Add(new WanExpression());
            tree.Add(new YiExpression());

            foreach (Expression expression in tree)
            {
                expression.Interpret(context);
            }

            Console.WriteLine($"{roman}={context.Data}");
            Console.ReadKey();
        }
    }
}
