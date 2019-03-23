using System;
using System.Collections;

namespace InterpreterPattern
{
    public class WanExpression : Expression
    {
        public override string GetPostfix()
        {
            return "万";
        }

        public override void Interpret(Context context)
        {
            ArrayList tree = new ArrayList();
            tree.Add(new GeExpression());
            tree.Add(new ShiExpression());
            tree.Add(new BaiExpression());
            tree.Add(new QianExpression());

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

        public override int Multiplier()
        {
            return 10000;
        }
    }
}
