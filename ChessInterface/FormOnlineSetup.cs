using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Messaging;

namespace ChessInterface
{
    public partial class FormOnlineSetup : Form
    {
        User currentUser;
        Socket socket;
        EndPoint localEndPoint, remoteEndPoint;
        byte[] buffer;

        public FormOnlineSetup(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private string GetLocalIP()
        {
            IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in hostEntry.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();

            return "127.0.0.1";
        }

        private void ParseIPAndPort(string ipPort, out IPAddress address, out int port)
        {
            var ipMatch = Regex.Match(ipPort, @"([\d]{1,3}.[\d]{1,3}.[\d]{1,3}.[\d]{1,3}):(\d+)");
            if (!ipMatch.Success)
                throw new ArgumentException("Unable to parse IP address or port.", nameof(ipPort));

            if (!IPAddress.TryParse(ipMatch.Groups[1].Value, out address))
                throw new ArgumentException("IP address is invalid.", nameof(ipPort));

            port = Convert.ToInt32(ipMatch.Groups[2].Value);
        }

        private void ButtonCreateMatch_Click(object sender, EventArgs e)
        {
            if (ButtonCreateMatch.Text == "Create match")
            {
                if (string.IsNullOrWhiteSpace(ComboPlayAs.Text))
                {
                    MessageBox.Show("You must select a side to play as.");
                    return;
                }

                IPAddress address;
                int port;

                try
                {
                    ParseIPAndPort(TextOpponentIPandPort.Text, out address, out port);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                if (port < 1024 || port > 49151)
                {
                    MessageBox.Show("Port number must be in the range 1024-49151 inclusive.");
                    return;
                }

                socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

                // Bind the socket to the local client
                localEndPoint = new IPEndPoint(IPAddress.Parse(GetLocalIP()), port);
                socket.Bind(localEndPoint);

                try
                {
                    // Connect to the remote IP
                    remoteEndPoint = new IPEndPoint(address, port);
                    socket.Connect(remoteEndPoint);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                // Select a color to play as 
                if (ComboPlayAs.Text == "Random color")
                    ComboPlayAs.SelectedIndex = (new Random()).Next(2);

                // Send a challenge
                string message = $"CHALLENGE({currentUser.Name},{currentUser.Rating},{currentUser.RatingDeviation},{CheckRatedGame.Checked},{NumTimeControlMins.Value},{NumTimeControlIncrement.Value})";
                byte[] encodedMessage = new byte[100];
                encodedMessage = (new ASCIIEncoding()).GetBytes(message);

                socket.Send(encodedMessage);
                buffer = new byte[100];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref remoteEndPoint, new AsyncCallback(MessageRecievedCallback), buffer);

                ButtonCreateMatch.Text = "Abort match";
                ButtonListenForMatch.Enabled = false;
            }
            else
            {
                // Stop listening for matches
                socket.Close();
                socket.Dispose();
                socket = null;
                ButtonCreateMatch.Text = "Create match";
                ButtonListenForMatch.Enabled = true;
            }
        }

        private void MessageRecievedCallback(IAsyncResult asyncResult)
        {
            byte[] recievedData = new byte[100];
            recievedData = asyncResult.AsyncState as byte[];

            // Convert byte array to string
            string recievedMessage = (new ASCIIEncoding()).GetString(recievedData);

            if (ButtonCreateMatch.Text == "Abort match")
            {

                // Handle the message
                if (recievedMessage.StartsWith("DECLINECHAL"))
                {
                    MessageBox.Show("Challenge declined by opponent.");
                }
                else if (recievedMessage.StartsWith("ACCEPTCHAL"))
                {
                    MessageBox.Show("Challenge accepted.");
                }

                buffer = new byte[100];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref remoteEndPoint, new AsyncCallback(MessageRecievedCallback), buffer);
            }
            else
            {
                // Notify the user of the challenge
                if (recievedMessage.StartsWith("CHALLENGE"))
                {
                    MessageBox.Show(recievedMessage);
                }
                else
                {
                    
                }
            }
        }

        private void FormOnlineSetup_Load(object sender, EventArgs e)
        {
            ComboPlayAs.Text = "Random color";

            TextYourIP.Text = GetLocalIP();
        }
    }
}
