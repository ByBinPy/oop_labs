namespace Itmo.ObjectOrientedProgramming.Lab3;

public interface IMessage
 {
     string Head { get; }
     string Body { get; }
     uint Priority { get; }
 }