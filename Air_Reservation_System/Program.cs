using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_Reservation_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Flight_Details());
            //Application.Run(new Seat_Booking());
            //Application.Run(new CustomerInfoPanel());
            //Application.Run(new AdminPanel());
            //Application.Run(new AdminLogin());
            Application.Run(new AIRRMainFrame());
            
        }
    }
}
