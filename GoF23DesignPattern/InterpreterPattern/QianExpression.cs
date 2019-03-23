namespace InterpreterPattern
{
    public class QianExpression : Expression
    {

        public override string GetPostfix()
        {
            return "千";
        }

        public override int Multiplier()
        {
            return 1000;
        }
    }
}
