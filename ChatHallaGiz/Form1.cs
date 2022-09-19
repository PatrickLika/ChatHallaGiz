using System.Net.Sockets;

namespace ChatHallaGiz
{
    public partial class Form1 : Form
    {
        static BinaryReader r = new BinaryReader(s);
        static TcpClient tcpclient = new TcpClient();
        static NetworkStream s = tcpclient.GetStream();
        static BinaryWriter w = new BinaryWriter(s);
        static string nick;
        RichTextBox richTextBox;
        private delegate void VisDelegate(string diplayTekst);

        public Form1()
        {
            InitializeComponent();
            this.richTextBox = richTextBox;
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            tcpclient.Connect("127.0.0.1", 8001);
            nick = Username.Text + ": ";

        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            w.Write(nick + WriteBox.Text + "\n");
        }

        private void ChatName_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WriteBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void DisplayTexten(string diplayTekst)
        {
            richTextBox.Text = diplayTekst;
        }
        public void TrådTilføjtekst()
        {

            while (true)
            {
                if (s.DataAvailable)
                {
                    richTextBox1.AppendText(r.ReadString());
                }

                Thread.Sleep(1000);
                RichTextBox.Invoke(new VisDelegate(DisplayTexten), new object[] { richTextBox.Text });

            }

        }
    }
}