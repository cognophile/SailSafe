using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

using SailSafe.Models;
using SailSafe.Utilities;
using System.Runtime.CompilerServices;

namespace SailSafe.Models
{
    public class Sailing
    {
        public int Id { get; set; }
        public string Direction { get; set; }
        public DateTime Time { get; set; }
        public List<Lane> lanes;

        public Sailing(string time)
        {
            this.Initialise();
            this.SetTimeAndDirection(time);
        }

        private void Initialise()
        {
            this.lanes = new List<Lane>();
            var id = 1;

            for (int n = 0; n < 3; n++) {
                id = n + 1;
                lanes.Add(new Lane(id, 30, 0));
            }
        }

        public bool AssignLane(Vehicle vehicle)
        {
            var isAssigned = false;
            var laneId = this.FindSpace(vehicle.Length);

            if (laneId != 0) {
                var matchedLane = this.lanes.Find(lane => lane.Id == laneId);
                isAssigned = matchedLane.AddVehicle(vehicle);
            }

            return isAssigned;
        }

        private void SetTimeAndDirection(string time)
        {
            if (time.Contains("9am")) {
                this.Time = DateTimeHelper.ParseStringTime("09:00");
                this.Direction = SailingDirection.Northbound;
            }

            if (time.Contains("10am")) {
                this.Time = DateTimeHelper.ParseStringTime("10:00");
                this.Direction = SailingDirection.Southbound;
            }

            if (time.Contains("4pm")) {
                this.Time = DateTimeHelper.ParseStringTime("16:00");
                this.Direction = SailingDirection.Northbound;
            }

            if (time.Contains("5pm")) {
                this.Time = DateTimeHelper.ParseStringTime("17:00");
                this.Direction = SailingDirection.Southbound;
            }
        }

        private int FindSpace(int vehicleLength)
        {
            foreach(Lane lane in this.lanes) {
                if (lane.HasSpace(vehicleLength)) {
                    return lane.Id;
                }
            }

            return 0;
        }

        ///// <summary>
        ///// Method to Load Contents of the External Text File
        ///// </summary>
        //private void LoadFromExSource()
        //{
        //    StreamReader inputStream = new StreamReader(destFile);
        //    while(!inputStream.EndOfStream)
        //    {
        //        Vehicle newBooking = Vehicle.Load(inputStream);
        //        lanes.Add(newBooking);
        //    }

        //    inputStream.Close();
        //}

        ///// <summary>
        ///// Method to Save Contents to the External Text File
        ///// </summary>
        //public void SaveToExSource()
        //{
        //    StreamWriter outputStream = new StreamWriter(destFile);
        //    for (int i = 0; i < lanes.Count; i++)
        //    {
        //        lanes[i].SaveLaneData(outputStream);
        //    }

        //    outputStream.Close();
        //}

        //private void WriteLaneData(StreamWriter outputStream, Lane lane, Vehicle vehicle) 
        //{
        //    string output = string.Join(", ", vehicle.Type, vehicle.Name, vehicle.License, vehicle.Time, vehicle.DirectionNtoS, vehicle.DirectionStoN, vehicle.VehicleLength);
        //    outputStream.WriteLine(output);
        //}

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
