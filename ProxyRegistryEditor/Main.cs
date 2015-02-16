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
using Fiddler;
using System.Threading;
using System.Reflection;

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
            //WriteConsole("Normal TEST", (int)WarningType.Normal);
            //WriteConsole("Warning TEST", (int)WarningType.Important);

            this.MinimumSize = new Size(800, 600);
            LocalIP_Txtbox.Text = GetLocalIP();
            Port_Txtbox.Text = Convert.ToString(Port);
            Proxy_TxtBox.ForeColor = Color.White;
            Proxy_TxtBox.Text = "OFF";
        }

        bool isProxyOpened = false;
        int Port = 6767;
        int Prog = 0;
        private void Proxy_Btn_Click(object sender, EventArgs e)
        {
            if (Prog ==1)
            {
                Restart();
            }else{
                if (isProxyOpened == false)
                {
                    StartProxy();

                }
                else
                {
                    Prog += 1;
                    StopProxy();
                }
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

            
            Fiddler.FiddlerApplication.SetAppDisplayName("Proxy Registry Editor");
            Fiddler.FiddlerApplication.OnNotification += delegate(object sender, NotificationEventArgs oNEA) {
                if (Console_RTB.InvokeRequired)
                {
                    Console_RTB.Invoke((MethodInvoker)delegate()
                    {
                        WriteConsole(oNEA.NotifyString, 0); 
                    });
                }
                else
                {
                    WriteConsole(oNEA.NotifyString, 0); 
                }

            };

            Fiddler.FiddlerApplication.Log.OnLogString += delegate(object sender, LogEventArgs oLEA) {
                if (Console_RTB.InvokeRequired)
                {
                    Console_RTB.Invoke((MethodInvoker)delegate()
                    {
                        WriteConsole(oLEA.LogString, 1);
                    });
                }
                else
                {
                    WriteConsole(oLEA.LogString, 1);
                }

                 
            };

            Fiddler.FiddlerApplication.BeforeRequest += delegate(Fiddler.Session oS)
                
            {
                oS.bBufferResponse = false;
                if (oS.fullUrl.StartsWith("https://wpflights.trafficmanager.net/RestUpdateProvisioningService.svc/UpdateChoices?"))
                {
                    oS.utilCreateResponseAndBypassServer();
                    oS.oResponse.headers.SetStatus(200, "Ok");
                    oS.oResponse["Content-Type"] = "application/xml; charset=utf-8";
                    oS.oResponse["Cache-Control"] = "private, max-age=0";
                    oS.utilSetResponseBody("WPFlights.xml");
                    FiddlerApplication.Log.LogFormat("Sending custom Flighting Response");
                }


            };

            Fiddler.CONFIG.IgnoreServerCertErrors = true;
            FiddlerApplication.Prefs.SetBoolPref("fiddler.network.streaming.abortifclientaborts", true);
            FiddlerCoreStartupFlags oFCSF = FiddlerCoreStartupFlags.DecryptSSL | FiddlerCoreStartupFlags.AllowRemoteClients | FiddlerCoreStartupFlags.ChainToUpstreamGateway | FiddlerCoreStartupFlags.OptimizeThreadPool;
            try
            {
                Fiddler.FiddlerApplication.Startup(Port, oFCSF);
            }
            catch (Exception e)
            {
                WriteConsole(e.Message, 1);
            }
            
            WriteConsole(String.Format("Starting {0} ({1})", Fiddler.FiddlerApplication.GetVersionString(), "NoSAZ"), 0);
            FiddlerApplication.Log.LogFormat("Created endpoint listening on port {0}", Port);
            FiddlerApplication.Log.LogFormat("Starting with settings: [{0}]", oFCSF);
            FiddlerApplication.Log.LogFormat("Gateway: {0}", CONFIG.UpstreamGateway.ToString());


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
            FiddlerApplication.Log.LogFormat("Shutting down. You need to restart the application before restart the proxy", Port);

            Fiddler.FiddlerApplication.OnNotification -= delegate(object sender, NotificationEventArgs oNEA)
            {
                if (Console_RTB.InvokeRequired)
                {
                    Console_RTB.Invoke((MethodInvoker)delegate()
                    {
                        WriteConsole(oNEA.NotifyString, 0);
                    });
                }
                else
                {
                    WriteConsole(oNEA.NotifyString, 0);
                }
            };

            Fiddler.FiddlerApplication.Log.OnLogString -= delegate(object sender, LogEventArgs oLEA)
            {
                if (Console_RTB.InvokeRequired)
                {
                    Console_RTB.Invoke((MethodInvoker)delegate()
                    {
                        WriteConsole(oLEA.LogString, 1);
                    });
                }
                else
                {
                    WriteConsole(oLEA.LogString, 1);
                }
            };

            FiddlerApplication.Shutdown();
            
            Thread.Sleep(100);


            this.Text = "Main Menu | Server Proxy: OFF";
            SrvProxy_LB.Text = "Server Proxy: OFF";
            SrvProxy_LB.ForeColor = Color.Yellow;
            Proxy_Btn.Text = "Restart";
            Proxy_TxtBox.ForeColor = Color.White;
            Proxy_TxtBox.Text = "OFF";
            isProxyOpened = false;
        }
        #endregion

        #region ConsoleService
        public enum WarningType
        {
            LOG = 0,
            STRING = 1
        }

        public void WriteConsole(string Text, int WarnType)
        {

                if (WarnType == (int)WarningType.LOG)
                {
                    Console_RTB.SelectionColor = Color.White;
                    Console_RTB.AppendText("[" + DateTime.Now + "]" + "[LOG] " + Text);
                    Console_RTB.AppendText(Environment.NewLine);
                }
                else if (WarnType == (int)WarningType.STRING)
                {
                    Console_RTB.SelectionColor = Color.Yellow;
                    Console_RTB.AppendText("[" + DateTime.Now + "]" + "[INFO] " + Text);
                    Console_RTB.AppendText(Environment.NewLine);
                }
            }
        
        #endregion

        #region Restart

        public void Restart()
        {
            Application.Restart();

        }

        #endregion
        private void RegHacks_LB_Click(object sender, EventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
