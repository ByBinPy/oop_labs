namespace Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

public interface IMessage
 {
     string Head { get; }
     string Body { get; }
     uint Priority { get; }
 }