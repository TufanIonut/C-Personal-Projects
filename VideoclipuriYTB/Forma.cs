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
   
    public partial class Forma : Form
    {
        ResurseEntities db = new ResurseEntities();
        
        public Forma()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
         Global.S =listbox.SelectedItem.ToString();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
          
           
                foreach(var item in db.Categorii)
                {                  
                    cboxCt.Items.Add(item.Nume_Categorie);
                }

                cboxCt.TextChanged += delegate
                {cboxTg.Items.Clear();
                    var t = db.Categorii.FirstOrDefault(x => x.Nume_Categorie == cboxCt.Text).Taguri.ToList();
                    foreach(var item in t)
                    {
                        cboxTg.Items.Add(item.Tag);
                    }
                    cboxTg.Text.Trim();
                    

                };

            }

        

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
           //============================ 
            listbox.Items.Clear();
           var m= db.Videoclipuri.Where(x => x.Taguri.Tag == cboxTg.Text.Trim()).Select(y=>y.Link);
            foreach(var item in m)
            {
                listbox.Items.Add(item);
            }
            
            
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            Video v = new Video();
            v.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             this.Hide();
            welcome w = new welcome();
            w.ShowDialog();
           this.Close();
        }
    }
}
