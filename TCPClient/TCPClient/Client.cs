using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Net;

namespace TCPClient
{
    public partial class Client : Form
    {
      public  Socket client;
        public Client()
        {
            InitializeComponent();
        }

       
      
        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                /*************************************   2014.04.22  ***********************************/
                client = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(txt_serverIP.Text.Trim()), Int32.Parse(txt_port.Text.Trim()));

                SocketAsyncEventArgs socketAsyncEventargs = new SocketAsyncEventArgs();
                socketAsyncEventargs.RemoteEndPoint = ipep;
                client.ConnectAsync(socketAsyncEventargs);

            }catch(Exception ex)
            {
                txt_Full.AppendText("에러메세지 : "+ex.Message+Environment.NewLine);
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {             
                if(client.Connected){
                SocketAsyncEventArgs args = new SocketAsyncEventArgs();

                    byte[] szData = Encoding.Unicode.GetBytes(txt_message.Text);
                    args.DisconnectReuseSocket=true;
                    args.SetBuffer(szData,0,szData.Length);
                    client.SendAsync(args);
                }
              

            }
            catch (Exception se) { txt_Full.AppendText(se.Message + Environment.NewLine); }
        }

    }
}
