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

namespace LTM_TH_KeoBuaBao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte[] data = new byte[1024];
        string input, output;
        IPEndPoint ipep;
        IPEndPoint sender;
        Socket server;
        EndPoint Remote;
        int recv;
        private void Form1_Load(object sender, EventArgs e)
        {
            ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9090);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sender = new IPEndPoint(IPAddress.Any, 0);
            Remote = (EndPoint)sender;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.Close();
        }

        private void btn_bua_Click(object sender, EventArgs e)
        {
            tb_select.Text = "";
            tb_select.Text = "Búa";
            input = btn_bua.Text;
            data = Encoding.UTF8.GetBytes(input);
            server.SendTo(data, data.Length, SocketFlags.None, ipep);
            data = new byte[1024];
            recv = server.ReceiveFrom(data, ref Remote);
            tb_result.Text = Encoding.UTF8.GetString(data, 0, recv);
        }

        private void btn_bao_Click(object sender, EventArgs e)
        {
            tb_select.Text = "";
            tb_select.Text = "Bao";
            input = btn_bao.Text;
            data = Encoding.UTF8.GetBytes(input);
            server.SendTo(data, data.Length, SocketFlags.None, ipep);
            data = new byte[1024];
            recv = server.ReceiveFrom(data, ref Remote);
            tb_result.Text = Encoding.UTF8.GetString(data, 0, recv);
        }

        private void btn_keo_Click(object sender, EventArgs e)
        {
            tb_select.Text = "";
            tb_select.Text = "Kéo";
            input = btn_keo.Text;
            data = Encoding.UTF8.GetBytes(input);
            server.SendTo(data, data.Length, SocketFlags.None, ipep);
            data = new byte[1024];
            recv = server.ReceiveFrom(data, ref Remote);
            tb_result.Text = Encoding.UTF8.GetString(data, 0, recv);
        }
    }
}
