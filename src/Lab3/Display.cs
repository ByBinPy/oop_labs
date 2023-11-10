using System;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class Display
{
    public Display(DefaultMessage message/*, Color color*/)
    {
        Message = message;
        /*Color = color;*/
    }

    /*public static DisplayBuilder Builder => new DisplayBuilder();*/
    public static string FilePath { get; } = @"C:\LabaFile\Display\LabaFile";
    public Driver DisplayDriver { get; } = new Driver();
    /*public Color Color { get; }*/
    private DefaultMessage Message { get; set; }
    public bool WriteMessage(DefaultMessage message)
    {
        if (message is
            {
                Head: not null,
                Body: not null,
                Priority: > 0,
            })
        {
            Message = message;
            return true;
        }

        return false;
    }

    public void ShowMessage()
    {
        Driver.Clear();
        Console.WriteLine(MessageData(Message));
        File.WriteAllText(MessageData(Message), FilePath);
        return;

        static string MessageData(IMessage message) => message.Head + "\n" + message.Body + "\n";
    }

    /*
    public class DisplayBuilder
    {
        private DefaultMessage? _message;
        private Color? _color;

        public DisplayBuilder WithColor(Color color)
        {
            _color = color;
            return this;
        }

        public DisplayBuilder WithMessage(DefaultMessage message)
        {
            _message = message;
            return this;
        }

        public Display Build()
        {
            return new Display(
                _message ?? new DefaultMessage(),
                _color ?? new Color(255, 255, 255));
        }
    }*/
}