using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;

namespace ParkingSystemApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunParkingSystem();
        }
        static void RunParkingSystem()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }
}
