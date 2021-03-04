using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealtyAgency
{
    public partial class RieltorsList : Form
    {
        private Form FormToBack;
        public RieltorsList(User User)
        {
            InitializeComponent();
            FormToBack = User;
        }

        private void RieltorsList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void GoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            FormToBack.Show();
        }
    }
}
