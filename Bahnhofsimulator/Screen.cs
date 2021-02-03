using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bahnhofsimulator
{
    public partial class Screen : Form
    {
        public Screen()
        {
            InitializeComponent();
        }
        public static bool schliess = false;
        int x, y;       
        private void Screen_Load(object sender, EventArgs e)
        {
            
            Create c = new Create();
            OpenForm(c, panelCreate);            
            station m = new station();
            OpenForm(m, panelMain);
            management mng = new management();
            OpenForm(mng, panelManagement);
            upgrade u = new upgrade();
            OpenForm(u, panelUpgrade);
            settings s = new settings();
            OpenForm(s, panelSettings);
            panelTop.Visible = false;
            timerMoneyChanged.Enabled = true;


            foreach (TabPage item in tabControl1.TabPages)
            {
                if (item.Name == "tabPageCreate")
                {
                }
                else if (item.Name != "tabPageCreate")
                {
                    item.Parent = null;
                }
            }

           
        }

        private void timerMoneyChanged_Tick(object sender, EventArgs e)
        {
            labelMoney.Text = "Geld: " + station.money.ToString() + "tl";

        }
            
    

        private void buttonManagement_Click(object sender, EventArgs e)
        {
            OpenPage(tabPageManagement);

        }

        private void buttonUpgrade_Click(object sender, EventArgs e)
        {
            OpenPage(tabPageUpgrade);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            OpenPage(tabPageSettings);
        }

        private void buttonStation_Click(object sender, EventArgs e)
        {
            OpenPage(tabPageHome);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OpenForm(Form f, Panel p)
        {
            f.MdiParent = this;
            p.Controls.Add(f);
            f.Show();
            f.BringToFront();
        }
        
        private void OpenPage(TabPage t)
        {
           
            while (t.Parent==null)
            {
                tabPageHome.Parent = null;
                tabPageManagement.Parent = null;
                tabPageUpgrade.Parent = null;
                tabPageSettings.Parent = null;
                t.Parent = tabControl1;
                tabControl1.SelectedTab = t;

            }

        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMinize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;

            }
                
            this.Left += e.X - x;
            this.Top += e.Y - y;


        }

       
    }
}
