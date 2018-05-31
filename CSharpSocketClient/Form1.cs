using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace CSharpSocketClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//禁用此异常
        }

        private bool bConnected = false;//客户机与服务器之间的连接状态
        private Thread tAcceptMsg = null;//侦听线程
        private IPEndPoint IPP = null;//用于Socket通信的IP地址和端口
        private Socket socket = null;
        private NetworkStream nStream = null;//网络访问基础数据流
        private TextReader tReader = null;//创建读取器
        private TextWriter tWriter = null;//创建编写器

        private void AcceptMessage()
        {
            string sTemp;
            while (bConnected)
            {
                try
                {
                    sTemp = tReader.ReadLine();
                    if (sTemp.Length!=0)
                    {
                        lock (this)
                        {
                            RichTextBox1.Text = "服务器:" + sTemp + "\n" + RichTextBox1.Text;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("无法与服务器通信!");
                }
            }
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

        private void Btn_Connect_Click(object sender, EventArgs e)//创建与服务器的连接,侦听并显示聊天信息
        {
            try
            {
                IPP = new IPEndPoint(IPAddress.Parse(TextBox_IPAddress.Text), int.Parse(TextBox_PortNum.Text));
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(IPP);
                if (socket.Connected)
                {
                    nStream = new NetworkStream(socket);
                    tReader = new StreamReader(nStream);//读字节流
                    tWriter = new StreamWriter(nStream);//写字节流
                    tAcceptMsg = new Thread(new ThreadStart(this.AcceptMessage));
                    tAcceptMsg.Start();
                    bConnected = true;
                    Btn_Connect.Enabled = false;
                    MessageBox.Show("与服务器成功建立连接可以通信!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("无法与服务器通信!");
            }
        }

        private void RichTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                if (bConnected)
                {
                    try
                    {
                        lock (this)
                        {
                            RichTextBox1.Text = "客户机:" + RichTextBox2.Text + RichTextBox1.Text;
                            tWriter.WriteLine(RichTextBox2.Text);
                            tWriter.Flush();
                            RichTextBox2.Text = "";
                            RichTextBox2.Focus();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("与服务器连接断开!");
                    }
                }
                else
                {
                    MessageBox.Show("未与服务器建立连接,无法与服务器通信!");
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                socket.Close();
                tAcceptMsg.Abort();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
