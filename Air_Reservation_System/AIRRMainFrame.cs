using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_Reservation_System
{
    public partial class AIRRMainFrame : Form
    {
        public AIRRMainFrame()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainFLogin_Click(object sender, EventArgs e)
        {
            BothUserAdminForm u2= new BothUserAdminForm();
            u2.Show();
        }

        private void Main_SeeAvailFlight_Click(object sender, EventArgs e)
        {
            Flight_Details fDF = new Flight_Details(this);
            fDF.Show();
            this.Hide();
        }

        private void Main_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developped by ........\n\n1. Most. Afia Tamanna [15-30519-3]\n\n2. Sarker, MD.Mamunuz Zaman [15-29817-2]\n\n3. Pranti, Most. Plaby Joynab [13-25454-3]\n\n4. Eiaser Arafat [14-27170-2]\n\n");

        }

        private void AIRRMainFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
