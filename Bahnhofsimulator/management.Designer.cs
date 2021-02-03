namespace Bahnhofsimulator
{
    partial class management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(management));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDriver = new System.Windows.Forms.Button();
            this.buttonTicket = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelGeschlecht = new System.Windows.Forms.Label();
            this.labelBeruf = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 59);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Verwaltung";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonDriver
            // 
            this.buttonDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDriver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDriver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDriver.Location = new System.Drawing.Point(12, 214);
            this.buttonDriver.Name = "buttonDriver";
            this.buttonDriver.Size = new System.Drawing.Size(421, 52);
            this.buttonDriver.TabIndex = 1;
            this.buttonDriver.Text = "Mieten Sie einen Fahrer: 5000 TL";
            this.buttonDriver.UseVisualStyleBackColor = true;
            this.buttonDriver.Click += new System.EventHandler(this.buttonDriver_Click);
            // 
            // buttonTicket
            // 
            this.buttonTicket.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTicket.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTicket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTicket.Location = new System.Drawing.Point(12, 272);
            this.buttonTicket.Name = "buttonTicket";
            this.buttonTicket.Size = new System.Drawing.Size(421, 52);
            this.buttonTicket.TabIndex = 1;
            this.buttonTicket.Text = "Erhöhung des Ticketpreises um 0.5tl : 50 tl";
            this.buttonTicket.UseVisualStyleBackColor = true;
            this.buttonTicket.Click += new System.EventHandler(this.buttonTicket_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelName.Location = new System.Drawing.Point(12, 106);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 46);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Namen\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Charaktereigenschaften:";
            // 
            // labelGeschlecht
            // 
            this.labelGeschlecht.AutoSize = true;
            this.labelGeschlecht.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGeschlecht.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelGeschlecht.Location = new System.Drawing.Point(12, 129);
            this.labelGeschlecht.Name = "labelGeschlecht";
            this.labelGeschlecht.Size = new System.Drawing.Size(123, 23);
            this.labelGeschlecht.TabIndex = 2;
            this.labelGeschlecht.Text = "Geschlecht";
            // 
            // labelBeruf
            // 
            this.labelBeruf.AutoSize = true;
            this.labelBeruf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBeruf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelBeruf.Location = new System.Drawing.Point(12, 152);
            this.labelBeruf.Name = "labelBeruf";
            this.labelBeruf.Size = new System.Drawing.Size(123, 23);
            this.labelBeruf.TabIndex = 2;
            this.labelBeruf.Text = "Geschlecht";
            // 
            // management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(445, 336);
            this.Controls.Add(this.labelBeruf);
            this.Controls.Add(this.labelGeschlecht);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonTicket);
            this.Controls.Add(this.buttonDriver);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "management";
            this.Text = "management";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTicket;
        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelGeschlecht;
        public System.Windows.Forms.Button buttonDriver;
        public System.Windows.Forms.Label labelBeruf;
    }
}