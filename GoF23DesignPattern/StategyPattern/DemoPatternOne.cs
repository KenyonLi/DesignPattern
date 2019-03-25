using System.Drawing;

namespace StategyPattern.DemoPatternOne
{


    public enum CartType
    {
        A, B, C

    }

    public interface IProcessStrategy //表达算法抽象
    {
        void Process();
    }

    public class ProcessStrategyA : IProcessStrategy
    {
        public void Process()
        {

        }
    }
    public class ProcessStrategyB : IProcessStrategy
    {
        public void Process()
        {
        }
    }
    public class ProcessStrategyC : IProcessStrategy
    {
        public void Process()
        {

        }
    }


    public class Cart
    {
        IProcessStrategy processStrategy;//对象组合

        public Cart(IProcessStrategy processStrategy)
        {
            this.processStrategy = processStrategy;
        }

        public void Somemethod()
        {
            //...
            processStrategy.Process();
        }


    }


}


