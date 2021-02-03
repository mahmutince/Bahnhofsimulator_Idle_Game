namespace Bahnhofsimulator
{
    partial class settings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.buttonChangeName = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxChange = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hilelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mietenSieEinenFahrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unbegrenztesGeldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 59);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Einstellungen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.labelHour);
            this.panel2.Controls.Add(this.labelTimer);
            this.panel2.Controls.Add(this.buttonChangeName);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.textBoxChange);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 277);
            this.panel2.TabIndex = 33;
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHour.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHour.Location = new System.Drawing.Point(311, 247);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(54, 21);
            this.labelHour.TabIndex = 5;
            this.labelHour.Text = "zeit";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTimer.Location = new System.Drawing.Point(295, 54);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(124, 27);
            this.labelTimer.TabIndex = 5;
            this.labelTimer.Text = "00:00:00";
            // 
            // buttonChangeName
            // 
            this.buttonChangeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonChangeName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonChangeName.Location = new System.Drawing.Point(315, 104);
            this.buttonChangeName.Name = "buttonChangeName";
            this.buttonChangeName.Size = new System.Drawing.Size(104, 48);
            this.buttonChangeName.TabIndex = 4;
            this.buttonChangeName.Text = "Bestätigt";
            this.buttonChangeName.UseVisualStyleBackColor = true;
            this.buttonChangeName.Click += new System.EventHandler(this.buttonChangeName_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox1.Location = new System.Drawing.Point(12, 174);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(196, 27);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Betrügen ist aktiv";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxChange
            // 
            this.textBoxChange.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxChange.Location = new System.Drawing.Point(12, 130);
            this.textBoxChange.Name = "textBoxChange";
            this.textBoxChange.Size = new System.Drawing.Size(282, 22);
            this.textBoxChange.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(8, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Zeit, die Sie gespielt haben:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(8, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Namen ändern";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hilelerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hilelerToolStripMenuItem
            // 
            this.hilelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlToolStripMenuItem,
            this.mietenSieEinenFahrerToolStripMenuItem,
            this.unbegrenztesGeldToolStripMenuItem});
            this.hilelerToolStripMenuItem.Name = "hilelerToolStripMenuItem";
            this.hilelerToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.hilelerToolStripMenuItem.Text = "Betrügen";
            // 
            // tlToolStripMenuItem
            // 
            this.tlToolStripMenuItem.Name = "tlToolStripMenuItem";
            this.tlToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.tlToolStripMenuItem.Text = "+1000 tl";
            this.tlToolStripMenuItem.Click += new System.EventHandler(this.tlToolStripMenuItem_Click);
            // 
            // mietenSieEinenFahrerToolStripMenuItem
            // 
            this.mietenSieEinenFahrerToolStripMenuItem.Name = "mietenSieEinenFahrerToolStripMenuItem";
            this.mietenSieEinenFahrerToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.mietenSieEinenFahrerToolStripMenuItem.Text = "Mieten Sie einen Fahrer";
            this.mietenSieEinenFahrerToolStripMenuItem.Click += new System.EventHandler(this.mietenSieEinenFahrerToolStripMenuItem_Click);
            // 
            // unbegrenztesGeldToolStripMenuItem
            // 
            this.unbegrenztesGeldToolStripMenuItem.Name = "unbegrenztesGeldToolStripMenuItem";
            this.unbegrenztesGeldToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.unbegrenztesGeldToolStripMenuItem.Text = "Unbegrenztes Geld";
            this.unbegrenztesGeldToolStripMenuItem.Click += new System.EventHandler(this.unbegrenztesGeldToolStripMenuItem_Click);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 336);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "settings";
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hilelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mietenSieEinenFahrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unbegrenztesGeldToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonChangeName;
        public System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerTime;
        public System.Windows.Forms.Label labelHour;
    }
}