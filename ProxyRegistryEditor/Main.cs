using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyRegistryEditor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(800, 600);
            LocalIP_Txtbox.Text = GetLocalIP();
            Port_Txtbox.Text = Convert.ToString(Port);
            Proxy_TxtBox.ForeColor = Color.White;
            Proxy_TxtBox.Text = "OFF";
        }

        bool isProxyOpened = false;
        int Port = 6767;

        private void Proxy_Btn_Click(object sender, EventArgs e)
        {
            if (isProxyOpened == false)
            {
                StartProxy();

            } 
            else 
            {

                StopProxy();

            }
            
        }

        #region Get Local IP
        private string GetLocalIP()
        {
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }
        #endregion

        #region Proxy
        private void StartProxy()
        {
            this.Text = "Main Menu | Server Proxy: ON";
            SrvProxy_LB.Text = "Server Proxy: ON";
            SrvProxy_LB.ForeColor = Color.LimeGreen;
            Proxy_Btn.Text = "Stop Proxy";
            Proxy_TxtBox.ForeColor = Color.LimeGreen;
            Proxy_TxtBox.Text = "ON";
            isProxyOpened = true;
        }

        private void StopProxy()
        {
            this.Text = "Main Menu | Server Proxy: OFF";
            SrvProxy_LB.Text = "Server Proxy: OFF";
            SrvProxy_LB.ForeColor = Color.Yellow;
            Proxy_Btn.Text = "Start Proxy";
            Proxy_TxtBox.ForeColor = Color.White;
            Proxy_TxtBox.Text = "OFF";
            isProxyOpened = false;
        }
        #endregion

    }
}
