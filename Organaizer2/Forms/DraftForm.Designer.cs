namespace Organaizer2
{
    partial class DraftForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.основноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.черновикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listbox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основноеМенюToolStripMenuItem,
            this.черновикиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(23, 69);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1275, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // основноеМенюToolStripMenuItem
            // 
            this.основноеМенюToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.основноеМенюToolStripMenuItem.Name = "основноеМенюToolStripMenuItem";
            this.основноеМенюToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.основноеМенюToolStripMenuItem.Text = "Основное меню";
            this.основноеМенюToolStripMenuItem.Click += new System.EventHandler(this.основноеМенюToolStripMenuItem_Click);
            // 
            // черновикиToolStripMenuItem
            // 
            this.черновикиToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.черновикиToolStripMenuItem.Name = "черновикиToolStripMenuItem";
            this.черновикиToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.черновикиToolStripMenuItem.Text = "Черновики";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(337, 109);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(663, 350);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(37, 483);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Создать новый черновик";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.GhostWhite;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(37, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Удалить выбранный";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Organaizer2.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(213, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listbox1
            // 
            this.listbox1.BackColor = System.Drawing.Color.GhostWhite;
            this.listbox1.FormattingEnabled = true;
            this.listbox1.ItemHeight = 15;
            this.listbox1.Location = new System.Drawing.Point(26, 109);
            this.listbox1.Name = "listbox1";
            this.listbox1.Size = new System.Drawing.Size(170, 349);
            this.listbox1.TabIndex = 6;
            this.listbox1.SelectedIndexChanged += new System.EventHandler(this.listbox1_SelectedIndexChanged);
            this.listbox1.MouseEnter += new System.EventHandler(this.listbox1_MouseEnter);
            this.listbox1.MouseLeave += new System.EventHandler(this.listbox1_MouseLeave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(820, 510);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 27);
            this.button3.TabIndex = 7;
            this.button3.Text = "Сохранить изменения";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(234, 487);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(114, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // DraftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 744);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listbox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DraftForm";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "DraftForm";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.DraftForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listbox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem основноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem черновикиToolStripMenuItem;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}