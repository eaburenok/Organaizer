using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;
using MetroFramework;

namespace Organaizer2
{
    public partial class DraftForm : MetroForm
    {

       


        public DraftForm()
        {
            InitializeComponent();

           
        }

        private void DraftForm_Load(object sender, EventArgs e)
        {

            textBox1.Visible = false;
            button3.Visible = false;

            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\79644\Desktop\Organaizer2\files\drafts");


            

            foreach (var el in dir.GetFiles())
            {

               
                listbox1.Items.Add(el.Name);
              
               
                

            }


        }

   

      

      

        private void button1_Click(object sender, EventArgs e)
        {
            CreateDrafts createDrafts = new CreateDrafts(this);
            createDrafts.Size = new Size(700, 400);

            createDrafts.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\79644\Desktop\Organaizer2\files\drafts\" + listbox1.Text;
            

            File.Delete(path);


            listbox1.Items.Clear();


            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\79644\Desktop\Organaizer2\files\drafts");

           


            foreach (var el in dir.GetFiles())
            {


                listbox1.Items.Add(el.Name);

            }

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\79644\Desktop\Organaizer2\files\drafts");

            listbox1.Items.Clear();


            foreach (var el in dir.GetFiles())
            {


                listbox1.Items.Add(el.Name);

            }

        }

        private void listbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = @"C:\Users\79644\Desktop\Organaizer2\files\drafts\" + listbox1.Text;

            if (File.Exists(path))
            {
                textBox1.Visible = true;
                button3.Visible = true;


                textBox1.Text = File.ReadAllText(path);


            }
         
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\79644\Desktop\Organaizer2\files\drafts\" + listbox1.Text;

            

            using (StreamWriter Sw = File.CreateText(path))
            {

                Sw.WriteLine(textBox1.Text);


            }
        }

        private void listbox1_MouseEnter(object sender, EventArgs e)
        {
            listbox1.ScrollAlwaysVisible = true;

        }

        private void listbox1_MouseLeave(object sender, EventArgs e)
        {
            listbox1.ScrollAlwaysVisible = false;
        }

        private void основноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form1 MainForm = new Form1();
            MainForm.Show();

            int LocantionPointFromX = this.DesktopLocation.X;
            int LocantionPointFromY = this.DesktopLocation.Y;
            MainForm.Location = new Point(LocantionPointFromX, LocantionPointFromY);


            int SizeFormHeight = this.Size.Height;
            int SizeFormWidth = this.Size.Width;
            MainForm.Size = new Size(SizeFormWidth, SizeFormHeight);

            for (int i = 0; i < 6; i++)
            {
                Thread.Sleep(35);
                this.Opacity = this.Opacity - 0.1;

            }


            this.Hide();
        }
    }
}
