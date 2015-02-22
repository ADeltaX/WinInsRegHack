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
using System.Security.Cryptography.X509Certificates;

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
            this.Text = "Main Menu | " + Version + " | Port: " + Port + " | Server Proxy: OFF";
            this.MinimumSize = new Size(800, 600);
            LocalIP_Txtbox.Text = GetLocalIP();
            Port_Txtbox.Text = Convert.ToString(Port);
            Proxy_TxtBox.ForeColor = Color.White;
            Proxy_TxtBox.Text = "OFF";
            CreatedBy_LB.Text += "ADeltaX";
            Version_LB.Text += Version;
        }

        string ToHex(int value)
        {
            const int decimalconstant = 8;
            int lengthofvalue = 0;
            int differentvalue = 0;
            string whatthehell = "";
            string hexvalue = value.ToString("X");
            lengthofvalue = hexvalue.Length;
            differentvalue = decimalconstant - lengthofvalue;
            int x = 0;
            while ( x < differentvalue)
            {
                whatthehell += "0"; 
                x++;
            }
            return String.Format("0x"+ whatthehell + "{0:X}", value);
        }
        bool CustCertificate = false;
        bool isProxyOpened = false;
        int Port = 6767;
        int Prog = 0;
        string WPFlight;
        string StartString;
        string KeysToAdd;
        string KeysToDelete;
        string EndingString;
        string Version = "Beta 0.76";

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
            //string path = "C:\\Users\\ADeltaX\\Documents\\Visual Studio 2013\\Projects\\ProxyRegistryEditor\\ProxyRegistryEditor\\bin\\Debug\\Certificate\\wpflights.trafficmanager.net.cer";
            //Fiddler.FiddlerApplication.oDefaultClientCertificate = new X509Certificate(path);

            Fiddler.FiddlerApplication.BeforeRequest += delegate(Fiddler.Session oS)
                
            {
                oS.bBufferResponse = false;
                if (oS.fullUrl.StartsWith("https://wpflights.trafficmanager.net/RestUpdateProvisioningService.svc/UpdateChoices?"))
                {
                    oS.utilCreateResponseAndBypassServer();
                    
                    oS.oResponse.headers.SetStatus(200, "Ok");

                    //oS.oResponse["https-Client-Certificate"] = path;
                    oS.utilDecodeResponse(true);
                    FiddlerApplication.Log.LogFormat("Injecting certificate");
                    oS.oResponse["Content-Type"] = "application/xml; charset=utf-8";
                    oS.oResponse["Cache-Control"] = "private, max-age=0";
                    StartString = WPFlightsInit_TB.Text;
                    EndingString = EndingString_TB.Text;
                    KeysToAdd = KeysToAdd_TB.Text;
                    KeysToDelete = KeysToDelete_TB.Text;
                    
                    WPFlight = StartString + "<KeysToAdd>" + KeysToAdd + "</KeysToAdd>" + "<KeysToDelete>" + KeysToDelete + "</KeysToDelete>" + EndingString;
                    oS.utilSetResponseBody(WPFlight);
                    FiddlerApplication.Log.LogFormat("Sending custom Flighting Response");
                }


            };

            Fiddler.CONFIG.IgnoreServerCertErrors = false;
            FiddlerApplication.Prefs.SetBoolPref("fiddler.network.streaming.abortifclientaborts", true);
            FiddlerCoreStartupFlags oFCSF = FiddlerCoreStartupFlags.DecryptSSL | FiddlerCoreStartupFlags.AllowRemoteClients | FiddlerCoreStartupFlags.ChainToUpstreamGateway | FiddlerCoreStartupFlags.OptimizeThreadPool;
            try
            {
                Fiddler.FiddlerApplication.Startup(Port, oFCSF);
            }
            catch (Exception e)
            {
                WriteConsole(e.Message, 1);
                return;
            }
            
            WriteConsole(String.Format("Starting {0} ({1})", Fiddler.FiddlerApplication.GetVersionString(), "NoSAZ"), 0);
            FiddlerApplication.Log.LogFormat("Created endpoint listening on port {0}", Port);
            FiddlerApplication.Log.LogFormat("Starting with settings: [{0}]", oFCSF);
            FiddlerApplication.Log.LogFormat("Gateway: {0}", CONFIG.UpstreamGateway.ToString());


            this.Text = "Main Menu | " + Version + " | Port: " + Port + " | Server Proxy: ON";
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


            this.Text = "Main Menu | " + Version + " | Port: " + Port + " | Server Proxy: OFF";
            SrvProxy_LB.Text = "Server Proxy: OFF";
            SrvProxy_LB.ForeColor = Color.White;
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

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #region GUISettings
        private void SelectedMenuLabel()
        {
            InfoProxy_LB.ForeColor = Color.DimGray;
            RegHacks_LB.ForeColor = Color.DimGray;
            CustRegHacks_LB.ForeColor = Color.DimGray;
            Settings_LB.ForeColor = Color.DimGray;
            Info_LB.ForeColor = Color.DimGray;
        }
        private void Info_LB_Click(object sender, EventArgs e)
        {
            SelectedMenuLabel();
            Info_LB.ForeColor = Color.White;
            Info_Panel.Show();
            Settings_Panel.Hide();
            CustRegHacks_Panel.Hide();
            RegistryHacks_Panel.Hide();
            InfoProxy_Panel.Hide();
            SelectedLabel_LB.Location = new Point(709, SelectedLabel_LB.Location.Y);
            SelectedLabel_LB.Size = new Size(39, 3);
        }
        private void Settings_LB_Click(object sender, EventArgs e)

        {
            SelectedMenuLabel();
            Settings_LB.ForeColor = Color.White;
            Settings_Panel.Show();
            Info_Panel.Hide();
            CustRegHacks_Panel.Hide();
            RegistryHacks_Panel.Hide();
            InfoProxy_Panel.Hide();
            SelectedLabel_LB.Location = new Point(587, SelectedLabel_LB.Location.Y);
            SelectedLabel_LB.Size = new Size(75, 3);
        }

        private void CustRegHacks_LB_Click(object sender, EventArgs e)
        {
            SelectedMenuLabel();
            CustRegHacks_LB.ForeColor = Color.White;
            CustRegHacks_Panel.Show();
            Info_Panel.Hide();
            RegistryHacks_Panel.Hide();
            InfoProxy_Panel.Hide();
            Settings_Panel.Hide();
            SelectedLabel_LB.Location = new Point(340, SelectedLabel_LB.Location.Y);
            SelectedLabel_LB.Size = new Size(200, 3);
        }
        private void RegHacks_LB_Click(object sender, EventArgs e)
        {
            SelectedMenuLabel();
            RegHacks_LB.ForeColor = Color.White;
            RegistryHacks_Panel.Show();
            Info_Panel.Hide();
            CustRegHacks_Panel.Hide();
            InfoProxy_Panel.Hide();
            Settings_Panel.Hide();
            SelectedLabel_LB.Location = new Point(160, SelectedLabel_LB.Location.Y);
            SelectedLabel_LB.Size = new Size(128, 3);
        }

        private void InfoProxy_LB_Click(object sender, EventArgs e)
        {
            SelectedMenuLabel();
            InfoProxy_LB.ForeColor = Color.White;
            InfoProxy_Panel.Show();
            Info_Panel.Hide();
            RegistryHacks_Panel.Hide();
            CustRegHacks_Panel.Hide();
            Settings_Panel.Hide();
            SelectedLabel_LB.Location = new Point(25, SelectedLabel_LB.Location.Y);
            SelectedLabel_LB.Size = new Size(93, 3);
        }

        #endregion

        private void MTPFolder_CB_CheckedChanged(object sender, EventArgs e)
        {
            if (MTPFolder_CB.Checked)
            {
                MTPFolder_TB.Enabled = true;
            }
            else { MTPFolder_TB.Enabled = false; }
        }

        private void EnableCustCert_CB_CheckedChanged(object sender, EventArgs e)
        {
            CustCertificate = true;
        }

        private void ApplyHacks_Btn_Click(object sender, EventArgs e)
        {
            KeysToAdd_TB.Clear();
            KeysToDelete_TB.Clear();
            if (MTPFolder_CB.Checked)
            {
                KeysToAdd_TB.Text += RegistryStringCreator("Software\\Microsoft\\MTP", "DataStore", MTPFolder_TB.Text, 1);
            }
            if (PfD_CB.Checked)
            {
                if (PfDEnable_RB.Checked)
                {
                    KeysToAdd_TB.Text += RegistryStringCreator("System\\Platform\\DeviceTargetingInfo", "DevOSPreviewEnable", "0x00000001", 4);
                }
                else
                {
                    KeysToAdd_TB.Text += RegistryStringCreator("System\\Platform\\DeviceTargetingInfo", "DevOSPreviewEnable", "0x00000000", 4);
                }
            }
            if (Aboutmoz_CB.Checked)
            {
                if (AboutmozEnable_RB.Checked)
                {
                    KeysToAdd_TB.Text += RegistryStringCreator("Software\\Microsoft\\Internet Explorer\\Abouturls", "moz", "res://mshtml.dll/about.moz", 1);
                }
                else
                {
                    KeysToDelete_TB.Text += RegistryStringCreator("Software\\Microsoft\\Internet Explorer\\Abouturls", "moz", "res://mshtml.dll/about.moz", 1);
                }
            }
            if (HideAPN_CB.Checked)
            {
                if (HideAPNYes_RB.Checked)
                {
                    KeysToAdd_TB.Text += RegistryStringCreator("Software\\Microsoft\\Cellular\\MVSettings\\IMSISpecific\\Default\\CellUX", "HideMMSAPN", "0x00000001", 4);
                    KeysToAdd_TB.Text += RegistryStringCreator("Software\\Microsoft\\Cellular\\MVSettings\\IMSISpecific\\Default\\CellUX", "HideAPN", "0x00000001", 4);
                }
                else
                {
                    KeysToAdd_TB.Text += RegistryStringCreator("Software\\Microsoft\\Cellular\\MVSettings\\IMSISpecific\\Default\\CellUX", "HideMMSAPN", "0x00000000", 4);
                    KeysToAdd_TB.Text += RegistryStringCreator("Software\\Microsoft\\Cellular\\MVSettings\\IMSISpecific\\Default\\CellUX", "HideAPN", "0x00000000", 4);
                }
            }

            if (Neverlock_CB.Checked)
            {
                if (NeverlockEnable_RB.Checked)
                {
                    KeysToAdd_TB.Text += RegistryStringCreator("Software\\Microsoft\\Settings\\Lock", "DisableNever", "0x00000001", 4);
                }
                else
                {
                    KeysToAdd_TB.Text += RegistryStringCreator("Software\\Microsoft\\Settings\\Lock", "DisableNever", "0x00000000", 4);
                }
            }

            if (MaxSystemUIVolume_LB.Checked)
            {
                KeysToAdd_TB.Text += RegistryStringCreator("Software\\Microsoft\\Settings\\Volume", "MaxSystemUIVolume", ToHex(Convert.ToInt32(MSUV_Nup.Value)), 4);  
            }
            if (MaxInCallUIVolume_CB.Checked)
            {
                KeysToAdd_TB.Text += RegistryStringCreator("Software\\Microsoft\\Settings\\Volume", "MaxInCallUIVolume", ToHex(Convert.ToInt32(MICUV_Nup.Value)), 4);  
            }
            if (UserPreferenceWidth_CB.Checked)
            {
                if (SmallWidth_RB.Checked)
                {
                    KeysToAdd_TB.Text += RegistryStringCreator("Software\\Microsoft\\Windows\\CurrentVersion\\Control Panel\\Theme", "UserPreferenceWidth", "0x0000003B", 4); //59
                }
                else if (MediumWidth_RB.Checked)
                {
                    KeysToAdd_TB.Text += RegistryStringCreator("Software\\Microsoft\\Windows\\CurrentVersion\\Control Panel\\Theme", "UserPreferenceWidth", "0x00000040", 4); //64
                }
                else if (LargeWidth_RB.Checked)
                {
                    KeysToAdd_TB.Text += RegistryStringCreator("Software\\Microsoft\\Windows\\CurrentVersion\\Control Panel\\Theme", "UserPreferenceWidth", "0x0000004B", 4); //75
                }
            }
        }

        private void AddKey_Btn_Click(object sender, EventArgs e)
        {

            string ToValueString = "";
            ToValueString = RegistryKeyValue_TB.Text;
            if (RegistryKeyPath_TB.Text == "" | RegistryKeyValue_TB.Text == "" | RegistryKeyName_TB.Text == "")
            {
                MessageBox.Show("Please fill all text box");
            }
            else
            {
                if (IntegerType_RB.Checked)
                {

                    if (isNumeric(ToValueString))
                    {
                        ToValueString = ToHex(Convert.ToInt32(RegistryKeyValue_TB.Text));
                    }
                    if (isOnlyHex(ToValueString) == false)
                    {
                        MessageBox.Show("The entered value is not valid");
                        return;
                    }
                }
                if (KeysToAddCustHacks_RTB.Text != "")
                {
                    KeysToAddCustHacks_RTB.Text += Environment.NewLine;
                }
                KeysToAddCustHacks_RTB.Text += RegistryStringCreator(RegistryKeyPath_TB.Text, RegistryKeyName_TB.Text, ToValueString, ValueTypeSet());
                RegistryKeyValue_TB.Text = ToValueString;
            }
        }

        private void RemoveKey_Btn_Click(object sender, EventArgs e)
        {
            string ToValueString = "";
            ToValueString = RegistryKeyValue_TB.Text;
            if (RegistryKeyPath_TB.Text == "" | RegistryKeyName_TB.Text == "")
            {
                MessageBox.Show("Please fill all text box");
            }
            else
            {
                

                if (KeysToDeleteCustHacks_RTB.Text != "")
                {
                    KeysToDeleteCustHacks_RTB.Text += Environment.NewLine;
                }
                
                KeysToDeleteCustHacks_RTB.Text += RegistryStringCreator(RegistryKeyPath_TB.Text, RegistryKeyName_TB.Text, ToValueString, ValueTypeSet());
                RegistryKeyValue_TB.Text = ToValueString;
            }
        }
        public bool isNumeric(string parsingString)
        {
            int num;
            bool BoolNumeric = int.TryParse(parsingString, out num);
            return BoolNumeric;
        }

        public bool isOnlyHex(string test)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(test, @"\A\b(0[xX])?[0-9a-fA-F]+\b\Z");
        }

        public int ValueTypeSet()
        {
            int ValueTypeInt = 0;

            if (StringType_RB.Checked)
            {
                ValueTypeInt = 1;

            }
            else if (VariableStringType_RB.Checked)
            {
                ValueTypeInt = 2;
            }
            else if (BinaryType_RB.Checked)
            {
                ValueTypeInt = 3;
            }
            else if (IntegerType_RB.Checked)
            {
                ValueTypeInt = 4;
            }
            else if (IntegerBigEndianType_RB.Checked)
            {
                ValueTypeInt = 5;
            }
            else if (SymbolicLinkType_RB.Checked)
            {
                ValueTypeInt = 6;
            }
            else if (MultiStringType_RB.Checked)
            {
                ValueTypeInt = 7;
            }
            else if (ResourceListType_RB.Checked)
            {
                ValueTypeInt = 8;
            }
            else if (HardwareResourceListType_RB.Checked)
            {
                ValueTypeInt = 9;
            }
            else if (ResourceRequirementType_RB.Checked)
            {
                ValueTypeInt = 10;
            }
            else if (LongType_RB.Checked)
            {
                ValueTypeInt = 11;
            }
            return ValueTypeInt;
        }

        public string RegistryStringCreator(string KeyPath, string KeyName, string KeyValue, int KeyType)
        {
            
            string Tostringreturn = "";
            Tostringreturn = "<RegistryKey>" + Environment.NewLine +
                "    <KeyName>" + KeyPath + "</KeyName>" + Environment.NewLine + 
                "    <Subkeys/>" + Environment.NewLine + "    <Values>" + Environment.NewLine + 
                "        <RegistryKeyValue>" + Environment.NewLine + "            <Name>" +
                KeyName + "</Name>" + Environment.NewLine + "            <Value>"
                + KeyValue + "</Value>" + Environment.NewLine + "            <ValueType>" + 
                KeyType + "</ValueType>" + Environment.NewLine + "        </RegistryKeyValue>" + Environment.NewLine +
                "    </Values>" + Environment.NewLine + "</RegistryKey>";

            return Tostringreturn;
        }

        private void ApplyCustHacks_Btn_Click(object sender, EventArgs e)
        {
            KeysToAdd_TB.Text = KeysToAddCustHacks_RTB.Text;
            KeysToDelete_TB.Text = KeysToDeleteCustHacks_RTB.Text;
        }

        private void ApplySettings_Btn_Click(object sender, EventArgs e)
        {
            if (PortSettings_TB.Text == "") {

                MessageBox.Show("Write the port");

            }
            else
            {
                Port = Convert.ToInt32(PortSettings_TB.Text);
                Port_Txtbox.Text = Convert.ToString(Port);
                MessageBox.Show(String.Format("Port changed to {0}!", Port));
                this.Text = "Main Menu | " + Version + " | Port: " + Port + " | Server Proxy: OFF";
            }
            
        }

        private void PortSettings_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
              if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back) 
              {
                   e.Handled = false; 
              }
              else
              {
              e.Handled = true;
              }
        }

        private void License_LLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.gnu.org/copyleft/gpl.html");
        }

        private void XDA_LLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://forum.xda-developers.com/member.php?u=6421461");
        }

        private void Website_LLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.adeltax.com");
        }


    }
}
