/*
Created by Matthew Ho
Created on 12-02-15
Created for ICS3U
Assignment #8-01
This shows the vehicle's details using a class.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleClass
{
    public partial class frmVehicleClass : Form
    {
        public frmVehicleClass()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {//-this closes the program
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Variables
            double timeAccel;
            double timeBrake;
            double acceleration;
            double decceleration;

            //Assigning the values in the nud.
            timeAccel = Convert.ToDouble(this.nudTimeUp.Value);
            timeBrake = Convert.ToDouble(this.nudTimeBrake.Value);

            VehicleProperties vehicle = new VehicleProperties();

            acceleration = vehicle.Acceleration(timeAccel);
            decceleration = vehicle.Brakes(timeBrake);

            this.lstListbox.Items.Add(vehicle.CurrentState());
            this.lstListbox.Items.Add("The acceleration is " + acceleration + " m/s");
            this.lstListbox.Items.Add("The decceleration is " + decceleration + " m/s");
            this.lstListbox.Items.Add(" ");
        }
    }
}
