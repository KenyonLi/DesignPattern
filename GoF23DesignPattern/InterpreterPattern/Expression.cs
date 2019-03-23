using System;
using System.Collections.Generic;

namespace InterpreterPattern
{
    public abstract class Expression
    {
        protected Dictionary<string, int> table = new Dictionary<string, int>(9);
        public Expression()
        {

            table.Add("一", 1);
            table.Add("二", 2);
            table.Add("三", 3);
            table.Add("四", 4);
            table.Add("五", 5);
            table.Add("六", 6);
            table.Add("七", 7);
            table.Add("八", 8);
            table.Add("九", 9);
            //table.Add("零", 0);

        }

        public virtual void Interpret(Context context)
        {
            if (context.Statement.Length == 0) return;

            foreach (var key in table.Keys)
            {
                int value = table[key];
                if (context.Statement.EndsWith(key + GetPostfix()))
                {
                    context.Data += value * this.Multiplier();
                    context.Statement = context.Statement.Substring(0, context.Statement.Length - this.GetLength());
                }
                if (context.Statement.EndsWith("零"))
                {
                    context.Statement = context.Statement.Substring(0, context.Statement.Length - 1);
                }
            }
        }

        public abstract string GetPostfix();

        public abstract int Multiplier();

        public virtual int GetLength()
        {
            return this.GetPostfix().Length + 1;
        }

    }
}
