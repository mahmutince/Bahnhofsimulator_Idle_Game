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
    public partial class station : Form
    {
        public static double money = 0;
        public static byte current = 0;
        public static byte station_capacity = 50;
        public static byte bus_capacity = 10;
        public static byte train_capacity = 50;
        public static byte train_speed = 20;
        public static byte bus_speed = 10;
        public static double ticket = 3;
    
        public station()
        {
            InitializeComponent();
            progressBus.Minimum = 0;
            progressBus.Maximum = 100;
            progressTrain.Minimum = 0;
            progressTrain.Maximum = 100;
        }
        private void main_Load(object sender, EventArgs e)
        {
            timerTrain.Enabled = true;
        }
 
       

        private void timerTrain_Tick(object sender, EventArgs e)//TRAIN TIMER
        {
            timerTrain.Interval = 1000;
            if (progressTrain.Value == progressTrain.Maximum)
            {
                progressTrain.Value = 0;

                if (current >= train_capacity)
                {
                    money += train_capacity * ticket;
                    current -= train_capacity;
                }
                else
                {
                    money += current * ticket;
                    current = 0;
                }

                buttonTransfer.Text = "Stations kapazität: " + current.ToString() + "/" + station_capacity.ToString();



            }
            else
            {
                progressTrain.Value += 5;
            }

        }

        private void timerBus_Tick(object sender, EventArgs e)//BUS TIMER
        {
            timerBus.Interval = 1000;
            if (progressBus.Value == progressBus.Maximum)
            {
                progressBus.Value = 0;
                if (station_capacity >= (bus_capacity + current))
                {

                    current += bus_capacity;
                    buttonTransfer.Text = "Stations kapazität: " + current.ToString() + "/" + station_capacity.ToString();
                    timerBus.Stop();

                }

                else
                {
                    current = station_capacity;
                    buttonTransfer.Text = "Stations kapazität: " + current.ToString() + "/" + station_capacity.ToString();
                    timerBus.Stop();
                }

            }
            else
            {
                progressBus.Value += 10;

            }

        }

        private void buttonTransfer_Click(object sender, EventArgs e)//TRANSFER PASSENGER
        {
            timerBus.Enabled = true;
        }

        private void timerDriver_Tick(object sender, EventArgs e) //DRIVER TIMER
        {
            timerDriver.Interval = 1000;
            if (progressBus.Value == progressBus.Maximum)
            {
                progressBus.Value = 0;
                if (station_capacity >= (bus_capacity + current))
                {

                    current += bus_capacity;
                    buttonTransfer.Text = "Stations kapazität: " + current.ToString() + "/" + station_capacity.ToString();
                    timerBus.Stop();

                }

                else
                {
                    current = station_capacity;
                    buttonTransfer.Text = "Stations kapazität: " + current.ToString() + "/" + station_capacity.ToString();
                    timerBus.Stop();
                }

            }
            else
            {
                progressBus.Value += 10;

            }


        }


    }
}
