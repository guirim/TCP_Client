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
      public  TcpClient client;
      public  NetworkStream stream;
        StreamReader read;
       // Client clientFormObj = new Client();
        public Client()
        {
            InitializeComponent();

         //   Thread clientForm = new Thread(new ThreadStart(init));
         //   clientForm.Start();
        }

       
        private void init()
        {
          //  Application.Run(clientFormObj);
        }


        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                 client = new TcpClient(txt_serverIP.Text.Trim(), Int32.Parse(txt_port.Text.Trim()));
                 stream = client.GetStream();
                 read = new StreamReader(stream);

               //  client.ReceiveTimeout = 5000;

                

                //수신을 위한 설정 서버에서 보낸 접속 정보를 
              //  IPAddress ipaddress = IPAddress.Parse(txt_serverIP.Text);
              //  TcpListener listener = new TcpListener(ipaddress,Int32.Parse(txt_port.Text.Trim()));
              //  listener.Start();
              //  Socket socketClient = listener.AcceptSocket();
               // listener.AcceptTcpClient();

                 if (stream.DataAvailable)
                 {

                // 수신한 데이터가 있는지 알고자 할때 
               // if(client.ReceiveBufferSize>0)
               // {
                  //  List<byte> receiveData = new List<byte>();
                  //  socketClient.Receive(receiveData.ToArray());

                     List<ArraySegment<byte>> receiveData = new List<ArraySegment<byte>>();
                     byte[] revData = new byte[1024];
                     stream.Read(revData, 0, revData.Length);
                    txt_Full.AppendText("서버 접속시각: " + Encoding.UTF8.GetString(revData) + Environment.NewLine);

              //  }
                 }

                if(client.Connected){
                    txt_Full.AppendText(Environment.NewLine+"서버와 연결 되었습니다 ... "+Environment.NewLine);
                }

              
                
               
            }catch(Exception ex)
            {
                txt_Full.AppendText("에러메세지 : "+ex.Message+Environment.NewLine);
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                if (client.Connected.Equals(true))
                {

                    int a = Encoding.UTF8.GetBytes(txt_message.Text).Length;
                   // string d = Encoding.UTF8.GetString(txt_message.Text);

                    byte[] sendData = new byte[Encoding.UTF8.GetBytes(txt_message.Text).Length];
                    sendData = Encoding.UTF8.GetBytes(txt_message.Text);

                        //  StreamWriter writer = new StreamWriter(stream);

                    /*동기 송신 **/
                        stream.Write(sendData, 0, sendData.Length);
                       // stream.Write(,);


                    /*비 동기 송신**/
                      //  IAsyncResult result = stream.BeginWrite(sendData,0,sendData.Length,new AsyncCallback(WriteCallback),null);
                   
                }
            }
            catch (SocketException se) { txt_Full.AppendText(se.Message + Environment.NewLine); }
        }


        public  void WriteCallback(IAsyncResult asyncResult)
        {
           // Object o =(Object)asyncResult.AsyncState;

            // 구현 필요 
            
        }

        public void WriteCallback(IAsyncResult asyncResult, NetworkStream stream)
        {
            // 구현 필요 
        }



       private void ReadCallback(IAsyncResult asycResult)
        {
            // 선언 필요 
            // 구현 필요 
        }
    }
}
