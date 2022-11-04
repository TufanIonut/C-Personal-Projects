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
    public partial class ViewData : Form
    {
        public ViewData()
        {
            InitializeComponent();
        }

        private void ViewData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resurseDataSet.Taguri' table. You can move, or remove it, as needed.
            this.taguriTableAdapter.Fill(this.resurseDataSet.Taguri);
            // TODO: This line of code loads data into the 'resurseDataSet.Categorii' table. You can move, or remove it, as needed.
            this.categoriiTableAdapter.Fill(this.resurseDataSet.Categorii);
            // TODO: This line of code loads data into the 'resurseDataSet.Videoclipuri' table. You can move, or remove it, as needed.
            this.videoclipuriTableAdapter.Fill(this.resurseDataSet.Videoclipuri);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome w = new welcome();
            w.ShowDialog();
            this.Close();
        }
    }
}
