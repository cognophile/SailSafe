
using System.Text;
using System.IO;

namespace SailSafe___1413042
{
    class Large : Vehicle
    {
        #region Class Variables
        public const string VehicleType = "Large";
        // Override - Polymorphism use - overrides the value of VehicleLength depending on which Vehicle class is called.
        // Cite: https://www.youtube.com/watch?v=4a_iTOtGhM8&list=PLAC325451207E3105&index=23
        public override int VehicleLength { get { return 15; } }
        #endregion

        #region Constructors
        public Large()
        {
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
        }

        /// <summary>
        /// Constructor for loading the data from a text string
        /// </summary>
        /// <param name="source"> ',' delimited string of data read back in from a file </param>
        public Large(string source)
        {
            string[] data = source.Split(',');
            Builder(data[1], data[2], int.Parse(data[3]), bool.Parse(data[4]),
                bool.Parse(data[5]));
        }
        #endregion

        /// <summary>
        /// Save the state of the object to a stream
        /// </summary>
        /// <param name="outputStream">An output stream</param>
        public override void SaveLaneData(StreamWriter outputStream)
        {
            string output = string.Join(", ", VehicleType, Name, License, Time, DirectionNtoS, DirectionStoN, VehicleLength);
            outputStream.WriteLine(output);
        }
    }
}
