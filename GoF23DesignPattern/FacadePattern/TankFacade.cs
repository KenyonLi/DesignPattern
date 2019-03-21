namespace FacadePattern
{
    public class TankFacade
    {
        Wheel[] wheels = new Wheel[4];
        Engine[] engines = new Engine[4];
        Bodyword bodyword = new Bodyword();
        Controller controller = new Controller();

        public void Start() {
        }
        public void Stop() { }
        public void Run() { }
        public void Shot() { }
    }
}
