using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemOne.BL
{
    class ship
    {
        public ship()
        {

        }

        public ship(string shipNumber, string shipLocation)
        {
            this.shipNumber = shipNumber;
            this.shipLocation = shipLocation;
        }

        public void printPosition(string latitudeValue, string longitudeValue)
        {
            Console.WriteLine("Ship is {0} and {1}", latitudeValue,longitudeValue);
        }
            
        public void printSerialNumber()
        {
            Console.WriteLine("Ship's serial number is " + shipNumber);
        }
        public string shipNumber;
        public string shipLocation;

    }
    class LatitudeAngle
    {
        public LatitudeAngle()
        {

        }
        public LatitudeAngle(int degrees, float minutes, char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.directiion = direction;
        }
        public string changeLatitudeAngleValue()
        {
            string angle = degrees + "\u00b0" + minutes + "' " + directiion;           
            return angle;
        }
        public int degrees;
        public float minutes;
        public char directiion;        
    }
    class LongitudeAngle
    {
        public LongitudeAngle()
        {

        }
        public LongitudeAngle(int degrees, float minutes, char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.directiion = direction;
        }
        public string changeLongitudeAngleValue()
        {
            string angle = degrees + "\u00b0" + minutes + "' " + directiion;
            return angle;
        }
        public int degrees;
        public float minutes;
        public char directiion;
    }
}
