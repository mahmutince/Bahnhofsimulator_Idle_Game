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
    public partial class upgrade : Form
    {
        short cost_station_capacity = 200;
        short cost_bus_capacity = 50;
        short cost_train_capacity = 100;
        short cost_train_speed = 50;
        short cost_bus_speed = 50;
        public upgrade()
        {
            InitializeComponent();
        }

        private void buttonStationCap_Click(object sender, EventArgs e)//UPGRADE STATION CAPACITY
        {
            station s = (station)Application.OpenForms["station"];
            if (station.money >= cost_station_capacity && station.station_capacity < 190)
            {
                station.money -= cost_station_capacity;
                station.station_capacity += 10;
                cost_station_capacity += 100;
                buttonStationCap.Text = "Erhöhung der Stationskapazität 10 : " + cost_station_capacity.ToString() + " tl";
            }
            if (station.money >= cost_station_capacity && station.station_capacity == 190)
            {
                station.money -= cost_station_capacity;
                station.station_capacity += 10;
                cost_station_capacity += 100;
                buttonStationCap.Text = "Maximales Level";
                buttonStationCap.Enabled = false;
            }
            s.buttonTransfer.Text = "Stations kapazität : " + station.current.ToString() + "/" + station.station_capacity.ToString();


        }

        private void buttonBusCap_Click(object sender, EventArgs e)//UPGRADE BUS CAPACITY
        {
            station s = (station)Application.OpenForms["station"];
            if (station.money >= cost_bus_capacity && station.bus_capacity < 90)
            {
                station.money -= cost_bus_capacity;
                station.bus_capacity += 10;
                cost_bus_capacity += 50;
                buttonBusCap.Text = "Erhöhung der Buskapazität 10 : " + cost_bus_capacity.ToString() + " tl";
            }
            else if (station.money >= cost_bus_capacity && station.bus_capacity == 90)
            {
                station.money -= cost_bus_capacity;
                station.bus_capacity += 10;
                cost_bus_capacity += 50;
                buttonBusCap.Text = "Maximales Level";
                buttonBusCap.Enabled = false;
            }
            s.labelBusCap.Text = "Buskapazität: " + station.bus_capacity.ToString();

        }

        private void buttonTrainCap_Click(object sender, EventArgs e)//UPGRADE TRAIN CAPACITY
        {
            station s = (station)Application.OpenForms["station"];
            if (station.money >= cost_train_capacity && station.train_capacity < 190)
            {
                station.money -= cost_train_capacity;
                station.train_capacity += 10;
                cost_train_capacity += 50;
                buttonTrainCap.Text = "Erhöhung der Zugkapazität 10 : " + cost_train_capacity.ToString() + " tl";
            }
            else if (station.money >= cost_train_capacity && station.train_capacity == 190)
            {
                station.money -= cost_train_capacity;
                station.train_capacity += 10;
                cost_train_capacity += 50;
                buttonTrainCap.Text = "Maximales Level";
                buttonTrainCap.Enabled = false;
            }

            s.labelTrainCap.Text = "Zugkapazität: " + station.train_capacity.ToString();
        }

        private void buttonBusSpeed_Click(object sender, EventArgs e)//UPGRADE BUS SPEED
        {
            station s = (station)Application.OpenForms["station"];
            if (station.money >= cost_bus_speed && station.bus_speed > 3)
            {
                station.money -= cost_bus_speed;
                station.bus_speed -= 1;
                cost_bus_speed += 50;
                s.progressBus.Maximum -= 10;
                buttonBusSpeed.Text = "Erhöhung der Busgeschwindigkeit 1 sek : " + cost_bus_speed.ToString() + " tl";
            }
            else if (station.money >= cost_bus_speed && station.bus_speed <= 3)
            {
                station.money -= cost_bus_speed;
                station.bus_speed -= 1;
                cost_bus_speed += 50;
                s.progressBus.Maximum -= 10;
                buttonBusSpeed.Text = "Maximales Level";
                buttonBusSpeed.Enabled = false;
            }

            s.labelBusSpeed.Text = "Busgeschwindigkeit: " + station.bus_speed.ToString() + "sek";

        }

        private void buttonTrainSpeed_Click(object sender, EventArgs e)//UPGRADE TRAIN SPEED
        {
            station s = (station)Application.OpenForms["station"];
            if (station.money >= cost_train_speed && station.train_speed > 6)
            {
                station.money -= cost_train_speed;
                station.train_speed -= 2;
                cost_train_speed += 50;
                s.progressTrain.Maximum -= 10;
                buttonTrainSpeed.Text = "Erhöhung der Zuggeschwindigkeit 2 sek : " + cost_train_speed.ToString() + " tl";
            }
            else if (station.money >= cost_train_speed && station.train_speed <= 6)
            {
                station.money -= cost_train_speed;
                station.train_speed -= 2;
                cost_train_speed += 50;
                s.progressTrain.Maximum -= 10;
                buttonTrainSpeed.Text = "Maximales Level";
                buttonTrainSpeed.Enabled = false;
            }
            s.labelTrainSpeed.Text = "Zuggeschwindigkeit: " + station.train_speed.ToString() + "sek";
        }
    }
}
