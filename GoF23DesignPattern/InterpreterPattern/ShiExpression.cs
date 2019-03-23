﻿namespace InterpreterPattern
{
    public class ShiExpression : Expression
    {

        public override string GetPostfix()
        {
            return "十";
        }

        public override int Multiplier()
        {
            return 10;
        }
    }
}
