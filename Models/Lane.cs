using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace SailSafe.Models
{
    public class Lane 
    {
        public int Id { get; set; }
        private const int MAX_LENGTH = 30;
        public int SpaceAvailable { get; set; } = MAX_LENGTH;
        public int SpaceOccupied { get; set; } = 0;
        private List<Vehicle> vehicles = new List<Vehicle>();

        /// <summary>
        /// Lane object Constructor
        /// </summary>
        public Lane()
        { 
        }

        /// <summary>
        /// Overloaded Lane Object Constructor
        /// </summary>
        /// <param name="laneId"> Id number to assign the lane </param>
        /// <param name="spaceAvailable"> The amount of space currently available in the Lane Object </param>
        /// <param name="spaceOccupied"> The amount of space currently occupied in the Lane Object </param>
        public Lane(int laneId, int spaceAvailable, int spaceOccupied)
        {
            this.Id = laneId;
            this.SpaceAvailable = spaceAvailable;
            this.SpaceOccupied = spaceOccupied;
        }

        public bool AddVehicle(Vehicle vehicle)
        {
            bool addSuccessful = false;

            if (this.HasSpace(vehicle.Length)) {
                this.SpaceOccupied += vehicle.Length;
                this.SpaceAvailable -= vehicle.Length;
                this.vehicles.Add(vehicle);

                addSuccessful = true;
                return addSuccessful;
            }

            return addSuccessful;
        }

        public bool HasSpace(int vehicleLength)
        {
            return (this.SpaceAvailable >= vehicleLength && this.SpaceOccupied < MAX_LENGTH);
        }

        public virtual void SaveLaneData(StreamWriter outputStream) { }

        ///// <summary>
        ///// Add a vehicle object to a Lane
        ///// </summary>
        ///// <param name="currentToAdd"> Incoming vehicle type </param>
        //public void BookPlace(Vehicle currentToAdd)
        //{
        //    bool success = false;
        //    Sailing objRef = new Sailing();

        //    while (success)
        //    {
        //        for (int n = 0; n < objRef.lanes.Count; n++)
        //        {
        //            if (objRef.lanes[n].SpaceAvailable > currentToAdd.VehicleLength)
        //            {
        //                objRef.lanes.Add(currentToAdd);
        //                objRef.lanes[n].SpaceAvailable -= currentToAdd.VehicleLength;
        //                objRef.lanes[n].SpaceOccupied += currentToAdd.VehicleLength;
        //                success = true;
        //                break;
        //            }
        //        }
        //    }
        //}
        
        ///// <summary>
        ///// Remove a Vehicle booking object reference from the List
        ///// </summary>
        ///// <param name="currentToRemove"></param>
        //public void RemoveVehicle(Vehicle currentToRemove)
        //{
        //    bool success = false;
        //    Sailing objRef = new Sailing();

        //    while (success == false)
        //    {
        //        for (int n = 0; n < objRef.lanes.Count; n++)
        //        {
        //            if (objRef.lanes[n] == currentToRemove)
        //            {
        //                // Remove the Entry from the List and add the VechileLength to the Space Available counter
        //                // Deduct VehicleLength from the Space Occupied counter
        //                objRef.lanes.Remove(currentToRemove);
        //                objRef.lanes[n].SpaceAvailable += currentToRemove.VehicleLength;
        //                objRef.lanes[n].SpaceOccupied -= currentToRemove.VehicleLength;
        //                success = true;
        //                break;
        //            }
        //        }
        //    }
        //}
        
        ///// <summary>
        ///// Locate a Vehicle Object reference in the List
        ///// </summary>
        //public void FindVehicle(Vehicle currentToFind)
        //{
        //    bool success = false;
        //    Sailing objRef = new Sailing();

        //    while (success == false)
        //    {
        //        foreach (var item in objRef.lanes)
        //        {
        //            if(item == currentToFind)
        //            {
        //                // Place the found items details into a string builder for reference to when displaying in list view
        //                StringBuilder foundVehicle = new StringBuilder();
        //                foundVehicle.Append(
        //                    currentToFind.Name + ","
        //                    + currentToFind.License + ","
        //                    + currentToFind.Time.ToString() + ","
        //                    + currentToFind.DirectionNtoS.ToString() + ","
        //                    + currentToFind.DirectionStoN.ToString() + ","
        //                    + currentToFind.VehicleLength.ToString() + ","
        //                );

        //                success = true;
        //                break;
        //            }
        //        }
        //    }
        //}
    }
}
