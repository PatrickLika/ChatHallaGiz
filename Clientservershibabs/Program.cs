using System.Net.Sockets;
using System.Net;

public class Serv
{
    public static Dictionary<string, ClientHandler> clientHandlers = new Dictionary<string, ClientHandler>();
    public static void Main()
    {
        try
        {
            //IPAddress ipAd = IPAddress.Parse("127.0.0.1"); //localhost IP address, 
            TcpListener myList = new TcpListener(IPAddress.Any, 8001); //and use the same at
            myList.Start();                                //the client side
            Console.WriteLine("The local End point is  :" + myList.LocalEndpoint);
            while (true)
            {
                Console.WriteLine("Waiting for a new connection.....");
                Socket s = myList.AcceptSocket();
                ClientHandler ch = new ClientHandler(s);
                lock (clientHandlers)
                {
                    NetworkStream socketStream = new NetworkStream(s);
                    BinaryReader reader = new BinaryReader(socketStream);
                    string txt = reader.ReadString(); // get nickname
                    string nick = txt.Substring(0, 10);
                    Console.WriteLine("New user has entered the chatroom, nickname: " + nick);
                    clientHandlers[nick] = ch;
                }
                Thread t = new Thread(new ThreadStart(ch.HandleClient));
                t.Start();
            }
            //   myList.Stop();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error..... " + e.StackTrace);
        }
    }
}

public class ClientHandler
{
    private Socket s;
    private NetworkStream socketStream;
    public BinaryWriter writer;
    private BinaryReader reader;

    public ClientHandler(Socket s)
    {
        this.s = s;
        socketStream = new NetworkStream(s);
        writer = new BinaryWriter(socketStream);
        reader = new BinaryReader(socketStream);
    }

    public void HandleClient()
    {
        Console.WriteLine("Connection accepted from " + s.RemoteEndPoint);
        string txt = "retur ";
        while (true)
        {
            try
            {
                txt = reader.ReadString(); // NICK: MSG
                Console.WriteLine(txt); // echo on server
                string nick = txt.Substring(0, 10);
                //lock (Serv.clientHandlers)

                //if (nick != "ALLE") // protocol !                    
                //    Serv.clientHandlers[nick].writer.Write("TO ONE: " + txt);
                //else if (nick == "ALLE") // protocol !
                foreach (var pair in Serv.clientHandlers)
                    pair.Value.writer.Write(txt);

            }
            catch (Exception e) { } // dont bring me down
        }
    }
}