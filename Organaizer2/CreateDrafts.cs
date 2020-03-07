using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organaizer2
{
    public partial class CreateDrafts : Form
    {
        DraftForm _dr_f;
        public CreateDrafts(DraftForm df)
        {
            _dr_f = df;
            InitializeComponent();


        }


     



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string path = @"C:\Users\eaburenok\Desktop\files\drafts\"+ textBox1.Text + ".txt";

                using (FileStream fs = File.Create(path))
                {


                }

                using (StreamWriter Sw = File.CreateText(path))
                {

                    Sw.WriteLine(textBox2.Text);


                }


                _dr_f.pictureBox1_Click(null, null);
                this.Hide();


            }
            else if (textBox1.Text == null || textBox1.Text == "")
            {
                MessageBox.Show("Введите название черновика");

             
            }
        }
    }
}
