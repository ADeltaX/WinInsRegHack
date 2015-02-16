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
            this.MTPFolder_TB = new System.Windows.Forms.TextBox();
            this.MTPFolder_CB = new System.Windows.Forms.CheckBox();
            this.PfD_CB = new System.Windows.Forms.CheckBox();
            this.PfDEnable_RB = new System.Windows.Forms.RadioButton();
            this.PfDDisable_RB = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.Aboutmoz_CB = new System.Windows.Forms.CheckBox();
            this.AboutmozEnable_CB = new System.Windows.Forms.RadioButton();
            this.AboutmozDisable_CB = new System.Windows.Forms.RadioButton();
            this.Aboutmoz_GB = new System.Windows.Forms.GroupBox();
            this.PfD_GB = new System.Windows.Forms.GroupBox();
            this.NeverLock_CB = new System.Windows.Forms.CheckBox();
            this.Neverlock_GB = new System.Windows.Forms.GroupBox();
            this.NeverlockEnable_CB = new System.Windows.Forms.RadioButton();
            this.NeverlockDisable_CB = new System.Windows.Forms.RadioButton();
            this.InfoProxy_Panel.SuspendLayout();
            this.RegistryHacks_Panel.SuspendLayout();
            this.Aboutmoz_GB.SuspendLayout();
            this.PfD_GB.SuspendLayout();
            this.Neverlock_GB.SuspendLayout();
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
            this.RegistryHacks_Panel.Controls.Add(this.PfD_GB);
            this.RegistryHacks_Panel.Controls.Add(this.Neverlock_GB);
            this.RegistryHacks_Panel.Controls.Add(this.Aboutmoz_GB);
            this.RegistryHacks_Panel.Controls.Add(this.MTPFolder_TB);
            this.RegistryHacks_Panel.Controls.Add(this.NeverLock_CB);
            this.RegistryHacks_Panel.Controls.Add(this.Aboutmoz_CB);
            this.RegistryHacks_Panel.Controls.Add(this.PfD_CB);
            this.RegistryHacks_Panel.Controls.Add(this.MTPFolder_CB);
            this.RegistryHacks_Panel.Controls.Add(this.button1);
            this.RegistryHacks_Panel.Location = new System.Drawing.Point(11, 117);
            this.RegistryHacks_Panel.Name = "RegistryHacks_Panel";
            this.RegistryHacks_Panel.Size = new System.Drawing.Size(761, 432);
            this.RegistryHacks_Panel.TabIndex = 10;
            this.RegistryHacks_Panel.Visible = false;
            // 
            // MTPFolder_TB
            // 
            this.MTPFolder_TB.BackColor = System.Drawing.Color.Black;
            this.MTPFolder_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MTPFolder_TB.Enabled = false;
            this.MTPFolder_TB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTPFolder_TB.ForeColor = System.Drawing.Color.White;
            this.MTPFolder_TB.Location = new System.Drawing.Point(157, 21);
            this.MTPFolder_TB.Margin = new System.Windows.Forms.Padding(2);
            this.MTPFolder_TB.Name = "MTPFolder_TB";
            this.MTPFolder_TB.Size = new System.Drawing.Size(245, 34);
            this.MTPFolder_TB.TabIndex = 9;
            this.MTPFolder_TB.Text = "C:\\";
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
            // PfD_CB
            // 
            this.PfD_CB.AutoSize = true;
            this.PfD_CB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PfD_CB.Location = new System.Drawing.Point(17, 69);
            this.PfD_CB.Name = "PfD_CB";
            this.PfD_CB.Size = new System.Drawing.Size(229, 32);
            this.PfD_CB.TabIndex = 8;
            this.PfD_CB.Text = "Preview for developers";
            this.PfD_CB.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(653, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apply";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Proxy_Btn_Click);
            // 
            // Aboutmoz_CB
            // 
            this.Aboutmoz_CB.AutoSize = true;
            this.Aboutmoz_CB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aboutmoz_CB.Location = new System.Drawing.Point(17, 116);
            this.Aboutmoz_CB.Name = "Aboutmoz_CB";
            this.Aboutmoz_CB.Size = new System.Drawing.Size(128, 32);
            this.Aboutmoz_CB.TabIndex = 8;
            this.Aboutmoz_CB.Text = "About.moz";
            this.Aboutmoz_CB.UseVisualStyleBackColor = true;
            // 
            // AboutmozEnable_CB
            // 
            this.AboutmozEnable_CB.AutoSize = true;
            this.AboutmozEnable_CB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutmozEnable_CB.Location = new System.Drawing.Point(6, 8);
            this.AboutmozEnable_CB.Name = "AboutmozEnable_CB";
            this.AboutmozEnable_CB.Size = new System.Drawing.Size(88, 32);
            this.AboutmozEnable_CB.TabIndex = 10;
            this.AboutmozEnable_CB.Text = "Enable";
            this.AboutmozEnable_CB.UseVisualStyleBackColor = true;
            // 
            // AboutmozDisable_CB
            // 
            this.AboutmozDisable_CB.AutoSize = true;
            this.AboutmozDisable_CB.Checked = true;
            this.AboutmozDisable_CB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutmozDisable_CB.Location = new System.Drawing.Point(100, 8);
            this.AboutmozDisable_CB.Name = "AboutmozDisable_CB";
            this.AboutmozDisable_CB.Size = new System.Drawing.Size(94, 32);
            this.AboutmozDisable_CB.TabIndex = 10;
            this.AboutmozDisable_CB.TabStop = true;
            this.AboutmozDisable_CB.Text = "Disable";
            this.AboutmozDisable_CB.UseVisualStyleBackColor = true;
            // 
            // Aboutmoz_GB
            // 
            this.Aboutmoz_GB.Controls.Add(this.AboutmozEnable_CB);
            this.Aboutmoz_GB.Controls.Add(this.AboutmozDisable_CB);
            this.Aboutmoz_GB.Location = new System.Drawing.Point(180, 108);
            this.Aboutmoz_GB.Name = "Aboutmoz_GB";
            this.Aboutmoz_GB.Size = new System.Drawing.Size(200, 45);
            this.Aboutmoz_GB.TabIndex = 11;
            this.Aboutmoz_GB.TabStop = false;
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
            // NeverLock_CB
            // 
            this.NeverLock_CB.AutoSize = true;
            this.NeverLock_CB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeverLock_CB.Location = new System.Drawing.Point(17, 163);
            this.NeverLock_CB.Name = "NeverLock_CB";
            this.NeverLock_CB.Size = new System.Drawing.Size(124, 32);
            this.NeverLock_CB.TabIndex = 8;
            this.NeverLock_CB.Text = "Never lock";
            this.NeverLock_CB.UseVisualStyleBackColor = true;
            // 
            // Neverlock_GB
            // 
            this.Neverlock_GB.Controls.Add(this.NeverlockEnable_CB);
            this.Neverlock_GB.Controls.Add(this.NeverlockDisable_CB);
            this.Neverlock_GB.Location = new System.Drawing.Point(180, 154);
            this.Neverlock_GB.Name = "Neverlock_GB";
            this.Neverlock_GB.Size = new System.Drawing.Size(200, 45);
            this.Neverlock_GB.TabIndex = 11;
            this.Neverlock_GB.TabStop = false;
            // 
            // NeverlockEnable_CB
            // 
            this.NeverlockEnable_CB.AutoSize = true;
            this.NeverlockEnable_CB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeverlockEnable_CB.Location = new System.Drawing.Point(6, 8);
            this.NeverlockEnable_CB.Name = "NeverlockEnable_CB";
            this.NeverlockEnable_CB.Size = new System.Drawing.Size(88, 32);
            this.NeverlockEnable_CB.TabIndex = 10;
            this.NeverlockEnable_CB.Text = "Enable";
            this.NeverlockEnable_CB.UseVisualStyleBackColor = true;
            // 
            // NeverlockDisable_CB
            // 
            this.NeverlockDisable_CB.AutoSize = true;
            this.NeverlockDisable_CB.Checked = true;
            this.NeverlockDisable_CB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeverlockDisable_CB.Location = new System.Drawing.Point(100, 8);
            this.NeverlockDisable_CB.Name = "NeverlockDisable_CB";
            this.NeverlockDisable_CB.Size = new System.Drawing.Size(94, 32);
            this.NeverlockDisable_CB.TabIndex = 10;
            this.NeverlockDisable_CB.TabStop = true;
            this.NeverlockDisable_CB.Text = "Disable";
            this.NeverlockDisable_CB.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            this.Aboutmoz_GB.ResumeLayout(false);
            this.Aboutmoz_GB.PerformLayout();
            this.PfD_GB.ResumeLayout(false);
            this.PfD_GB.PerformLayout();
            this.Neverlock_GB.ResumeLayout(false);
            this.Neverlock_GB.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox Aboutmoz_CB;
        private System.Windows.Forms.RadioButton AboutmozDisable_CB;
        private System.Windows.Forms.RadioButton AboutmozEnable_CB;
        private System.Windows.Forms.GroupBox PfD_GB;
        private System.Windows.Forms.GroupBox Aboutmoz_GB;
        private System.Windows.Forms.GroupBox Neverlock_GB;
        private System.Windows.Forms.RadioButton NeverlockEnable_CB;
        private System.Windows.Forms.RadioButton NeverlockDisable_CB;
        private System.Windows.Forms.CheckBox NeverLock_CB;
    }
}

