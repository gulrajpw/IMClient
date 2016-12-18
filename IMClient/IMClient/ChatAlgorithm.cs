using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalVariables;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace IMClient
{
   
  
public partial class ChatAlgorithm : Form
    {
        public String GLBmessage;
        



        //Run this in its own thread. in order to recieve messages at all times.
        private void listener()
        {
            TcpListener tcpListener = null;

            System.Net.IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
           
            try
            {
                // Set the listener on the local IP address 
                // and specify the port.
                tcpListener = new TcpListener(ipAddress, 9121);
                tcpListener.Start();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops, something went wrong \n");
                Console.WriteLine(e.Message);
            }

            while(true)
            {
                Thread.Sleep(10);
                TcpClient tcpClient = tcpListener.AcceptTcpClient();

              
                byte[] bytes = new byte[256];
                NetworkStream stream = tcpClient.GetStream();
                stream.Read(bytes, 0, bytes.Length);
                // String msg = new StreamReader(stream).ReadToEnd();
                String msg = System.Text.Encoding.UTF8.GetString(bytes, 0, bytes.Length); //Convert byte array to string
                InvokeChatbox(msg); //safely append the chatbox.

            }

        }



        private void InvokeChatbox(String msg)
        {
            if (chatBox.InvokeRequired)
            {
                chatBox.Invoke(new MethodInvoker(() =>
                {
                    chatBox.Text += "\r\n FROM SERVER: ";
                    chatBox.Text += msg;
                }));

            }
        }



        public ChatAlgorithm()
        {

            InitializeComponent();
            Thread listenForMessage = new Thread(new ThreadStart(listener));
            listenForMessage.Start();
   
        }



     

        //Send the message over a TCP connection to the other user.
        private void send_message()
        {
            display_message(); //prints the message to the screen of the client.


            Socket soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            System.Net.IPAddress ipAdd = System.Net.IPAddress.Parse("127.0.0.1");
            System.Net.IPEndPoint remoteEP = new IPEndPoint(ipAdd, 9121);
            soc.Connect(remoteEP);

            //Send data:
            byte[] byData = System.Text.Encoding.ASCII.GetBytes(GLBmessage);
            soc.Send(byData);

        }



        
        private void display_message()
        {
            //Displays written text from the client to the message box.
            String message = GlobalVariables.Global.ShowUserName() + ": " + typeBox.Text + "\n";
            GLBmessage = message;
            //take the message and append it to the chatbox.
            
            chatBox.Text += "\r\n" + message; 
            typeBox.Clear();


        }




        private void button3_Click(object sender, EventArgs e)
        {
            send_message();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.Show();
            
            
        }
    }

   




}
