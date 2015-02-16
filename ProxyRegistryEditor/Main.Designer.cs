namespace ProxyRegistryEditor
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Welcome_LB = new System.Windows.Forms.Label();
            this.Proxy_Btn = new System.Windows.Forms.Button();
            this.SrvProxy_LB = new System.Windows.Forms.Label();
            this.InfoProxy_LB = new System.Windows.Forms.Label();
            this.RegHacks_LB = new System.Windows.Forms.Label();
            this.CustRegHacks_LB = new System.Windows.Forms.Label();
            this.Settings_LB = new System.Windows.Forms.Label();
            this.Info_LB = new System.Windows.Forms.Label();
            this.SelectedLabel_LB = new System.Windows.Forms.Label();
            this.LocalIP_LB = new System.Windows.Forms.Label();
            this.LocalIP_Txtbox = new System.Windows.Forms.TextBox();
            this.Port_LB = new System.Windows.Forms.Label();
            this.Port_Txtbox = new System.Windows.Forms.TextBox();
            this.isSrvOn_LB = new System.Windows.Forms.Label();
            this.Proxy_TxtBox = new System.Windows.Forms.TextBox();
            this.Console_RTB = new System.Windows.Forms.RichTextBox();
            this.Console_LB = new System.Windows.Forms.Label();
            this.InfoProxy_Panel = new System.Windows.Forms.Panel();
            this.RegistryHacks_Panel = new System.Windows.Forms.Panel();
            this.PfD_GB = new System.Windows.Forms.GroupBox();
            this.PfDDisable_RB = new System.Windows.Forms.RadioButton();
            this.PfDEnable_RB = new System.Windows.Forms.RadioButton();
            this.Neverlock_GB = new System.Windows.Forms.GroupBox();
            this.NeverlockEnable_RB = new System.Windows.Forms.RadioButton();
            this.NeverlockDisable_RB = new System.Windows.Forms.RadioButton();
            this.Aboutmoz_GB = new System.Windows.Forms.GroupBox();
            this.AboutmozEnable_RB = new System.Windows.Forms.RadioButton();
            this.AboutmozDisable_RB = new System.Windows.Forms.RadioButton();
            this.MTPFolder_TB = new System.Windows.Forms.TextBox();
            this.Neverlock_CB = new System.Windows.Forms.CheckBox();
            this.Aboutmoz_CB = new System.Windows.Forms.CheckBox();
            this.PfD_CB = new System.Windows.Forms.CheckBox();
            this.MTPFolder_CB = new System.Windows.Forms.CheckBox();
            this.WPFlightsInit_TB = new System.Windows.Forms.TextBox();
            this.EndingString_TB = new System.Windows.Forms.TextBox();
            this.KeysToAdd_TB = new System.Windows.Forms.TextBox();
            this.KeysToDelete_TB = new System.Windows.Forms.TextBox();
            this.ApplyHacks_Btn = new System.Windows.Forms.Button();
            this.MaxSystemUIVolume_LB = new System.Windows.Forms.CheckBox();
            this.MSUV_Nup = new System.Windows.Forms.NumericUpDown();
            this.MaxInCallUIVolume_CB = new System.Windows.Forms.CheckBox();
            this.MICUV_Nup = new System.Windows.Forms.NumericUpDown();
            this.CustRegHacks_Panel = new System.Windows.Forms.Panel();
            this.RegistryKeyPath_LB = new System.Windows.Forms.Label();
            this.RegistryKeyPath_TB = new System.Windows.Forms.TextBox();
            this.RegistryKeyName_LB = new System.Windows.Forms.Label();
            this.RegistryKeyName_TB = new System.Windows.Forms.TextBox();
            this.RegistryKeyValue_LB = new System.Windows.Forms.Label();
            this.RegistryKeyValue_TB = new System.Windows.Forms.TextBox();
            this.RegistryKeyType_LB = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ApplyCustHacks_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.InfoProxy_Panel.SuspendLayout();
            this.RegistryHacks_Panel.SuspendLayout();
            this.PfD_GB.SuspendLayout();
            this.Neverlock_GB.SuspendLayout();
            this.Aboutmoz_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MSUV_Nup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MICUV_Nup)).BeginInit();
            this.CustRegHacks_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcome_LB
            // 
            this.Welcome_LB.AutoSize = true;
            this.Welcome_LB.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_LB.Location = new System.Drawing.Point(15, 9);
            this.Welcome_LB.Name = "Welcome_LB";
            this.Welcome_LB.Size = new System.Drawing.Size(196, 54);
            this.Welcome_LB.TabIndex = 0;
            this.Welcome_LB.Text = "Welcome!";
            // 
            // Proxy_Btn
            // 
            this.Proxy_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Proxy_Btn.BackColor = System.Drawing.Color.Black;
            this.Proxy_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Proxy_Btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proxy_Btn.Location = new System.Drawing.Point(667, 24);
            this.Proxy_Btn.Name = "Proxy_Btn";
            this.Proxy_Btn.Size = new System.Drawing.Size(105, 35);
            this.Proxy_Btn.TabIndex = 1;
            this.Proxy_Btn.Text = "Start Proxy";
            this.Proxy_Btn.UseMnemonic = false;
            this.Proxy_Btn.UseVisualStyleBackColor = false;
            this.Proxy_Btn.Click += new System.EventHandler(this.Proxy_Btn_Click);
            // 
            // SrvProxy_LB
            // 
            this.SrvProxy_LB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SrvProxy_LB.AutoSize = true;
            this.SrvProxy_LB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrvProxy_LB.ForeColor = System.Drawing.Color.Yellow;
            this.SrvProxy_LB.Location = new System.Drawing.Point(526, 33);
            this.SrvProxy_LB.Name = "SrvProxy_LB";
            this.SrvProxy_LB.Size = new System.Drawing.Size(117, 19);
            this.SrvProxy_LB.TabIndex = 2;
            this.SrvProxy_LB.Text = "Server Proxy: OFF";
            // 
            // InfoProxy_LB
            // 
            this.InfoProxy_LB.AutoSize = true;
            this.InfoProxy_LB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoProxy_LB.Location = new System.Drawing.Point(20, 77);
            this.InfoProxy_LB.Name = "InfoProxy_LB";
            this.InfoProxy_LB.Size = new System.Drawing.Size(104, 21);
            this.InfoProxy_LB.TabIndex = 3;
            this.InfoProxy_LB.Text = "INFO PROXY";
            this.InfoProxy_LB.Click += new System.EventHandler(this.InfoProxy_LB_Click);
            // 
            // RegHacks_LB
            // 
            this.RegHacks_LB.AutoSize = true;
            this.RegHacks_LB.BackColor = System.Drawing.Color.Black;
            this.RegHacks_LB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegHacks_LB.ForeColor = System.Drawing.Color.DimGray;
            this.RegHacks_LB.Location = new System.Drawing.Point(156, 77);
            this.RegHacks_LB.Name = "RegHacks_LB";
            this.RegHacks_LB.Size = new System.Drawing.Size(139, 21);
            this.RegHacks_LB.TabIndex = 4;
            this.RegHacks_LB.Text = "REGISTRY HACKS";
            this.RegHacks_LB.Click += new System.EventHandler(this.RegHacks_LB_Click);
            // 
            // CustRegHacks_LB
            // 
            this.CustRegHacks_LB.AutoSize = true;
            this.CustRegHacks_LB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustRegHacks_LB.ForeColor = System.Drawing.Color.DimGray;
            this.CustRegHacks_LB.Location = new System.Drawing.Point(336, 77);
            this.CustRegHacks_LB.Name = "CustRegHacks_LB";
            this.CustRegHacks_LB.Size = new System.Drawing.Size(209, 21);
            this.CustRegHacks_LB.TabIndex = 4;
            this.CustRegHacks_LB.Text = "CUSTOM REGISTRY HACKS";
            this.CustRegHacks_LB.Click += new System.EventHandler(this.CustRegHacks_LB_Click);
            // 
            // Settings_LB
            // 
            this.Settings_LB.AutoSize = true;
            this.Settings_LB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_LB.ForeColor = System.Drawing.Color.DimGray;
            this.Settings_LB.Location = new System.Drawing.Point(583, 77);
            this.Settings_LB.Name = "Settings_LB";
            this.Settings_LB.Size = new System.Drawing.Size(84, 21);
            this.Settings_LB.TabIndex = 4;
            this.Settings_LB.Text = "SETTINGS";
            // 
            // Info_LB
            // 
            this.Info_LB.AutoSize = true;
            this.Info_LB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info_LB.ForeColor = System.Drawing.Color.DimGray;
            this.Info_LB.Location = new System.Drawing.Point(705, 77);
            this.Info_LB.Name = "Info_LB";
            this.Info_LB.Size = new System.Drawing.Size(48, 21);
            this.Info_LB.TabIndex = 4;
            this.Info_LB.Text = "INFO";
            // 
            // SelectedLabel_LB
            // 
            this.SelectedLabel_LB.BackColor = System.Drawing.Color.White;
            this.SelectedLabel_LB.Location = new System.Drawing.Point(25, 101);
            this.SelectedLabel_LB.Name = "SelectedLabel_LB";
            this.SelectedLabel_LB.Size = new System.Drawing.Size(93, 3);
            this.SelectedLabel_LB.TabIndex = 5;
            // 
            // LocalIP_LB
            // 
            this.LocalIP_LB.AutoSize = true;
            this.LocalIP_LB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalIP_LB.Location = new System.Drawing.Point(42, 42);
            this.LocalIP_LB.Name = "LocalIP_LB";
            this.LocalIP_LB.Size = new System.Drawing.Size(87, 28);
            this.LocalIP_LB.TabIndex = 6;
            this.LocalIP_LB.Text = "Local IP: ";
            // 
            // LocalIP_Txtbox
            // 
            this.LocalIP_Txtbox.BackColor = System.Drawing.Color.Black;
            this.LocalIP_Txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocalIP_Txtbox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalIP_Txtbox.ForeColor = System.Drawing.Color.White;
            this.LocalIP_Txtbox.Location = new System.Drawing.Point(135, 40);
            this.LocalIP_Txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.LocalIP_Txtbox.Name = "LocalIP_Txtbox";
            this.LocalIP_Txtbox.ReadOnly = true;
            this.LocalIP_Txtbox.Size = new System.Drawing.Size(245, 34);
            this.LocalIP_Txtbox.TabIndex = 7;
            // 
            // Port_LB
            // 
            this.Port_LB.AutoSize = true;
            this.Port_LB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port_LB.Location = new System.Drawing.Point(42, 108);
            this.Port_LB.Name = "Port_LB";
            this.Port_LB.Size = new System.Drawing.Size(52, 28);
            this.Port_LB.TabIndex = 6;
            this.Port_LB.Text = "Port:";
            // 
            // Port_Txtbox
            // 
            this.Port_Txtbox.BackColor = System.Drawing.Color.Black;
            this.Port_Txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Port_Txtbox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port_Txtbox.ForeColor = System.Drawing.Color.White;
            this.Port_Txtbox.Location = new System.Drawing.Point(135, 106);
            this.Port_Txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.Port_Txtbox.Name = "Port_Txtbox";
            this.Port_Txtbox.ReadOnly = true;
            this.Port_Txtbox.Size = new System.Drawing.Size(245, 34);
            this.Port_Txtbox.TabIndex = 7;
            // 
            // isSrvOn_LB
            // 
            this.isSrvOn_LB.AutoSize = true;
            this.isSrvOn_LB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isSrvOn_LB.Location = new System.Drawing.Point(42, 176);
            this.isSrvOn_LB.Name = "isSrvOn_LB";
            this.isSrvOn_LB.Size = new System.Drawing.Size(65, 28);
            this.isSrvOn_LB.TabIndex = 6;
            this.isSrvOn_LB.Text = "Proxy:";
            // 
            // Proxy_TxtBox
            // 
            this.Proxy_TxtBox.BackColor = System.Drawing.Color.Black;
            this.Proxy_TxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Proxy_TxtBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proxy_TxtBox.ForeColor = System.Drawing.Color.White;
            this.Proxy_TxtBox.Location = new System.Drawing.Point(135, 174);
            this.Proxy_TxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.Proxy_TxtBox.Name = "Proxy_TxtBox";
            this.Proxy_TxtBox.ReadOnly = true;
            this.Proxy_TxtBox.Size = new System.Drawing.Size(245, 34);
            this.Proxy_TxtBox.TabIndex = 7;
            // 
            // Console_RTB
            // 
            this.Console_RTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Console_RTB.BackColor = System.Drawing.Color.Black;
            this.Console_RTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Console_RTB.ForeColor = System.Drawing.Color.White;
            this.Console_RTB.Location = new System.Drawing.Point(42, 274);
            this.Console_RTB.Name = "Console_RTB";
            this.Console_RTB.ReadOnly = true;
            this.Console_RTB.Size = new System.Drawing.Size(673, 121);
            this.Console_RTB.TabIndex = 8;
            this.Console_RTB.Text = "";
            // 
            // Console_LB
            // 
            this.Console_LB.AutoSize = true;
            this.Console_LB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Console_LB.Location = new System.Drawing.Point(42, 243);
            this.Console_LB.Name = "Console_LB";
            this.Console_LB.Size = new System.Drawing.Size(86, 28);
            this.Console_LB.TabIndex = 6;
            this.Console_LB.Text = "Console:";
            // 
            // InfoProxy_Panel
            // 
            this.InfoProxy_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoProxy_Panel.Controls.Add(this.Console_RTB);
            this.InfoProxy_Panel.Controls.Add(this.Proxy_TxtBox);
            this.InfoProxy_Panel.Controls.Add(this.LocalIP_LB);
            this.InfoProxy_Panel.Controls.Add(this.Port_Txtbox);
            this.InfoProxy_Panel.Controls.Add(this.Port_LB);
            this.InfoProxy_Panel.Controls.Add(this.LocalIP_Txtbox);
            this.InfoProxy_Panel.Controls.Add(this.isSrvOn_LB);
            this.InfoProxy_Panel.Controls.Add(this.Console_LB);
            this.InfoProxy_Panel.Location = new System.Drawing.Point(11, 117);
            this.InfoProxy_Panel.Name = "InfoProxy_Panel";
            this.InfoProxy_Panel.Size = new System.Drawing.Size(761, 432);
            this.InfoProxy_Panel.TabIndex = 9;
            // 
            // RegistryHacks_Panel
            // 
            this.RegistryHacks_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistryHacks_Panel.Controls.Add(this.MICUV_Nup);
            this.RegistryHacks_Panel.Controls.Add(this.MSUV_Nup);
            this.RegistryHacks_Panel.Controls.Add(this.MaxInCallUIVolume_CB);
            this.RegistryHacks_Panel.Controls.Add(this.MaxSystemUIVolume_LB);
            this.RegistryHacks_Panel.Controls.Add(this.ApplyHacks_Btn);
            this.RegistryHacks_Panel.Controls.Add(this.PfD_GB);
            this.RegistryHacks_Panel.Controls.Add(this.Neverlock_GB);
            this.RegistryHacks_Panel.Controls.Add(this.Aboutmoz_GB);
            this.RegistryHacks_Panel.Controls.Add(this.MTPFolder_TB);
            this.RegistryHacks_Panel.Controls.Add(this.Neverlock_CB);
            this.RegistryHacks_Panel.Controls.Add(this.Aboutmoz_CB);
            this.RegistryHacks_Panel.Controls.Add(this.PfD_CB);
            this.RegistryHacks_Panel.Controls.Add(this.MTPFolder_CB);
            this.RegistryHacks_Panel.Location = new System.Drawing.Point(11, 117);
            this.RegistryHacks_Panel.Name = "RegistryHacks_Panel";
            this.RegistryHacks_Panel.Size = new System.Drawing.Size(761, 432);
            this.RegistryHacks_Panel.TabIndex = 10;
            this.RegistryHacks_Panel.Visible = false;
            // 
            // PfD_GB
            // 
            this.PfD_GB.Controls.Add(this.PfDDisable_RB);
            this.PfD_GB.Controls.Add(this.PfDEnable_RB);
            this.PfD_GB.Location = new System.Drawing.Point(256, 60);
            this.PfD_GB.Name = "PfD_GB";
            this.PfD_GB.Size = new System.Drawing.Size(200, 45);
            this.PfD_GB.TabIndex = 12;
            this.PfD_GB.TabStop = false;
            // 
            // PfDDisable_RB
            // 
            this.PfDDisable_RB.AutoSize = true;
            this.PfDDisable_RB.Checked = true;
            this.PfDDisable_RB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PfDDisable_RB.Location = new System.Drawing.Point(100, 10);
            this.PfDDisable_RB.Name = "PfDDisable_RB";
            this.PfDDisable_RB.Size = new System.Drawing.Size(94, 32);
            this.PfDDisable_RB.TabIndex = 10;
            this.PfDDisable_RB.TabStop = true;
            this.PfDDisable_RB.Text = "Disable";
            this.PfDDisable_RB.UseVisualStyleBackColor = true;
            // 
            // PfDEnable_RB
            // 
            this.PfDEnable_RB.AutoSize = true;
            this.PfDEnable_RB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PfDEnable_RB.Location = new System.Drawing.Point(6, 10);
            this.PfDEnable_RB.Name = "PfDEnable_RB";
            this.PfDEnable_RB.Size = new System.Drawing.Size(88, 32);
            this.PfDEnable_RB.TabIndex = 10;
            this.PfDEnable_RB.Text = "Enable";
            this.PfDEnable_RB.UseVisualStyleBackColor = true;
            // 
            // Neverlock_GB
            // 
            this.Neverlock_GB.Controls.Add(this.NeverlockEnable_RB);
            this.Neverlock_GB.Controls.Add(this.NeverlockDisable_RB);
            this.Neverlock_GB.Location = new System.Drawing.Point(256, 157);
            this.Neverlock_GB.Name = "Neverlock_GB";
            this.Neverlock_GB.Size = new System.Drawing.Size(200, 45);
            this.Neverlock_GB.TabIndex = 11;
            this.Neverlock_GB.TabStop = false;
            // 
            // NeverlockEnable_RB
            // 
            this.NeverlockEnable_RB.AutoSize = true;
            this.NeverlockEnable_RB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeverlockEnable_RB.Location = new System.Drawing.Point(6, 8);
            this.NeverlockEnable_RB.Name = "NeverlockEnable_RB";
            this.NeverlockEnable_RB.Size = new System.Drawing.Size(88, 32);
            this.NeverlockEnable_RB.TabIndex = 10;
            this.NeverlockEnable_RB.Text = "Enable";
            this.NeverlockEnable_RB.UseVisualStyleBackColor = true;
            // 
            // NeverlockDisable_RB
            // 
            this.NeverlockDisable_RB.AutoSize = true;
            this.NeverlockDisable_RB.Checked = true;
            this.NeverlockDisable_RB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeverlockDisable_RB.Location = new System.Drawing.Point(100, 8);
            this.NeverlockDisable_RB.Name = "NeverlockDisable_RB";
            this.NeverlockDisable_RB.Size = new System.Drawing.Size(94, 32);
            this.NeverlockDisable_RB.TabIndex = 10;
            this.NeverlockDisable_RB.TabStop = true;
            this.NeverlockDisable_RB.Text = "Disable";
            this.NeverlockDisable_RB.UseVisualStyleBackColor = true;
            // 
            // Aboutmoz_GB
            // 
            this.Aboutmoz_GB.Controls.Add(this.AboutmozEnable_RB);
            this.Aboutmoz_GB.Controls.Add(this.AboutmozDisable_RB);
            this.Aboutmoz_GB.Location = new System.Drawing.Point(256, 109);
            this.Aboutmoz_GB.Name = "Aboutmoz_GB";
            this.Aboutmoz_GB.Size = new System.Drawing.Size(200, 45);
            this.Aboutmoz_GB.TabIndex = 11;
            this.Aboutmoz_GB.TabStop = false;
            // 
            // AboutmozEnable_RB
            // 
            this.AboutmozEnable_RB.AutoSize = true;
            this.AboutmozEnable_RB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutmozEnable_RB.Location = new System.Drawing.Point(6, 8);
            this.AboutmozEnable_RB.Name = "AboutmozEnable_RB";
            this.AboutmozEnable_RB.Size = new System.Drawing.Size(88, 32);
            this.AboutmozEnable_RB.TabIndex = 10;
            this.AboutmozEnable_RB.Text = "Enable";
            this.AboutmozEnable_RB.UseVisualStyleBackColor = true;
            // 
            // AboutmozDisable_RB
            // 
            this.AboutmozDisable_RB.AutoSize = true;
            this.AboutmozDisable_RB.Checked = true;
            this.AboutmozDisable_RB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutmozDisable_RB.Location = new System.Drawing.Point(100, 8);
            this.AboutmozDisable_RB.Name = "AboutmozDisable_RB";
            this.AboutmozDisable_RB.Size = new System.Drawing.Size(94, 32);
            this.AboutmozDisable_RB.TabIndex = 10;
            this.AboutmozDisable_RB.TabStop = true;
            this.AboutmozDisable_RB.Text = "Disable";
            this.AboutmozDisable_RB.UseVisualStyleBackColor = true;
            // 
            // MTPFolder_TB
            // 
            this.MTPFolder_TB.BackColor = System.Drawing.Color.Black;
            this.MTPFolder_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MTPFolder_TB.Enabled = false;
            this.MTPFolder_TB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTPFolder_TB.ForeColor = System.Drawing.Color.White;
            this.MTPFolder_TB.Location = new System.Drawing.Point(256, 21);
            this.MTPFolder_TB.Margin = new System.Windows.Forms.Padding(2);
            this.MTPFolder_TB.Name = "MTPFolder_TB";
            this.MTPFolder_TB.Size = new System.Drawing.Size(200, 34);
            this.MTPFolder_TB.TabIndex = 9;
            this.MTPFolder_TB.Text = "C:\\Data\\Users\\Public";
            // 
            // Neverlock_CB
            // 
            this.Neverlock_CB.AutoSize = true;
            this.Neverlock_CB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Neverlock_CB.Location = new System.Drawing.Point(17, 164);
            this.Neverlock_CB.Name = "Neverlock_CB";
            this.Neverlock_CB.Size = new System.Drawing.Size(124, 32);
            this.Neverlock_CB.TabIndex = 8;
            this.Neverlock_CB.Text = "Never lock";
            this.Neverlock_CB.UseVisualStyleBackColor = true;
            // 
            // Aboutmoz_CB
            // 
            this.Aboutmoz_CB.AutoSize = true;
            this.Aboutmoz_CB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aboutmoz_CB.Location = new System.Drawing.Point(17, 117);
            this.Aboutmoz_CB.Name = "Aboutmoz_CB";
            this.Aboutmoz_CB.Size = new System.Drawing.Size(128, 32);
            this.Aboutmoz_CB.TabIndex = 8;
            this.Aboutmoz_CB.Text = "About.moz";
            this.Aboutmoz_CB.UseVisualStyleBackColor = true;
            // 
            // PfD_CB
            // 
            this.PfD_CB.AutoSize = true;
            this.PfD_CB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PfD_CB.Location = new System.Drawing.Point(17, 70);
            this.PfD_CB.Name = "PfD_CB";
            this.PfD_CB.Size = new System.Drawing.Size(229, 32);
            this.PfD_CB.TabIndex = 8;
            this.PfD_CB.Text = "Preview for developers";
            this.PfD_CB.UseVisualStyleBackColor = true;
            // 
            // MTPFolder_CB
            // 
            this.MTPFolder_CB.AutoSize = true;
            this.MTPFolder_CB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTPFolder_CB.Location = new System.Drawing.Point(17, 22);
            this.MTPFolder_CB.Name = "MTPFolder_CB";
            this.MTPFolder_CB.Size = new System.Drawing.Size(135, 32);
            this.MTPFolder_CB.TabIndex = 8;
            this.MTPFolder_CB.Text = "MTP Folder:";
            this.MTPFolder_CB.UseVisualStyleBackColor = true;
            this.MTPFolder_CB.CheckedChanged += new System.EventHandler(this.MTPFolder_CB_CheckedChanged);
            // 
            // WPFlightsInit_TB
            // 
            this.WPFlightsInit_TB.Location = new System.Drawing.Point(218, 9);
            this.WPFlightsInit_TB.Multiline = true;
            this.WPFlightsInit_TB.Name = "WPFlightsInit_TB";
            this.WPFlightsInit_TB.Size = new System.Drawing.Size(143, 21);
            this.WPFlightsInit_TB.TabIndex = 11;
            this.WPFlightsInit_TB.Text = resources.GetString("WPFlightsInit_TB.Text");
            // 
            // EndingString_TB
            // 
            this.EndingString_TB.Location = new System.Drawing.Point(367, 9);
            this.EndingString_TB.Multiline = true;
            this.EndingString_TB.Name = "EndingString_TB";
            this.EndingString_TB.Size = new System.Drawing.Size(120, 21);
            this.EndingString_TB.TabIndex = 11;
            this.EndingString_TB.Text = resources.GetString("EndingString_TB.Text");
            // 
            // KeysToAdd_TB
            // 
            this.KeysToAdd_TB.Location = new System.Drawing.Point(217, 36);
            this.KeysToAdd_TB.Multiline = true;
            this.KeysToAdd_TB.Name = "KeysToAdd_TB";
            this.KeysToAdd_TB.Size = new System.Drawing.Size(144, 21);
            this.KeysToAdd_TB.TabIndex = 11;
            // 
            // KeysToDelete_TB
            // 
            this.KeysToDelete_TB.Location = new System.Drawing.Point(367, 36);
            this.KeysToDelete_TB.Multiline = true;
            this.KeysToDelete_TB.Name = "KeysToDelete_TB";
            this.KeysToDelete_TB.Size = new System.Drawing.Size(120, 21);
            this.KeysToDelete_TB.TabIndex = 11;
            // 
            // ApplyHacks_Btn
            // 
            this.ApplyHacks_Btn.BackColor = System.Drawing.Color.Black;
            this.ApplyHacks_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyHacks_Btn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyHacks_Btn.Location = new System.Drawing.Point(646, 386);
            this.ApplyHacks_Btn.Name = "ApplyHacks_Btn";
            this.ApplyHacks_Btn.Size = new System.Drawing.Size(112, 43);
            this.ApplyHacks_Btn.TabIndex = 13;
            this.ApplyHacks_Btn.Text = "Apply";
            this.ApplyHacks_Btn.UseVisualStyleBackColor = false;
            this.ApplyHacks_Btn.Click += new System.EventHandler(this.ApplyHacks_Btn_Click);
            // 
            // MaxSystemUIVolume_LB
            // 
            this.MaxSystemUIVolume_LB.AutoSize = true;
            this.MaxSystemUIVolume_LB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxSystemUIVolume_LB.Location = new System.Drawing.Point(17, 212);
            this.MaxSystemUIVolume_LB.Name = "MaxSystemUIVolume_LB";
            this.MaxSystemUIVolume_LB.Size = new System.Drawing.Size(215, 32);
            this.MaxSystemUIVolume_LB.TabIndex = 14;
            this.MaxSystemUIVolume_LB.Text = "MaxSystemUIVolume";
            this.MaxSystemUIVolume_LB.UseVisualStyleBackColor = true;
            // 
            // MSUV_Nup
            // 
            this.MSUV_Nup.BackColor = System.Drawing.Color.Black;
            this.MSUV_Nup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MSUV_Nup.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSUV_Nup.ForeColor = System.Drawing.Color.White;
            this.MSUV_Nup.Location = new System.Drawing.Point(256, 211);
            this.MSUV_Nup.Name = "MSUV_Nup";
            this.MSUV_Nup.Size = new System.Drawing.Size(200, 34);
            this.MSUV_Nup.TabIndex = 15;
            this.MSUV_Nup.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // MaxInCallUIVolume_CB
            // 
            this.MaxInCallUIVolume_CB.AutoSize = true;
            this.MaxInCallUIVolume_CB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxInCallUIVolume_CB.Location = new System.Drawing.Point(17, 258);
            this.MaxInCallUIVolume_CB.Name = "MaxInCallUIVolume_CB";
            this.MaxInCallUIVolume_CB.Size = new System.Drawing.Size(201, 32);
            this.MaxInCallUIVolume_CB.TabIndex = 14;
            this.MaxInCallUIVolume_CB.Text = "MaxInCallUIVolume";
            this.MaxInCallUIVolume_CB.UseVisualStyleBackColor = true;
            // 
            // MICUV_Nup
            // 
            this.MICUV_Nup.BackColor = System.Drawing.Color.Black;
            this.MICUV_Nup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MICUV_Nup.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MICUV_Nup.ForeColor = System.Drawing.Color.White;
            this.MICUV_Nup.Location = new System.Drawing.Point(256, 257);
            this.MICUV_Nup.Name = "MICUV_Nup";
            this.MICUV_Nup.Size = new System.Drawing.Size(200, 34);
            this.MICUV_Nup.TabIndex = 15;
            this.MICUV_Nup.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // CustRegHacks_Panel
            // 
            this.CustRegHacks_Panel.Controls.Add(this.label2);
            this.CustRegHacks_Panel.Controls.Add(this.label1);
            this.CustRegHacks_Panel.Controls.Add(this.button2);
            this.CustRegHacks_Panel.Controls.Add(this.button1);
            this.CustRegHacks_Panel.Controls.Add(this.ApplyCustHacks_Btn);
            this.CustRegHacks_Panel.Controls.Add(this.textBox2);
            this.CustRegHacks_Panel.Controls.Add(this.textBox1);
            this.CustRegHacks_Panel.Controls.Add(this.radioButton4);
            this.CustRegHacks_Panel.Controls.Add(this.radioButton3);
            this.CustRegHacks_Panel.Controls.Add(this.radioButton2);
            this.CustRegHacks_Panel.Controls.Add(this.radioButton1);
            this.CustRegHacks_Panel.Controls.Add(this.RegistryKeyValue_TB);
            this.CustRegHacks_Panel.Controls.Add(this.RegistryKeyName_TB);
            this.CustRegHacks_Panel.Controls.Add(this.RegistryKeyPath_TB);
            this.CustRegHacks_Panel.Controls.Add(this.RegistryKeyType_LB);
            this.CustRegHacks_Panel.Controls.Add(this.RegistryKeyValue_LB);
            this.CustRegHacks_Panel.Controls.Add(this.RegistryKeyName_LB);
            this.CustRegHacks_Panel.Controls.Add(this.RegistryKeyPath_LB);
            this.CustRegHacks_Panel.Location = new System.Drawing.Point(11, 117);
            this.CustRegHacks_Panel.Name = "CustRegHacks_Panel";
            this.CustRegHacks_Panel.Size = new System.Drawing.Size(761, 432);
            this.CustRegHacks_Panel.TabIndex = 12;
            this.CustRegHacks_Panel.Visible = false;
            // 
            // RegistryKeyPath_LB
            // 
            this.RegistryKeyPath_LB.AutoSize = true;
            this.RegistryKeyPath_LB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistryKeyPath_LB.Location = new System.Drawing.Point(20, 7);
            this.RegistryKeyPath_LB.Name = "RegistryKeyPath_LB";
            this.RegistryKeyPath_LB.Size = new System.Drawing.Size(166, 28);
            this.RegistryKeyPath_LB.TabIndex = 13;
            this.RegistryKeyPath_LB.Text = "Registry Key Path:";
            // 
            // RegistryKeyPath_TB
            // 
            this.RegistryKeyPath_TB.BackColor = System.Drawing.Color.Black;
            this.RegistryKeyPath_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegistryKeyPath_TB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistryKeyPath_TB.ForeColor = System.Drawing.Color.White;
            this.RegistryKeyPath_TB.Location = new System.Drawing.Point(206, 5);
            this.RegistryKeyPath_TB.Name = "RegistryKeyPath_TB";
            this.RegistryKeyPath_TB.Size = new System.Drawing.Size(518, 34);
            this.RegistryKeyPath_TB.TabIndex = 14;
            // 
            // RegistryKeyName_LB
            // 
            this.RegistryKeyName_LB.AutoSize = true;
            this.RegistryKeyName_LB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistryKeyName_LB.Location = new System.Drawing.Point(21, 47);
            this.RegistryKeyName_LB.Name = "RegistryKeyName_LB";
            this.RegistryKeyName_LB.Size = new System.Drawing.Size(180, 28);
            this.RegistryKeyName_LB.TabIndex = 13;
            this.RegistryKeyName_LB.Text = "Registry Key Name:";
            // 
            // RegistryKeyName_TB
            // 
            this.RegistryKeyName_TB.BackColor = System.Drawing.Color.Black;
            this.RegistryKeyName_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegistryKeyName_TB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistryKeyName_TB.ForeColor = System.Drawing.Color.White;
            this.RegistryKeyName_TB.Location = new System.Drawing.Point(207, 45);
            this.RegistryKeyName_TB.Name = "RegistryKeyName_TB";
            this.RegistryKeyName_TB.Size = new System.Drawing.Size(518, 34);
            this.RegistryKeyName_TB.TabIndex = 14;
            // 
            // RegistryKeyValue_LB
            // 
            this.RegistryKeyValue_LB.AutoSize = true;
            this.RegistryKeyValue_LB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistryKeyValue_LB.Location = new System.Drawing.Point(20, 87);
            this.RegistryKeyValue_LB.Name = "RegistryKeyValue_LB";
            this.RegistryKeyValue_LB.Size = new System.Drawing.Size(175, 28);
            this.RegistryKeyValue_LB.TabIndex = 13;
            this.RegistryKeyValue_LB.Text = "Registry Key Value:";
            // 
            // RegistryKeyValue_TB
            // 
            this.RegistryKeyValue_TB.BackColor = System.Drawing.Color.Black;
            this.RegistryKeyValue_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegistryKeyValue_TB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistryKeyValue_TB.ForeColor = System.Drawing.Color.White;
            this.RegistryKeyValue_TB.Location = new System.Drawing.Point(207, 85);
            this.RegistryKeyValue_TB.Name = "RegistryKeyValue_TB";
            this.RegistryKeyValue_TB.Size = new System.Drawing.Size(518, 34);
            this.RegistryKeyValue_TB.TabIndex = 14;
            // 
            // RegistryKeyType_LB
            // 
            this.RegistryKeyType_LB.AutoSize = true;
            this.RegistryKeyType_LB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistryKeyType_LB.Location = new System.Drawing.Point(21, 124);
            this.RegistryKeyType_LB.Name = "RegistryKeyType_LB";
            this.RegistryKeyType_LB.Size = new System.Drawing.Size(169, 28);
            this.RegistryKeyType_LB.TabIndex = 13;
            this.RegistryKeyType_LB.Text = "Registry Key Type:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(195, 122);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 32);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "String (1)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(429, 122);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(120, 32);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.Text = "Integer (4)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(311, 122);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(112, 32);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.Text = "Binary (3)";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(555, 125);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(113, 32);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.Text = "Long (11)";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(13, 182);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 207);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(386, 182);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(372, 207);
            this.textBox2.TabIndex = 16;
            // 
            // ApplyCustHacks_Btn
            // 
            this.ApplyCustHacks_Btn.BackColor = System.Drawing.Color.Black;
            this.ApplyCustHacks_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyCustHacks_Btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyCustHacks_Btn.Location = new System.Drawing.Point(665, 395);
            this.ApplyCustHacks_Btn.Name = "ApplyCustHacks_Btn";
            this.ApplyCustHacks_Btn.Size = new System.Drawing.Size(96, 37);
            this.ApplyCustHacks_Btn.TabIndex = 17;
            this.ApplyCustHacks_Btn.Text = "Apply";
            this.ApplyCustHacks_Btn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Keys to add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Keys to remove";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(104, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add Key";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(476, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 37);
            this.button2.TabIndex = 17;
            this.button2.Text = "Remove Key";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CustRegHacks_Panel);
            this.Controls.Add(this.KeysToDelete_TB);
            this.Controls.Add(this.KeysToAdd_TB);
            this.Controls.Add(this.EndingString_TB);
            this.Controls.Add(this.WPFlightsInit_TB);
            this.Controls.Add(this.RegistryHacks_Panel);
            this.Controls.Add(this.SelectedLabel_LB);
            this.Controls.Add(this.Info_LB);
            this.Controls.Add(this.Settings_LB);
            this.Controls.Add(this.CustRegHacks_LB);
            this.Controls.Add(this.RegHacks_LB);
            this.Controls.Add(this.InfoProxy_LB);
            this.Controls.Add(this.SrvProxy_LB);
            this.Controls.Add(this.Proxy_Btn);
            this.Controls.Add(this.Welcome_LB);
            this.Controls.Add(this.InfoProxy_Panel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu | Server Proxy: OFF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.InfoProxy_Panel.ResumeLayout(false);
            this.InfoProxy_Panel.PerformLayout();
            this.RegistryHacks_Panel.ResumeLayout(false);
            this.RegistryHacks_Panel.PerformLayout();
            this.PfD_GB.ResumeLayout(false);
            this.PfD_GB.PerformLayout();
            this.Neverlock_GB.ResumeLayout(false);
            this.Neverlock_GB.PerformLayout();
            this.Aboutmoz_GB.ResumeLayout(false);
            this.Aboutmoz_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MSUV_Nup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MICUV_Nup)).EndInit();
            this.CustRegHacks_Panel.ResumeLayout(false);
            this.CustRegHacks_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_LB;
        private System.Windows.Forms.Button Proxy_Btn;
        private System.Windows.Forms.Label SrvProxy_LB;
        private System.Windows.Forms.Label InfoProxy_LB;
        private System.Windows.Forms.Label RegHacks_LB;
        private System.Windows.Forms.Label CustRegHacks_LB;
        private System.Windows.Forms.Label Settings_LB;
        private System.Windows.Forms.Label Info_LB;
        private System.Windows.Forms.Label SelectedLabel_LB;
        private System.Windows.Forms.Label LocalIP_LB;
        private System.Windows.Forms.TextBox LocalIP_Txtbox;
        private System.Windows.Forms.Label Port_LB;
        private System.Windows.Forms.TextBox Port_Txtbox;
        private System.Windows.Forms.Label isSrvOn_LB;
        private System.Windows.Forms.TextBox Proxy_TxtBox;
        private System.Windows.Forms.RichTextBox Console_RTB;
        private System.Windows.Forms.Label Console_LB;
        private System.Windows.Forms.Panel InfoProxy_Panel;
        private System.Windows.Forms.Panel RegistryHacks_Panel;
        private System.Windows.Forms.TextBox MTPFolder_TB;
        private System.Windows.Forms.CheckBox MTPFolder_CB;
        private System.Windows.Forms.RadioButton PfDDisable_RB;
        private System.Windows.Forms.RadioButton PfDEnable_RB;
        private System.Windows.Forms.CheckBox PfD_CB;
        private System.Windows.Forms.CheckBox Aboutmoz_CB;
        private System.Windows.Forms.RadioButton AboutmozDisable_RB;
        private System.Windows.Forms.RadioButton AboutmozEnable_RB;
        private System.Windows.Forms.GroupBox PfD_GB;
        private System.Windows.Forms.GroupBox Aboutmoz_GB;
        private System.Windows.Forms.GroupBox Neverlock_GB;
        private System.Windows.Forms.RadioButton NeverlockEnable_RB;
        private System.Windows.Forms.RadioButton NeverlockDisable_RB;
        private System.Windows.Forms.CheckBox Neverlock_CB;
        private System.Windows.Forms.TextBox WPFlightsInit_TB;
        private System.Windows.Forms.TextBox EndingString_TB;
        private System.Windows.Forms.TextBox KeysToAdd_TB;
        private System.Windows.Forms.TextBox KeysToDelete_TB;
        private System.Windows.Forms.Button ApplyHacks_Btn;
        private System.Windows.Forms.NumericUpDown MSUV_Nup;
        private System.Windows.Forms.CheckBox MaxSystemUIVolume_LB;
        private System.Windows.Forms.NumericUpDown MICUV_Nup;
        private System.Windows.Forms.CheckBox MaxInCallUIVolume_CB;
        private System.Windows.Forms.Panel CustRegHacks_Panel;
        private System.Windows.Forms.Label RegistryKeyPath_LB;
        private System.Windows.Forms.TextBox RegistryKeyName_TB;
        private System.Windows.Forms.TextBox RegistryKeyPath_TB;
        private System.Windows.Forms.Label RegistryKeyName_LB;
        private System.Windows.Forms.TextBox RegistryKeyValue_TB;
        private System.Windows.Forms.Label RegistryKeyValue_LB;
        private System.Windows.Forms.Label RegistryKeyType_LB;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ApplyCustHacks_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

