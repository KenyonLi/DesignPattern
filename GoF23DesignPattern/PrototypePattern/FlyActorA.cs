namespace PrototypePattern
{
    //[Serialize]
    public class FlyActorA : FlyActor
    {
        public override FlyActor Clone()
        {
            return (FlyActorA)this.MemberwiseClone();
        }
    }
}