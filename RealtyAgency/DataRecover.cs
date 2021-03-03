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
    public partial class DataRecover : Form
    {
        public DataRecover()
        {
            InitializeComponent();
        }

        private void ShowTipLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Секретный ключ - уникальная последовательность символов, выданная вам при регистрации");
        }
    }
}
