using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyRegistryEditor
{
    public partial class ConfigLoader : Form
    {
        public ConfigLoader()
        {
            InitializeComponent();
        }

        private void ConfigLoader_Load(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.Show();
            Application.DoEvents();
            this.Opacity = 0;
            this.Hide();
        }
    }
}
