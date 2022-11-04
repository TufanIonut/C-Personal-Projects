using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoclipuriYTB
{
    public partial class Video : Form
    {
        public bool eMax = false;
        public Video()
        {
            InitializeComponent();
        }

        private void Video_Load(object sender, EventArgs e)
        {
            webBrowser2.Navigate(Global.S);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            webBrowser2.Dispose();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (!eMax)
            {
                this.WindowState = FormWindowState.Maximized;
                eMax = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                eMax = false;
            }
        }
    }
}
