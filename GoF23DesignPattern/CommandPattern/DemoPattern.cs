using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.DemoPattern
{
    //已经存在的
    public class Document
    {
        public void ShowText() { }
    }

    public class Graphics
    {
        public void ShowGraphics() { }
    }

    //实现command设计模式
    public interface ICommand
    {
        void Show();
        void Undo();
        void Redo();
    }
    //具体化的命令对象一从抽象意义来讲，DocumentCommand表示一个行
    public class DocumentCommand : ICommand
    {
        Document document;
        public DocumentCommand(Document doc)
        {
            this.document = doc;
        }
        public void Redo()
        {
            document.ShowText();
        }

        public void Show()
        {
            throw new NotImplementedException();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }

    //具体化的命令对象一从抽象意义来讲，GraphicsCommand表示一个行
    public class GraphicsCommand : ICommand
    {
        Graphics graphics;
        public GraphicsCommand(Graphics graphics)
        {
            this.graphics = graphics;
        }
        public void Redo()
        {
            graphics.ShowGraphics();
        }

        public void Show()
        {
            throw new NotImplementedException();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
