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
using System.Threading;
using MetroFramework.Forms;
using MetroFramework.Components;
using MetroFramework;
using System.Data.SqlClient;

namespace Organaizer2
{
    public partial class Form1 : MetroForm
    {
     

        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string connectionString = @"Data Source = LAPTOP-B3D7R5IQ;Initial Catalog = TestERwin; Integrated Security = True";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {





            }




        }


        
      
   

        public void NewThread(object sender, EventArgs e)
        {
            
          
        }

        private void черновикToolStripMenuItem1_Click(object sender)
        {
            черновикToolStripMenuItem1_Click(sender, new EventArgs ());
        }


        private void  черновикToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DraftForm draftForm = new DraftForm();
    


            int LocantionPointFromX = this.DesktopLocation.X;
            int LocantionPointFromY = this.DesktopLocation.Y;
            draftForm.Location = new Point(LocantionPointFromX, LocantionPointFromY);

            int SizeFormHeight = this.Size.Height;
            int SizeFormWidth = this.Size.Width;

            draftForm.Size = new Size(SizeFormWidth, SizeFormHeight);

            draftForm.Show();


            LoadingForm LoadingForm = new LoadingForm(this);
            LoadingForm.Hide();
                 

            
        }

    }
}