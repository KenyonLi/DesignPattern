namespace PrototypePattern
{
    public class NormalActorA : NormalActor
    {
        public override NormalActor Clone()
        {
            return (NormalActorA)this.MemberwiseClone();
        }

    }
}