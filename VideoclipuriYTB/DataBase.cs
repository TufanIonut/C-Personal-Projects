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
    public partial class DataBase : Form
    {
        public DataBase()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome x = new welcome();
            x.ShowDialog();
            
          
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          using(ResurseEntities db = new ResurseEntities())
            { 
                Categorii c;
                if (db.Categorii.Any(x => x.Nume_Categorie == categorieTextBox.Text))
                {
                    c = db.Categorii.FirstOrDefault(x => x.Nume_Categorie == categorieTextBox.Text);

                }
                else
                {
                    c=db.Categorii.Add(new Categorii { Nume_Categorie = categorieTextBox.Text });
                    db.SaveChanges();
                }
                Taguri t ;
                if (db.Taguri.Any(x => x.Tag == tagTextBox.Text))
                {
                    t = db.Taguri.FirstOrDefault(x => x.Tag == tagTextBox.Text);                }
                else
                {
                    
                   t=db.Taguri.Add(new Taguri
                    {
                        
                        Tag = tagTextBox.Text,
                        Categorie = c.Id_Categorie

                    });
                    db.SaveChanges();

                }
                db.Videoclipuri.Add((new Videoclipuri
                {
                    Link = linkTextBox.Text,
                    Tag = t.Id_Tag
                })) ;
              db.SaveChanges();

                linkTextBox.Clear();
                tagTextBox.Clear();
                categorieTextBox.Clear();
                linkTextBox.Focus();
            }
        }
        private void DataBase_Load(object sender, EventArgs e)
        {
            
        }
    }
}
