

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SailSafe___1413042
{
    public class Sailing
    {
        #region Member Variables (Instance and Static)
        public readonly static string destPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static string destFile = Path.Combine(destPath, "SailSafeLog.txt");

        bool directionNtoS;
        bool directionStoN;
        int _time;

        public List<Lane> lanes = new List<Lane>();
        #endregion

        #region Constructor
        public Sailing()
        {
            for (int n = 0; n < 3; n++)
            {
                lanes.Add(new Lane(30, 0));
            }

            LoadFromExSource();
        }
        #endregion

        #region Class Methods
        /// <summary>
        /// Method to Load Contents of the External Text File
        /// </summary>
        private void LoadFromExSource()
        {
            StreamReader inputStream = new StreamReader(destFile);
            while(!inputStream.EndOfStream)
            {
                Vehicle newBooking = Vehicle.Load(inputStream);
                lanes.Add(newBooking);
            }

            inputStream.Close();
        }

        /// <summary>
        /// Method to Save Contents to the External Text File
        /// </summary>
        public void SaveToExSource()
        {
            StreamWriter outputStream = new StreamWriter(destFile);
            for (int i=0; i<lanes.Count; i++)
            {
                lanes[i].SaveLaneData(outputStream);
            }

            outputStream.Close();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignIn());
        }
        #endregion
    }
}
