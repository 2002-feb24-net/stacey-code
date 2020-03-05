using System;
public class Message
{
    string statement = "Good Morning";
    public void WriteMessage()
    {
        Console.WriteLine(statement);
    }
    public void WriteMessage(string message)
    {
        Console.WriteLine(message);
    }
}