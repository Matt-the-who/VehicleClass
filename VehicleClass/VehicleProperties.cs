/*
Created by Matthew Ho
Created on 12-02-15
Created for ICS3U
Assignment #8-01
This is the vehicle class
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClass
{
    class VehicleProperties
    {
        private string _licencePlateNumber = "ADF 837";
        private string _colour = "Brick Red";
        private int _numberOfDoors = 4;
        private double _speed = 15;
        private double _maximumSpeed = 40;

        public double Acceleration(double time)
        {//This calculates acceleration
            double accelerationOfCar;

            accelerationOfCar = (this._maximumSpeed - this._speed) / time;

            return accelerationOfCar;
        }
        public double Brakes(double time)
        {//This calculates the decceleration while braking
            double brakingDeccel;
            double stop;

            stop = 0;

            brakingDeccel = (stop - this._speed) / time;

            return brakingDeccel;
        }
        public string CurrentState()
        {//This compiles all as a string.
            string returnString;

            returnString = "Licence Plate: "+ this._licencePlateNumber + " Colour: " + this._colour + "\n" +" # Of Doors: " + this._numberOfDoors + " Current Speed: " + this._speed + " Max Speed: " + this._maximumSpeed;

            return returnString;
        }
    }
}
