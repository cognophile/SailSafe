
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SailSafe___1413042
{
    public class Booking
    {
        #region Instance Variables
        protected int time;
        protected bool directionNtoS;
        protected bool directionStoN;
        #endregion

        #region Encapsulation of Variable Properties
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
        
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"> The Full Name of the Guest to be Booked </param>
        /// <param name="license"> The License Plate of the Guest's Vehicle </param>
        /// <param name="time"> The Sailing Time the Guest will be booked for </param>
        /// <param name="direction"></param>
        public Booking(string name, string license, int time, bool directionNtoS, bool directionStoN)
        {
            Name = name;
            License = license;
            this.time = time;
            this.directionNtoS = directionNtoS;
            this.directionStoN = directionStoN;
        }
        #endregion 
    }
}
