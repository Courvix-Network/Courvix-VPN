using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courvix_VPN.Forms
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(string title, string message)
        {
            InitializeComponent();
            this.title.Text = title;
            this.description.Text = message;
        }

        public static DialogResult Show(string title, string description)
        {
            return new CustomMessageBox(title, description).ShowDialog();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}
