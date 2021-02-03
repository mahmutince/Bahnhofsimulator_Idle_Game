namespace Bahnhofsimulator
{
    partial class Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen));
            this.timerMoneyChanged = new System.Windows.Forms.Timer(this.components);
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.panelUpgrade = new System.Windows.Forms.Panel();
            this.tabPageUpgrade = new System.Windows.Forms.TabPage();
            this.panelManagement = new System.Windows.Forms.Panel();
            this.tabPageManagement = new System.Windows.Forms.TabPage();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCreate = new System.Windows.Forms.TabPage();
            this.panelCreate = new System.Windows.Forms.Panel();
            this.panelMid = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.labelMoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpgrade = new System.Windows.Forms.Button();
            this.buttonManagement = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBoxMinize = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.buttonStation = new System.Windows.Forms.Button();
            this.labelPlace = new System.Windows.Forms.Label();
            this.tabPageSettings.SuspendLayout();
            this.tabPageUpgrade.SuspendLayout();
            this.tabPageManagement.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageCreate.SuspendLayout();
            this.panelMid.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // timerMoneyChanged
            // 
            this.timerMoneyChanged.Tick += new System.EventHandler(this.timerMoneyChanged_Tick);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.panelSettings);
            this.tabPageSettings.Location = new System.Drawing.Point(25, 4);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(451, 342);
            this.tabPageSettings.TabIndex = 3;
            this.tabPageSettings.Text = "Einstellungen";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // panelSettings
            // 
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(3, 3);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(445, 336);
            this.panelSettings.TabIndex = 0;
            // 
            // panelUpgrade
            // 
            this.panelUpgrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUpgrade.Location = new System.Drawing.Point(3, 3);
            this.panelUpgrade.Name = "panelUpgrade";
            this.panelUpgrade.Size = new System.Drawing.Size(445, 336);
            this.panelUpgrade.TabIndex = 0;
            // 
            // tabPageUpgrade
            // 
            this.tabPageUpgrade.Controls.Add(this.panelUpgrade);
            this.tabPageUpgrade.Location = new System.Drawing.Point(25, 4);
            this.tabPageUpgrade.Name = "tabPageUpgrade";
            this.tabPageUpgrade.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpgrade.Size = new System.Drawing.Size(451, 342);
            this.tabPageUpgrade.TabIndex = 2;
            this.tabPageUpgrade.Text = "Verbessern";
            this.tabPageUpgrade.UseVisualStyleBackColor = true;
            // 
            // panelManagement
            // 
            this.panelManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManagement.Location = new System.Drawing.Point(3, 3);
            this.panelManagement.Name = "panelManagement";
            this.panelManagement.Size = new System.Drawing.Size(445, 336);
            this.panelManagement.TabIndex = 0;
            // 
            // tabPageManagement
            // 
            this.tabPageManagement.Controls.Add(this.panelManagement);
            this.tabPageManagement.Location = new System.Drawing.Point(25, 4);
            this.tabPageManagement.Name = "tabPageManagement";
            this.tabPageManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManagement.Size = new System.Drawing.Size(451, 342);
            this.tabPageManagement.TabIndex = 1;
            this.tabPageManagement.Text = "Verwaltung";
            this.tabPageManagement.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(3, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(445, 336);
            this.panelMain.TabIndex = 0;
            // 
            // tabPageHome
            // 
            this.tabPageHome.Controls.Add(this.panelMain);
            this.tabPageHome.Location = new System.Drawing.Point(25, 4);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(451, 342);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPageHome);
            this.tabControl1.Controls.Add(this.tabPageManagement);
            this.tabControl1.Controls.Add(this.tabPageUpgrade);
            this.tabControl1.Controls.Add(this.tabPageSettings);
            this.tabControl1.Controls.Add(this.tabPageCreate);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 350);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCreate
            // 
            this.tabPageCreate.Controls.Add(this.panelCreate);
            this.tabPageCreate.Location = new System.Drawing.Point(25, 4);
            this.tabPageCreate.Name = "tabPageCreate";
            this.tabPageCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreate.Size = new System.Drawing.Size(451, 342);
            this.tabPageCreate.TabIndex = 4;
            this.tabPageCreate.Text = "Create";
            this.tabPageCreate.UseVisualStyleBackColor = true;
            // 
            // panelCreate
            // 
            this.panelCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCreate.Location = new System.Drawing.Point(3, 3);
            this.panelCreate.Name = "panelCreate";
            this.panelCreate.Size = new System.Drawing.Size(445, 336);
            this.panelCreate.TabIndex = 0;
            // 
            // panelMid
            // 
            this.panelMid.BackColor = System.Drawing.SystemColors.Control;
            this.panelMid.Controls.Add(this.tabControl1);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid.Location = new System.Drawing.Point(0, 135);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(480, 350);
            this.panelMid.TabIndex = 4;
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.Location = new System.Drawing.Point(243, 58);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(79, 75);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMoney.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMoney.Location = new System.Drawing.Point(328, 83);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(85, 21);
            this.labelMoney.TabIndex = 1;
            this.labelMoney.Text = "Geld: 0 tl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bahnhofsimulator - Clicker-Spiel";
            // 
            // buttonUpgrade
            // 
            this.buttonUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpgrade.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpgrade.Image")));
            this.buttonUpgrade.Location = new System.Drawing.Point(163, 58);
            this.buttonUpgrade.Name = "buttonUpgrade";
            this.buttonUpgrade.Size = new System.Drawing.Size(79, 75);
            this.buttonUpgrade.TabIndex = 0;
            this.buttonUpgrade.UseVisualStyleBackColor = true;
            this.buttonUpgrade.Click += new System.EventHandler(this.buttonUpgrade_Click);
            // 
            // buttonManagement
            // 
            this.buttonManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManagement.Image = ((System.Drawing.Image)(resources.GetObject("buttonManagement.Image")));
            this.buttonManagement.Location = new System.Drawing.Point(83, 58);
            this.buttonManagement.Name = "buttonManagement";
            this.buttonManagement.Size = new System.Drawing.Size(79, 75);
            this.buttonManagement.TabIndex = 0;
            this.buttonManagement.UseVisualStyleBackColor = true;
            this.buttonManagement.Click += new System.EventHandler(this.buttonManagement_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop.Controls.Add(this.pictureBoxMinize);
            this.panelTop.Controls.Add(this.pictureBoxExit);
            this.panelTop.Controls.Add(this.buttonStation);
            this.panelTop.Controls.Add(this.buttonSettings);
            this.panelTop.Controls.Add(this.labelPlace);
            this.panelTop.Controls.Add(this.labelMoney);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.buttonUpgrade);
            this.panelTop.Controls.Add(this.buttonManagement);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(480, 135);
            this.panelTop.TabIndex = 3;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // pictureBoxMinize
            // 
            this.pictureBoxMinize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinize.Image")));
            this.pictureBoxMinize.Location = new System.Drawing.Point(410, 16);
            this.pictureBoxMinize.Name = "pictureBoxMinize";
            this.pictureBoxMinize.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxMinize.TabIndex = 2;
            this.pictureBoxMinize.TabStop = false;
            this.pictureBoxMinize.Click += new System.EventHandler(this.pictureBoxMinize_Click);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(442, 16);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxExit.TabIndex = 2;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // buttonStation
            // 
            this.buttonStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStation.Image = ((System.Drawing.Image)(resources.GetObject("buttonStation.Image")));
            this.buttonStation.Location = new System.Drawing.Point(3, 58);
            this.buttonStation.Name = "buttonStation";
            this.buttonStation.Size = new System.Drawing.Size(79, 75);
            this.buttonStation.TabIndex = 0;
            this.buttonStation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonStation.UseVisualStyleBackColor = true;
            this.buttonStation.Click += new System.EventHandler(this.buttonStation_Click);
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.BackColor = System.Drawing.Color.Transparent;
            this.labelPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPlace.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPlace.Location = new System.Drawing.Point(328, 58);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(49, 21);
            this.labelPlace.TabIndex = 1;
            this.labelPlace.Text = "Platz";
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 485);
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Screen_Load);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageUpgrade.ResumeLayout(false);
            this.tabPageManagement.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCreate.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelUpgrade;
        private System.Windows.Forms.TabPage tabPageUpgrade;
        private System.Windows.Forms.Panel panelManagement;
        private System.Windows.Forms.TabPage tabPageManagement;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMid;
        private System.Windows.Forms.Button buttonSettings;
        public System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpgrade;
        private System.Windows.Forms.Button buttonManagement;
        private System.Windows.Forms.Button buttonStation;
        private System.Windows.Forms.Panel panelCreate;
        public System.Windows.Forms.Panel panelTop;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPageCreate;
        public System.Windows.Forms.TabPage tabPageHome;
        public System.Windows.Forms.Label labelPlace;
        public System.Windows.Forms.Timer timerMoneyChanged;
        private System.Windows.Forms.PictureBox pictureBoxMinize;
        private System.Windows.Forms.PictureBox pictureBoxExit;
    }
}

