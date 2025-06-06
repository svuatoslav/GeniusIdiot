using GeniusIdiot.Common;

namespace GeniusIdiotWinFormsApp
{
    internal class MessageManager : IMessage
    {
        internal TextBox TextBox { get; set; }

        public string Read() => TextBox.Text;

        public void Write(string message) => MessageBox.Show(message);

        public void Write<T>(T textBox, string message) where T : TextBox => textBox.Text = message;

        public static string Read(TextBox textBox) => textBox.Text;

        public MessageManager(TextBox textBox) { TextBox = textBox; }
    }
}
