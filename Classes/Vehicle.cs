using System.IO;
using SailSafe.Classes;

namespace SailSafe
{
    public class Vehicle : Lane
    {
        protected int time;
        protected bool directionNtoS;
        protected bool directionStoN;
        protected int vehicleLength;

        // C# 3.0 - Shorthand Encapsulation of Properties - Ref:
        // Lynda - Course: C# Essential Training (Section 8.4 - 'Declaring properties with shorthand get and set methods')
        public string Name { get; set; }
        public string License { get; set; }
        public string Type { get; set; }

        public int Time
        {
            get { return this.time; }
            set { this.time = value; }
        }
        
        public bool DirectionNtoS
        {
            get { return this.directionNtoS; }
            set { this.directionNtoS = value; }
        }
        
        public bool DirectionStoN
        {
            get { return this.directionStoN; }
            set { this.directionStoN = value; }
        }

        public virtual int VehicleLength
        {
            get { return this.vehicleLength; }
            set { this.vehicleLength = value; }
        }

        public Vehicle()
        {
        }

        /// <summary>
        /// Constructor for creating a new title.
        /// </summary>
        /// <param name="artist">The name of the artist</param>
        /// <param name="title">The name of the work</param>
        /// <param name="price">The retail price (in pounds sterling)</param>
        public Vehicle(string name, string license, int time, bool directionNtoS, bool directionStoN)
        {
            Builder(name, license, time, directionNtoS, directionStoN);
        }

        /// <summary>
        /// Method for assisting construction, shared between constructor types
        /// </summary>
        /// <param name="artist">The name of the artist</param>
        /// <param name="title">The name of the work</param>
        /// <param name="price">The retail price (in pounds sterling)</param>
        /// <param name="copiesSold">The number of copies already sold</param>
        /// <param name="copiesShelf">The number available on the shelf</param>
        /// <param name="copiesStock">The number available in storage</param>
        protected void Builder(string name, string license, int time, bool directionNtoS, bool directionStoN)
        {
            Name = name;
            License = license;
            this.time = time;
            this.DirectionNtoS = directionNtoS;
            this.DirectionStoN = directionStoN;
        }

        /// <summary>
        /// Load in the Text file contents
        /// </summary>
        /// <param name="inputStream"> Pass in a stream/path to load </param>
        /// <returns></returns>
        public static Vehicle Load(StreamReader inputStream)
        {
            Vehicle data = null;
            string dataInput = inputStream.ReadLine();

            // Find a way to append a lane ID to the stream data
            if (dataInput.StartsWith(VehicleType.Car))
            {
                data = new Car(dataInput);
            }

            if (dataInput.StartsWith(VehicleType.Van))
            {
                data = new Van(dataInput);
            }

            if (dataInput.StartsWith(VehicleType.Large))
            {
                data = new Large(dataInput);
            }

            return data;
        }

    }
}
