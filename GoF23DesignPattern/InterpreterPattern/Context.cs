namespace InterpreterPattern
{
    public class Context
    {

        private string statement;
        private int data;

        public Context(string statement)
        {
            this.statement = statement;
        }

        public string Statement { get { return statement; } set { statement = value; } }

        public int Data { get { return data; } set { data = value; } }
    }
}
