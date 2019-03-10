using System;
using System.Collections;
using System.Data;
using System.Data.Common;

namespace AdapterPattern
{
    class Program
    {
        /*
            适配（转化）的概念无处不在
                 适配，即在不改原有实现的基础上，将原先不兼容的接口
                 转换为兼容的接口。

            动机（Motivation）
               在软件系统中，由于应用环境的变化，常常需要将“一些现存的对象”
               放在新的环境中应用，但是新的环境要求的接口是这些现存对象不满足的。

               如何应对这种”迁移的变化“？如何既利用现有对象的良好实现，同时又能满足
               新的应用环境所要求的接口？

            意图（Intent）
                将一个类的接口转换为客户希望的另一个接口。
                Adapter模式使得原本由于接口不兼容而不能一起工作的那些类
                可以一起工作。
                                  ——《设计模式》GoF
               =================================================
               Adapter模式的几个要点
                    Adapter模式主要应用于“希望复用一些现存的类，但是接口
                    又与复用环境要求不一致的情况”，在遗留代码复用、类库迁移
                    等方面非常有用。

                   GoF23定义了两种Adapter模式的实现结构：对象适配器和类适配器
                   。但类适配器采用“多继承”的实现方式，带来了不良的高耦合，所以
                   一般不推荐使用。对象适配器采用“对象组合”的方法，更符合松耦合精神。

                   Adapter模式可以实现非常灵活，不必拘泥于GoF23中定义的两种结构。例如，完全可以
                   将Adapter模式中的“现存对象”作为新的接口方法参数，来达到适配的目的。
                      
                    Adapter模式本身要求我们尽可能地使用“面向接口的编程”风格，这样才能在
                    后期很方便地适配。
           ===================================================
            .Net架构中的Adapter应用
               在.net中利用COM对象：
                  -COM对象不符合.Net对象的接口
                  -使用tlbime.exe来创建一个Runtime Callable Wrapper(RCW)
                  以使其符合.Net对象的接口。

               .Net数据库访问类（Adapter变体）：
                   -各种数据库并没有提供DataSet接口
                   -使用DbDataAdapter可以将任何各数据库访问/存取适配到一个DataSet对象上。

               集合类中对现有对象的排序（Adapter变体）：
                   -现有对象未实现IComparable接口
                   -实现一个排序适配器（继承IComparable接口），然后在其Compare方法
                   中对两个对象进行比较。
             */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //
            Employee[] employees = new Employee[100];

            for (int i = 0; i < 100; i++)
            {
                employees[i] = new Employee { Age=i+1,Name=$"ke{i}"+1 };
            }

            Array.Sort(employees, new EmployeeSortAdapter());
        }


        //public class EmployeeDAO {

        //    public DataSet GetAllEmployee() {
        //        DbDataAdapter dataAdapter = new SqlDataAbapter();
        //        DataSet dataSet = new DataSet();
        //        dataAdapter.Fill(dataSet);
        //    }
        //}

        //public class DataSet {
        //    DbDataAdapter dataAdapter;//抽象类
        //    public DataSet(DbDataAdapter dataAdapter) {
        //         this.DataTable=   dataAdapter.Fill();
        //    }

        //    public int DataTable { get; }
        //}


        public class Employee
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }

        public class EmployeeSortAdapter : IComparer
        {
            public int Compare(object x, object y)
             {
                if (x.GetType() != typeof(Employee) ||
                   y.GetType() != typeof(Employee))
                {
                    throw new NotImplementedException();
                }

                Employee el = (Employee)x;
                Employee e2 = (Employee)x;
                if (el.Age == e2.Age)
                {
                    return 0;
                }
                if (el.Age > e2.Age)
                {
                    return 1;
                }
                else if (el.Age > e2.Age)
                {
                    return -1;
                }
                return 0;
            }
        }
    }
}

