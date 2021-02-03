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
    public partial class management : Form
    {
        short cost_ticket = 50;
        public static bool isaDriver=false;
        public management()
        {
            InitializeComponent();
        }

        private void buttonDriver_Click(object sender, EventArgs e)//HIRE A DRIVER
        {
            station m = (station)Application.OpenForms["station"];
            if (isaDriver==false)
            {
                if (station.money >= 5000)
                {
                    station.money -= 5000;
                    m.timerBus.Enabled = false;
                    m.timerDriver.Enabled = true;
                    buttonDriver.Text = "Der Fahrer arbeitet";
                    buttonDriver.Enabled = false;
                    m.buttonTransfer.Enabled = false;
                }

            }
            else 
            {
                MessageBox.Show("Du bist ein Fahrer");
               
            }
            
            
        }

        private void buttonTicket_Click(object sender, EventArgs e)//INCREASE TICKET PRICE
        {
            station m = (station)Application.OpenForms["station"];            
            if (station.money >= cost_ticket && station.ticket < 9.5)
            {
                station.money -= cost_ticket;
                station.ticket += 0.5;
                cost_ticket += 50;
                buttonTicket.Text = "Erhöhung des Ticketpreises um 0.5tl : " + cost_ticket.ToString() + " tl";
                
            }
            else if (station.money >= cost_ticket && station.ticket == 9.5)
            {
                station.money -= cost_ticket;
                station.ticket += 0.5;
                cost_ticket += 50;
                buttonTicket.Text = "Maximales Level";
                buttonTicket.Enabled = false;
            }

            m.labelTicket.Text = "Ticket Preis: " + station.ticket.ToString() + "tl";
            
        }
    }
}
