
using System.Text;
using System.IO;
using SailSafe.Classes;

namespace SailSafe
{
    class Large : Vehicle
    {
        public override int VehicleLength { get { return 15; } }

        public Large()
        {
            this.Type = VehicleType.Large;
        }

        /// <summary>
        /// Constructor for creating a new title.
        /// </summary>
        /// <param name="artist">The name of the artist</param>
        /// <param name="title">The name of the work</param>
        /// <param name="price">The retail price (in pounds sterling)</param>
        public Large(string name, string license, int time, bool directionNtoS, bool directionStoN)
            : base(name, license, time, directionNtoS, directionStoN)
        {
            this.Type = VehicleType.Large;
        }

        /// <summary>
        /// Constructor for loading the data from a text string
        /// </summary>
        /// <param name="source"> ',' delimited string of data read back in from a file </param>
        public Large(string source)
        {
            this.Type = VehicleType.Large;

            string[] data = source.Split(',');
            Builder(data[1], data[2], int.Parse(data[3]), bool.Parse(data[4]),
                bool.Parse(data[5]));
        }

        /// <summary>
        /// Save the state of the object to a stream
        /// </summary>
        /// <param name="outputStream">An output stream</param>
        public override void SaveLaneData(StreamWriter outputStream)
        {
            string output = string.Join(", ", Type, Name, License, Time, DirectionNtoS, DirectionStoN, VehicleLength);
            outputStream.WriteLine(output);
        }
    }
}
