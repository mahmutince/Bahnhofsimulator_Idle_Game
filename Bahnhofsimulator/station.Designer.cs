namespace Bahnhofsimulator
{
    partial class station
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(station));
            this.labelTicket = new System.Windows.Forms.Label();
            this.labelBusSpeed = new System.Windows.Forms.Label();
            this.labelTrainSpeed = new System.Windows.Forms.Label();
            this.labelTrainCap = new System.Windows.Forms.Label();
            this.labelBusCap = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressTrain = new System.Windows.Forms.ProgressBar();
            this.progressBus = new System.Windows.Forms.ProgressBar();
            this.timerTrain = new System.Windows.Forms.Timer(this.components);
            this.timerBus = new System.Windows.Forms.Timer(this.components);
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.timerDriver = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTicket
            // 
            this.labelTicket.AutoSize = true;
            this.labelTicket.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTicket.Location = new System.Drawing.Point(10, 292);
            this.labelTicket.Name = "labelTicket";
            this.labelTicket.Size = new System.Drawing.Size(152, 23);
            this.labelTicket.TabIndex = 26;
            this.labelTicket.Text = "Ticket Preis: 3 tl";
            // 
            // labelBusSpeed
            // 
            this.labelBusSpeed.AutoSize = true;
            this.labelBusSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labelBusSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBusSpeed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBusSpeed.Location = new System.Drawing.Point(11, 152);
            this.labelBusSpeed.Name = "labelBusSpeed";
            this.labelBusSpeed.Size = new System.Drawing.Size(260, 23);
            this.labelBusSpeed.TabIndex = 25;
            this.labelBusSpeed.Text = "Busgeschwindigkeit: 10sek";
            // 
            // labelTrainSpeed
            // 
            this.labelTrainSpeed.AutoSize = true;
            this.labelTrainSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labelTrainSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTrainSpeed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTrainSpeed.Location = new System.Drawing.Point(11, 269);
            this.labelTrainSpeed.Name = "labelTrainSpeed";
            this.labelTrainSpeed.Size = new System.Drawing.Size(264, 23);
            this.labelTrainSpeed.TabIndex = 22;
            this.labelTrainSpeed.Text = "Zuggeschwindigkeit: 20sek";
            // 
            // labelTrainCap
            // 
            this.labelTrainCap.AutoSize = true;
            this.labelTrainCap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTrainCap.Location = new System.Drawing.Point(10, 246);
            this.labelTrainCap.Name = "labelTrainCap";
            this.labelTrainCap.Size = new System.Drawing.Size(170, 23);
            this.labelTrainCap.TabIndex = 20;
            this.labelTrainCap.Text = "Zugkapazität: 50";
            // 
            // labelBusCap
            // 
            this.labelBusCap.AutoSize = true;
            this.labelBusCap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBusCap.Location = new System.Drawing.Point(11, 129);
            this.labelBusCap.Name = "labelBusCap";
            this.labelBusCap.Size = new System.Drawing.Size(166, 23);
            this.labelBusCap.TabIndex = 19;
            this.labelBusCap.Text = "Buskapazität: 10";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // progressTrain
            // 
            this.progressTrain.BackColor = System.Drawing.Color.BurlyWood;
            this.progressTrain.Location = new System.Drawing.Point(99, 215);
            this.progressTrain.Name = "progressTrain";
            this.progressTrain.Size = new System.Drawing.Size(250, 23);
            this.progressTrain.TabIndex = 15;
            // 
            // progressBus
            // 
            this.progressBus.Location = new System.Drawing.Point(99, 96);
            this.progressBus.Name = "progressBus";
            this.progressBus.Size = new System.Drawing.Size(250, 23);
            this.progressBus.TabIndex = 14;
            // 
            // timerTrain
            // 
            this.timerTrain.Tick += new System.EventHandler(this.timerTrain_Tick);
            // 
            // timerBus
            // 
            this.timerBus.Tick += new System.EventHandler(this.timerBus_Tick);
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransfer.Image = ((System.Drawing.Image)(resources.GetObject("buttonTransfer.Image")));
            this.buttonTransfer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTransfer.Location = new System.Drawing.Point(348, 78);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(85, 186);
            this.buttonTransfer.TabIndex = 27;
            this.buttonTransfer.Text = "Stations kapazität 0/50\r\n";
            this.buttonTransfer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTransfer.UseVisualStyleBackColor = true;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // timerDriver
            // 
            this.timerDriver.Tick += new System.EventHandler(this.timerDriver_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bahnhof";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 59);
            this.panel1.TabIndex = 29;
            // 
            // station
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(445, 336);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.progressTrain);
            this.Controls.Add(this.labelTicket);
            this.Controls.Add(this.labelBusSpeed);
            this.Controls.Add(this.labelTrainSpeed);
            this.Controls.Add(this.labelTrainCap);
            this.Controls.Add(this.labelBusCap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "station";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelTicket;
        public System.Windows.Forms.Label labelBusSpeed;
        public System.Windows.Forms.Label labelTrainSpeed;
        public System.Windows.Forms.Label labelTrainCap;
        public System.Windows.Forms.Label labelBusCap;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Timer timerDriver;
        public System.Windows.Forms.Timer timerTrain;
        public System.Windows.Forms.Timer timerBus;
        public System.Windows.Forms.Button buttonTransfer;
        public System.Windows.Forms.ProgressBar progressTrain;
        public System.Windows.Forms.ProgressBar progressBus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}