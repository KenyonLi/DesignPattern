using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class CarTestFramework
    {

        public void BuildTestContext(CarFactory carFactory)
        {
            //Car car = new Car();
            //...

            AbstractCar car1 = carFactory.CreateCar();
            AbstractCar car2 = carFactory.CreateCar();
            AbstractCar car4 = carFactory.CreateCar();
        }

        //public void DoTest() {
        //    Car car = new Car();
        //}

        //public TestData GetTestData() {

        //    Car car = new Car();

        //}
    }
}
