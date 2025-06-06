namespace GeniusIdiot.Common
{
    public interface IMessage
    {
        public void Write(string message);
        public string Read();
    }
}
