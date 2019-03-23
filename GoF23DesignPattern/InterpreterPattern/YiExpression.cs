using System;
using System.Collections;

namespace InterpreterPattern
{
    public class YiExpression : Expression
    {
        public override string GetPostfix()
        {
            return "亿";
        }

        public override int Multiplier()
        {
            return 100000000;
        }

        public override void Interpret(Context context)
        {
            ArrayList tree = new ArrayList();
            tree.Add(new GeExpression());
            tree.Add(new ShiExpression());
            tree.Add(new BaiExpression());
            tree.Add(new QianExpression());
            tree.Add(new WanExpression());

            foreach (string key in table.Keys)
            {
                if (!context.Statement.EndsWith(key + this.GetPostfix())) continue;
                int temp = context.Data;
                context.Data = 0;
                context.Statement = context.Statement
                    .Substring(0, context.Statement.Length - 1);
                foreach (Expression expression in tree)
                {
                    expression.Interpret(context);
                }
                context.Data = temp + this.Multiplier() * context.Data;

            }
        }

    }
}
