using System.Net.Sockets;

namespace ChatHallaGiz
{
    public partial class Form1 : Form
    {
        public static BinaryReader r;
        public static TcpClient tcpclient;
        public static NetworkStream s;
        public static BinaryWriter w;
        public static string nick;
        //RichTextBox richTextBox;
        private delegate void VisDelegate(string diplayTekst);

        public Form1()
        {
            InitializeComponent();
            //this.richTextBox = richTextBox;
        }
        private void Connect_Click(object sender, EventArgs e)
        {

            tcpclient = new TcpClient();
            tcpclient.Connect("192.168.130.131", 8001);
            s = tcpclient.GetStream();
            w = new BinaryWriter(s);
            r = new BinaryReader(s);
            nick = Username.Text;
            w.Write(nick + " has entered the chatroom");
            





        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            w.Write(nick + ": " + WriteBox.Text + "\n");
            //richTextBox1.AppendText(WriteBox.Text);
            backgroundWorker2.RunWorkerAsync();
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
            //richTextBox.Text = diplayTekst;
        }
        public void TrådTilføjtekst()
        {
            while (s.DataAvailable)
            {
                richTextBox1.AppendText(r.ReadString());
                Thread.Sleep(25);
            }
                    
                    
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var targetMethod1 = new Action(TrådTilføjtekst);
            this.Invoke(targetMethod1);
        }
    }
}