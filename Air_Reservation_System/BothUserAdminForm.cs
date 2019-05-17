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
    public partial class BothUserAdminForm : Form
    {
        public BothUserAdminForm()
        {
            InitializeComponent();
        }

        private void LIA_Admin_Click(object sender, EventArgs e)
        {
            AdminLogin aL = new AdminLogin();
            this.Hide();
            aL.Show();

        }

        private void LIA_User_Click(object sender, EventArgs e)
        {
            CustomerLoginPanel cp1=new CustomerLoginPanel();
            cp1.Show();
            this.Hide();
        }
    }
}
