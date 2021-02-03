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
    public partial class settings : Form
    {
        int hour = 0, min = 0, sec = 0;
        public settings()
        {
            InitializeComponent();
        }

        private void tlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            station.money += 1000;
        }

        private void mietenSieEinenFahrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            station s = (station)Application.OpenForms["station"];
            management m = (management)Application.OpenForms["management"];
            s.timerBus.Enabled = false;
            s.timerDriver.Enabled = true;
            m.buttonDriver.Text = "Der Fahrer arbeitet.";
            m.buttonDriver.Enabled = false;
            s.buttonTransfer.Enabled = false;

        }

        private void unbegrenztesGeldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Screen s = (Screen)Application.OpenForms["screen"];
            station.money += 999999999;
            s.labelMoney.Text = "Geld:\nUnbegrenztes";
            s.timerMoneyChanged.Enabled = false;

        }

        private void settings_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            timerTime.Enabled = true;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                menuStrip1.Visible = true;
            }
            else if (checkBox1.Checked==false)
            {
                menuStrip1.Visible = false;
            }
        }

   
        private void buttonChangeName_Click(object sender, EventArgs e)
        {
            management m = (management)Application.OpenForms["management"];
            m.labelName.Text = textBoxChange.Text;
            

        }

        private void timerTime_Tick(object sender, EventArgs e)
        {          
            timerTime.Interval = 1000;            
            sec += 1;
            if (sec == 60)
            {
                sec = 0;
                min += 1;
                if (min == 60)
                {
                    min = 0;
                    hour += 1;
                }
            }
            labelTimer.Text = hour.ToString() + ":" + min.ToString() + ":" + sec.ToString();
            labelHour.Text = DateTime.Now.ToLongTimeString();

        }
    }
}
