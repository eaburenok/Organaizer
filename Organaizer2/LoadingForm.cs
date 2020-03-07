using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;
using MetroFramework;
using System.Threading;

namespace Organaizer2
{
    public partial class LoadingForm : MetroForm
    {
        private Form1 _MainForm = null;
        public LoadingForm(Form1 parent)
        {
            InitializeComponent();
            this._MainForm = parent;


            int LocantionPointFromX = _MainForm.DesktopLocation.X;
            int LocantionPointFromY = _MainForm.DesktopLocation.Y;
            this.Location = new Point(LocantionPointFromX, LocantionPointFromY);

            int SizeFormHeight = _MainForm.Size.Height;
            int SizeFormWidth = _MainForm.Size.Width;

            this.Size = new Size(SizeFormWidth, SizeFormHeight);

           

            if (_MainForm.InvokeRequired)
                BeginInvoke(new MethodInvoker(() => _MainForm.Hide()));
            else
                _MainForm.Hide();

            this.Show();

            for (int i = 0; i < 50; i++)
            {

                this.Opacity = this.Opacity - 0.02;
                if (this.Opacity == 0)
                {
                    i = 49;

                }
                pictureBox1.Refresh();
                metroLabel1.Refresh();
                Thread.Sleep(10);


            }

           

        }

       
    }






}
