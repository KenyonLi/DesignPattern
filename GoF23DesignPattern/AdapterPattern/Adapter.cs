namespace AdapterPattern
{
    public class Adapter : ITarget
    {
        ExistingClass existingClass;
        public void Request()
        {
            existingClass = new ExistingClass();
        }
    }
}
