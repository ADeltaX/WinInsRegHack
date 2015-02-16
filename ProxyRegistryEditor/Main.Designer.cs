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
            this.InfoProxy_Panel.SuspendLayout();
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
            this.SelectedLabel_LB.Size = new System.Drawing.Size(93, 5);
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
            this.Console_RTB.Location = new System.Drawing.Point(47, 274);
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
            this.Console_LB.Location = new System.Drawing.Point(43, 243);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu | Server Proxy: OFF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.InfoProxy_Panel.ResumeLayout(false);
            this.InfoProxy_Panel.PerformLayout();
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
    }
}

