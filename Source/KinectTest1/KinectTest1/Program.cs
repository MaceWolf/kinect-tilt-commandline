using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Kinect;

namespace KinectTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 0;
            /*Console.WriteLine("Number of command line parameters = {0}", args.Length);

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
                if (i == 0)
                    val = Convert.ToInt32(args[i]);
            }*/
            val = Convert.ToInt32(args[0]);
            

            KinectSensor sensor = KinectSensor.KinectSensors[0];

            sensor.Start();

            sensor.ElevationAngle = Convert.ToInt32(val);

            sensor.Stop();
        }
    }
}
