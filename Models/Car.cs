using System.IO;
using SailSafe.Models;

namespace SailSafe.Models
{
    class Car : Vehicle
    {
        public override int Length { get { return 3; } }

        public Car ()
        {
            this.Type = VehicleType.Car;
        }

        ///// <summary>
        ///// Constructor for creating a new title.
        ///// </summary>
        ///// <param name="artist">The name of the artist</param>
        ///// <param name="title">The name of the work</param>
        ///// <param name="price">The retail price (in pounds sterling)</param>
        //public Car(string name, string license, int time, bool directionNtoS, bool directionStoN)
        //    : base(name, license, time, directionNtoS, directionStoN)
        //{
        //    this.Type = VehicleType.Car;
        //}

        ///// <summary>
        ///// Constructor for loading the data from a text string
        ///// </summary>
        ///// <param name="source"> ',' delimited string of data read back in from a file </param>
        //public Car(string source)
        //{
        //    this.Type = VehicleType.Car;

        //    string[] data = source.Split(',');
        //    Builder(data[1], data[2], int.Parse(data[3]), bool.Parse(data[4]),
        //        bool.Parse(data[5]));
        //}
    }
}
