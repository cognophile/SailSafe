﻿
using System.Text;
using System.IO;
using SailSafe.Models;

namespace SailSafe.Models
{
    class Van : Vehicle
    {
        public override int Length { get { return 5; } }

        public Van()
        {
            this.Type = VehicleType.Van;
        }

        ///// <summary>
        ///// Constructor for creating a new title.
        ///// </summary>
        ///// <param name="artist">The name of the artist</param>
        ///// <param name="title">The name of the work</param>
        ///// <param name="price">The retail price (in pounds sterling)</param>
        //public Van(string name, string license, int time, bool directionNtoS, bool directionStoN)
        //    : base(name, license, time, directionNtoS, directionStoN)
        //{
        //    this.Type = VehicleType.Van;
        //}

        ///// <summary>
        ///// Constructor for loading the data from a text string
        ///// </summary>
        ///// <param name="source"> ',' delimited string of data read back in from a file </param>
        //public Van(string source)
        //{
        //    this.Type = VehicleType.Van;

        //    string[] data = source.Split(',');
        //    Builder(data[1], data[2], int.Parse(data[3]), bool.Parse(data[4]),
        //        bool.Parse(data[5]));
        //}

        ///// <summary>
        ///// Save the state of the object to a stream
        ///// </summary>
        ///// <param name="outputStream">An output stream</param>
        //public override void SaveLaneData(StreamWriter outputStream)
        //{
        //    string output = string.Join(", ", Type, Name, License, Time, DirectionNtoS, DirectionStoN, VehicleLength);
        //    outputStream.WriteLine(output);
        //}
    }
}
