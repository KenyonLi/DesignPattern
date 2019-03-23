using System;

namespace MediatorPattern
{
    /*
        C#面向对象设计模式纵横谈
         
        依赖关系的转化




   动机（Motivation）
        在软件构建过程中，经常会出现多个对象互相关联交互的情况，
        对象之间 常常会维持一种复杂的引用关系，如果遇到一些需求
        的更改 这种直接的引用 关系将面临不断的变化。


        在这种情况下，我们可使用一个“中介对象”来管理对象间关联关系，
        避免相互交互的对象
        之间的紧耦合引用关系，从而更好地抵御变化。

    意图（Intent）
      
        用一个中介对象来封装一系列的对象交互。中介者使各个对象不需要显式
       的相互引用，从而使其耦合松散，而且可以独立地改变它们之间的交互。
                                ——《设计模式》GoF
  ========================================================
   Mediator模式的几个要点
       将多个对象间复杂的关联关系解耦，Mediator模式
       将多个对象间的控制逻辑进行集中管理，变“多个对象互相关联为多个对象
       和一个中介者关联”，简化了系统的维护，抵御了可能的变化。

        随着控制逻辑的复杂化，Mediator具体对象的实现可能相当复杂。这时候可以
        对Mediator对象进行分解处理。

        Facade模式是解耦系统外到系统内（单向）的对象关联关系，Mediator模式是
        解耦系统内各个对象之间（双向）的关联关系。

      */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("中介者模式");
        }
    }

    public class CutMenuTime
    {
        TextArea textArea;
        ClipBorad clipBorad;
        ToolarButton toolarButton;
        public void Cilck()
        {
            string text = textArea.SelectedText();
            textArea.RemoveSelectionText();
            clipBorad.SetData(text);
            toolarButton.BnabledPasteButton(true);
        }

    }

    public class TextArea
    {
        TextArea textArea;
        ClipBorad clipBorad;
        ToolarButton toolarButton;

        public void Proccess()
        {

        }
        internal void RemoveSelectionText()
        {
            throw new NotImplementedException();
        }

        internal string SelectedText()
        {
            throw new NotImplementedException();
        }
    }

    class ClipBorad
    {
        TextArea textArea;
        ClipBorad clipBorad;
        ToolarButton toolarButton;
        internal void SetData(string text)
        {
            throw new NotImplementedException();
        }
    }

    public class ToolarButton
    {
        TextArea textArea;
        ClipBorad clipBorad;
        ToolarButton toolarButton;
        internal void BnabledPasteButton(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
