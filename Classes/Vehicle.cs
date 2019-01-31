
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SailSafe___1413042
{
    // Documentaion Reference for explanation of Improper OOP practice, using inheritence.
    public class Vehicle : Lane
    {
        #region Member Variables

        // Instance Variables
        protected int time;
        protected bool directionNtoS;
        protected bool directionStoN;
        

        protected int vehicleLength;
        //protected string vehicleType;
        //protected string license;
        #endregion

        #region Encapsulating Variable Properties
        // C# 3.0 - Shorthand Encapsulation of Properties - Ref:
        // Lynda - Course: C# Essential Training (Section 8.4 - 'Declaring properties with shorthand get and set methods')
        public string Name { get; set; }
        public string License { get; set; }
        
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

        ///// <summary>
        ///// License here will allow the storage of just a vehicle object in the lane, referencable by the license (comparing lanes to bookings to find a match?)
        ///// </summary>
        //public string License
        //{
        //    get { return this.license; }
        //    set { this.license = value; }
        //}
        #endregion

        #region Constructors
        // Empty Constructor - Allows blank constructor or overloaded constructors
        public Vehicle()
        {
        }
        
        /// <summary>
        /// Vehicle Class Constructor - Instantiation allows for definition of a vehicle type and length for that Object reference (eg. Car)
        /// Rad Buttons that create new Vehicle Objects with specific type/length?
        /// </summary>
        //public Vehicle(string vehicleType, int vehicleLength)
        //{
        //    this.vehicleType = vehicleType;
        //    this.vehicleLength = vehicleLength;
        //}

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
        #endregion

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
            if (dataInput.StartsWith(Car.VehicleType))
            {
                data = new Car(dataInput);
            }

            if (dataInput.StartsWith(Van.VehicleType))
            {
                data = new Van(dataInput);
            }

            if (dataInput.StartsWith(Large.VehicleType))
            {
                data = new Large(dataInput);
            }

            return data;
        }

    }
}
