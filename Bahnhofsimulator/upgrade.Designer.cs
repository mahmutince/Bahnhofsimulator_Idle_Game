namespace Bahnhofsimulator
{
    partial class upgrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(upgrade));
            this.buttonTrainSpeed = new System.Windows.Forms.Button();
            this.buttonBusSpeed = new System.Windows.Forms.Button();
            this.buttonTrainCap = new System.Windows.Forms.Button();
            this.buttonBusCap = new System.Windows.Forms.Button();
            this.buttonStationCap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTrainSpeed
            // 
            this.buttonTrainSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrainSpeed.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTrainSpeed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTrainSpeed.Location = new System.Drawing.Point(12, 277);
            this.buttonTrainSpeed.Name = "buttonTrainSpeed";
            this.buttonTrainSpeed.Size = new System.Drawing.Size(421, 47);
            this.buttonTrainSpeed.TabIndex = 2;
            this.buttonTrainSpeed.Text = "Erhöhung der Zuggeschwindigkeit 2 sek : 50 tl";
            this.buttonTrainSpeed.UseVisualStyleBackColor = true;
            this.buttonTrainSpeed.Click += new System.EventHandler(this.buttonTrainSpeed_Click);
            // 
            // buttonBusSpeed
            // 
            this.buttonBusSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBusSpeed.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBusSpeed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBusSpeed.Location = new System.Drawing.Point(12, 224);
            this.buttonBusSpeed.Name = "buttonBusSpeed";
            this.buttonBusSpeed.Size = new System.Drawing.Size(421, 47);
            this.buttonBusSpeed.TabIndex = 2;
            this.buttonBusSpeed.Text = "Erhöhung der Busgeschwindigkeit 1 sek : 50 tl";
            this.buttonBusSpeed.UseVisualStyleBackColor = true;
            this.buttonBusSpeed.Click += new System.EventHandler(this.buttonBusSpeed_Click);
            // 
            // buttonTrainCap
            // 
            this.buttonTrainCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrainCap.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTrainCap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTrainCap.Location = new System.Drawing.Point(12, 171);
            this.buttonTrainCap.Name = "buttonTrainCap";
            this.buttonTrainCap.Size = new System.Drawing.Size(421, 47);
            this.buttonTrainCap.TabIndex = 2;
            this.buttonTrainCap.Text = "Erhöhung der Zugkapazität 10 : 100 tl";
            this.buttonTrainCap.UseVisualStyleBackColor = true;
            this.buttonTrainCap.Click += new System.EventHandler(this.buttonTrainCap_Click);
            // 
            // buttonBusCap
            // 
            this.buttonBusCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBusCap.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBusCap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBusCap.Location = new System.Drawing.Point(12, 118);
            this.buttonBusCap.Name = "buttonBusCap";
            this.buttonBusCap.Size = new System.Drawing.Size(421, 47);
            this.buttonBusCap.TabIndex = 2;
            this.buttonBusCap.Text = "Erhöhung der Buskapazität 10 : 50 tl";
            this.buttonBusCap.UseVisualStyleBackColor = true;
            this.buttonBusCap.Click += new System.EventHandler(this.buttonBusCap_Click);
            // 
            // buttonStationCap
            // 
            this.buttonStationCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStationCap.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonStationCap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStationCap.Location = new System.Drawing.Point(12, 65);
            this.buttonStationCap.Name = "buttonStationCap";
            this.buttonStationCap.Size = new System.Drawing.Size(421, 47);
            this.buttonStationCap.TabIndex = 2;
            this.buttonStationCap.Text = "Erhöhung der Stationskapazität 10 : 200 tl\r\n";
            this.buttonStationCap.UseVisualStyleBackColor = true;
            this.buttonStationCap.Click += new System.EventHandler(this.buttonStationCap_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 59);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Verbessern";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // upgrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(445, 336);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonStationCap);
            this.Controls.Add(this.buttonBusCap);
            this.Controls.Add(this.buttonTrainCap);
            this.Controls.Add(this.buttonBusSpeed);
            this.Controls.Add(this.buttonTrainSpeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "upgrade";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "update";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTrainSpeed;
        private System.Windows.Forms.Button buttonBusSpeed;
        private System.Windows.Forms.Button buttonTrainCap;
        private System.Windows.Forms.Button buttonBusCap;
        private System.Windows.Forms.Button buttonStationCap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}