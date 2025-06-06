using GeniusIdiot.Common;

namespace GeniusIdiotConsoleApp
{
    internal class MessageManager : IMessage
    {
        public string Read() => Console.ReadLine();

        public void Write(string message) => Console.WriteLine(message);

        public MessageManager() { }
    }
}
