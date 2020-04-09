namespace Organaizer2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.черновикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.основноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.черновикToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // черновикToolStripMenuItem
            // 
            this.черновикToolStripMenuItem.Name = "черновикToolStripMenuItem";
            this.черновикToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.monthCalendar1.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.Info;
            this.monthCalendar1.Location = new System.Drawing.Point(593, 110);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ScrollChange = 3;
            this.monthCalendar1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основноеМенюToolStripMenuItem,
            this.черновикToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(23, 69);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1086, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // основноеМенюToolStripMenuItem
            // 
            this.основноеМенюToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.основноеМенюToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.основноеМенюToolStripMenuItem.Name = "основноеМенюToolStripMenuItem";
            this.основноеМенюToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.основноеМенюToolStripMenuItem.Text = "Основное меню";
            // 
            // черновикToolStripMenuItem1
            // 
            this.черновикToolStripMenuItem1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.черновикToolStripMenuItem1.Name = "черновикToolStripMenuItem1";
            this.черновикToolStripMenuItem1.Size = new System.Drawing.Size(84, 20);
            this.черновикToolStripMenuItem1.Text = "Черновик";
            this.черновикToolStripMenuItem1.Visible = false;
            this.черновикToolStripMenuItem1.Click += new System.EventHandler(this.NewThread);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Location = new System.Drawing.Point(2, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 24);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1132, 645);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Основное меню";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem черновикToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem основноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem черновикToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

