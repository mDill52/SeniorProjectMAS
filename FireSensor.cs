using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProjectMAS
{
    class FireSensor
    {
        private int id;
        private string location;
        private bool sensorActivated;

        // constructors 
        public FireSensor()
        {
            id = 0;
            location = "Unknown";
            sensorActivated = false;
        }
        public FireSensor(int sensorId, string sensorLocation)
        {
            id = sensorId;
            location = sensorLocation;
            sensorActivated = false;
        }
        ~FireSensor()
        {
            Console.WriteLine("Destructor was called");
        }
        //behaviors
        public bool ActivateSensor()
        {
            if (sensorActivated == false)
            {
                Console.WriteLine("\nFire Sensor " + Convert.ToString(id) + " has been activated.");
                sensorActivated = true;
                return true;
            }
            else
            {
                Console.WriteLine("\nError, fire sensor " + Convert.ToString(id) + " is already active.");
                sensorActivated = true;
                return true;
            }
        }
        public bool DeactivateSensor()
        {
            if (sensorActivated == true)
            {
                Console.WriteLine("\nFire Sensor " + Convert.ToString(id) + " has been deactivated.");
                sensorActivated = false;
                return false;
            }
            else
            {
                Console.WriteLine("\nError. Fire Sensor " + Convert.ToString(id) + " is not active.");
                sensorActivated = false;
                return false;
            }
        }
        public bool ResetSensor()
        {
            if (sensorActivated == true)
            {
                Console.WriteLine("\nFire Sensor " + Convert.ToString(id) + " has been reset.");
                sensorActivated = true;
                return true;
            }
            else
            {
                Console.WriteLine("\nError. Fire Sensor " + Convert.ToString(id) + " is not active.");
                sensorActivated = false;
                return false;

            }

        }
        public void SensorStatus()
        {
            if (sensorActivated == true)
            {
                Console.WriteLine("Active");
                sensorActivated = true;
            }
            else
            {
                Console.WriteLine("Inactive");
                sensorActivated = false;
            }
        }

    }
}
