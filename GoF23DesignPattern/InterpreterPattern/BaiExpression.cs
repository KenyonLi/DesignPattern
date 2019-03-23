namespace InterpreterPattern
{
    public class BaiExpression : Expression
    {
        public override string GetPostfix()
        {
            return "百";
        }

        public override int Multiplier()
        {
            return 100;
        }
    }
}
