using System.Net.Sockets;

namespace ChatHallaGiz
{
    public partial class Form1 : Form
    {
        private TraadKlasse t1;
        public static BinaryReader r;
        public static TcpClient tcpclient;
        public static NetworkStream s;
        public static BinaryWriter w;
        public static string nick;


        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //t1 = new TraadKlasse(richTextBox1);
            //Thread firstThread = new Thread(new ThreadStart(t1.TraadVisTekst)) { IsBackground = true };
            //firstThread.Start();
        }


        private void Connect_Click(object sender, EventArgs e)
        {

            tcpclient = new TcpClient();
            tcpclient.Connect("192.168.233.1", 8001);
            s = tcpclient.GetStream();
            w = new BinaryWriter(s);
            r = new BinaryReader(s);
            nick = Username.Text;
            w.Write(nick + " has entered the chatroom");

            t1 = new TraadKlasse(richTextBox1);
            Thread firstThread = new Thread(new ThreadStart(t1.TraadVisTekst)) { IsBackground = true };
            firstThread.Start();

        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            w.Write(nick + ": " + WriteBox.Text + "\n");
            backgroundWorker2.RunWorkerAsync();
            WriteBox.Clear();

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

        public class TraadKlasse
        {
            RichTextBox RichTextBox;
            public TraadKlasse(RichTextBox richTextBox)
            {
                this.RichTextBox = richTextBox;
            }
            private delegate void DisplayDelegate(string displayText);

            private void DisplayTexten(string displayText)
            {
                RichTextBox.Text = displayText;
            }

            public void TraadVisTekst()
            {
                string append = "";
                string display = "";

                while (true)
                {
                    append = r.ReadString();
                    display = display + append;
                    Thread.Sleep(100);
                    RichTextBox.Invoke(new DisplayDelegate(DisplayTexten), new object[] { display });
                }
            }

        }

    }
}